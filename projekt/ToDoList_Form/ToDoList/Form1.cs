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

            if (taskListBox.SelectedItem != null)
            {
                string selectedTask = taskListBox.SelectedItem.ToString();
                string[] parts = selectedTask.Split(new string[] { " - " }, StringSplitOptions.None);

                if (parts.Length >= 4)
                {
                    taskNameTextBox.Text = parts[0].Trim();
                    priorityComboBox.SelectedItem = parts[1].Trim().Split(':')[1].Trim();
                    dateTimePicker.Value = DateTime.Parse(parts[2].Trim().Split(':')[1].Trim());
                    doneCheckBox.Checked = parts[3].Trim() == "K�sz";
                }
            }
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
                    // Kikapcsoljuk a SelectedIndexChanged esem�nykezel�t, hogy ne zavarjon bele
                    taskListBox.SelectedIndexChanged -= taskListBox_SelectedIndexChanged;

                    int selectedIndex = taskListBox.SelectedIndex;
                    taskListBox.Items[selectedIndex] = $"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}";

                    // Visszakapcsoljuk a SelectedIndexChanged esem�nykezel�t
                    taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;

                    taskListBox.Invalidate();  // Friss�t�s a kijel�lt soron
                    ClearFields();  // Mez�k �r�t�se
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
                tasks = tasks.OrderBy(task => task.Split('-')[0].Trim()).ToList();
            }
            else if (sortBy == "Priorit�s szerint")
            {
                tasks = tasks.OrderBy(task => task.Split('-')[1].Trim().Split(':')[1].Trim()).ToList();
            }
            else if (sortBy == "D�tum szerint")
            {
                tasks = tasks.OrderBy(task => DateTime.Parse(task.Split('-')[2].Trim().Split(':')[1].Trim())).ToList();
            }

            taskListBox.Items.Clear();
            foreach (var task in tasks)
            {
                taskListBox.Items.Add(task);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doneCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
