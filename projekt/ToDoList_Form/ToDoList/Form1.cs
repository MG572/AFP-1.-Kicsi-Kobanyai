using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            priorityComboBox.Items.AddRange(new string[] { "Alacsony", "K�zepes", "Magas" });
            sortComboBox.Items.AddRange(new string[] { "N�v szerint", "Priorit�s szerint", "D�tum szerint" });
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            taskListBox.DrawMode = DrawMode.OwnerDrawFixed;
            taskListBox.DrawItem += taskListBox_DrawItem;
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string task = taskNameTextBox.Text;
            string priority = priorityComboBox.SelectedItem?.ToString() ?? "Nincs megadva";
            string date = dateTimePicker.Value.ToShortDateString();
            string completed = doneCheckBox.Checked ? "K�sz" : "";

            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("K�rlek, add meg a feladatot!", "Figyelmeztet�s", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string newTask = $"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}";
                taskListBox.Items.Add(newTask);
                ClearFields();
            }
        }


        private void taskListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string taskItem = taskListBox.Items[e.Index].ToString();
            bool isCompleted = taskItem.Contains("K�sz");

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else if (isCompleted)
            {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            e.Graphics.DrawString(taskItem, e.Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void App_quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretn�l l�pni?", "Kil�p�s meger�s�t�se", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                string task = taskNameTextBox.Text;
                string priority = priorityComboBox.SelectedItem?.ToString() ?? "Nincs megadva";
                string date = dateTimePicker.Value.ToShortDateString();
                string completed = doneCheckBox.Checked ? "K�sz" : "";

                if (!string.IsNullOrEmpty(task))
                {
                    taskListBox.SelectedIndexChanged -= taskListBox_SelectedIndexChanged;

                    int selectedIndex = taskListBox.SelectedIndex;
                    taskListBox.Items[selectedIndex] = $"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}";

                    taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;

                    taskListBox.Invalidate();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("K�rlek, add meg a feladatot!", "Figyelmeztet�s", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void ClearFields()
        {
            taskNameTextBox.Clear();
            priorityComboBox.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
            doneCheckBox.Checked = false;
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                taskListBox.Items.Remove(taskListBox.SelectedItem);
                ClearFields();
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Teendok.txt"))
            {
                foreach (var item in taskListBox.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            MessageBox.Show("Feladatok mentve a Teendok.txt f�jlba.", "Ment�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "V�lassz egy teend� list�t";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName, System.Text.Encoding.UTF8);

                    foreach (string line in lines)
                    {
                        if (line.Contains("-"))
                        {
                            taskListBox.Items.Add(line);
                        }
                    }

                    MessageBox.Show("Teend�k sikeresen import�lva.", "Import�l�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba a f�jl olvas�sakor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                string selectedTask = taskListBox.SelectedItem.ToString();
                string[] parts = selectedTask.Split(new string[] { " - " }, StringSplitOptions.None);

                if (parts.Length >= 3)
                {
                    taskNameTextBox.Text = parts[0].Trim();
                    priorityComboBox.SelectedItem = parts[1].Split(':')[1].Trim();
                    dateTimePicker.Value = DateTime.Parse(parts[2].Split(':')[1].Trim());
                    doneCheckBox.Checked = selectedTask.Contains("K�sz");
                }
            }
        }


        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortComboBox.SelectedItem != null)
            {
                string selectedSort = sortComboBox.SelectedItem.ToString();
                SortTaskList(selectedSort);
            }
        }

        private void SortTaskList(string sortBy)
        {
            var tasks = taskListBox.Items.Cast<string>().ToList();

            if (sortBy == "N�v szerint")
            {
                tasks = tasks.OrderBy(task => GetTaskName(task)).ToList();
            }
            else if (sortBy == "Priorit�s szerint")
            {
                tasks = tasks.OrderBy(task => GetPriorityValue(task)).ToList();
            }
            else if (sortBy == "D�tum szerint")
            {
                tasks = tasks.OrderBy(task => GetTaskDate(task)).ToList();
            }
            taskListBox.Items.Clear();
            foreach (var task in tasks)
            {
                taskListBox.Items.Add(task);
            }
        }

        private int GetPriorityValue(string task)
        {
            var taskParts = task.Split('-');

            if (taskParts.Length >= 2)
            {
                var priorityPart = taskParts[1].Trim().Split(':');
                if (priorityPart.Length == 2)
                {
                    if (Enum.TryParse(priorityPart[1].Trim(), true, out Priority priority))
                    {
                        return (int)priority; // Magas: 0, K�zepes: 1, Alacsony: 2
                    }
                }
            }
            return (int)Priority.K�zepes;
        }
        public enum Priority
        {
            Magas,
            K�zepes,
            Alacsony
        }



        private DateTime GetTaskDate(string task)
        {
            var taskParts = task.Split('-');

            if (taskParts.Length >= 3)
            {
                var datePart = taskParts[2].Trim().Split(':');
                if (datePart.Length == 2)
                {
                    DateTime date;
                    if (DateTime.TryParse(datePart[1].Trim(), out date))
                    {
                        return date;
                    }
                }
            }
            return DateTime.MinValue;
        }

        private string GetTaskName(string task)
        {
            var taskParts = task.Split('-');

            if (taskParts.Length >= 1)
            {
                return taskParts[0].Trim();
            }
            return string.Empty;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        { }

        private void doneCheckBox_CheckedChanged(object sender, EventArgs e)
        { }

        private void panel2_Paint(object sender, PaintEventArgs e)
        { }
    }
}
