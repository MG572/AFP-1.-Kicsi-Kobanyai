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
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;  // Kijel�lt sor esem�ny kezel�se
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
                taskListBox.Items.Add($"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}");
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
                    // Kikapcsoljuk a SelectedIndexChanged esem�nykezel�t a friss�t�s alatt
                    taskListBox.SelectedIndexChanged -= taskListBox_SelectedIndexChanged;

                    int selectedIndex = taskListBox.SelectedIndex;
                    taskListBox.Items[selectedIndex] = $"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}";

                    // Visszakapcsoljuk az esem�nykezel�t
                    taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;

                    taskListBox.Invalidate();  // Friss�t�s
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
                    // A feladat, priorit�s, d�tum �s k�sz �llapot be�ll�t�sa a mez�kbe
                    taskNameTextBox.Text = parts[0].Trim();
                    priorityComboBox.SelectedItem = parts[1].Split(':')[1].Trim();

                    // D�tum kinyer�se �s konvert�l�sa
                    string datePart = parts[2].Split(':')[1].Trim();
                    if (DateTime.TryParse(datePart, out DateTime dateValue))
                    {
                        dateTimePicker.Value = dateValue;
                    }
                    else
                    {
                        // Ha a d�tum nem �rv�nyes, itt kezelheted az esetet, pl. be�ll�thatsz egy alap�rtelmezett d�tumot
                        MessageBox.Show("�rv�nytelen d�tum form�tum.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dateTimePicker.Value = DateTime.Now; // vagy egy m�sik alap�rtelmezett d�tum
                    }

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

            // T�r�lj�k az �sszes elemet, majd �jra hozz�adjuk a rendezett list�t
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
                    // Konvert�ljuk a priorit�st az enum �rt�kre, majd vissza int-re
                    if (Enum.TryParse(priorityPart[1].Trim(), true, out Priority priority))
                    {
                        return (int)priority; // Magas: 0, K�zepes: 1, Alacsony: 2
                    }
                }
            }

            // Ha nem siker�lt kinyerni a priorit�st, visszaadunk egy magasabb alap�rtelmezett �rt�ket (itt a k�zepes)
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

            // Ha nem siker�lt kinyerni a d�tumot, visszaadunk egy alap�rtelmezett �rt�ket
            return DateTime.MinValue;
        }

        private string GetTaskName(string task)
        {
            var taskParts = task.Split('-');

            if (taskParts.Length >= 1)
            {
                return taskParts[0].Trim();
            }

            // Ha nem siker�lt kinyerni a nevet, visszaadunk egy �res stringet
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
