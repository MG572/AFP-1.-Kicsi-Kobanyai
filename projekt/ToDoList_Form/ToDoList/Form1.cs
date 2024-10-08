using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            priorityComboBox.Items.AddRange(new string[] { "Alacsony", "Közepes", "Magas" });

            sortComboBox.Items.AddRange(new string[] { "Név szerint", "Prioritás szerint", "Dátum szerint" });
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;

            taskListBox.DrawMode = DrawMode.OwnerDrawFixed;
            taskListBox.DrawItem += taskListBox_DrawItem;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string task = taskNameTextBox.Text;
            string priority = priorityComboBox.SelectedItem?.ToString() ?? "Nincs megadva";
            string date = dateTimePicker.Value.ToShortDateString();
            string completed = doneCheckBox.Checked ? "Kész" : "";

            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Kérlek, add meg a feladatot!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                taskListBox.Items.Add($"{task} - Prioritás: {priority} - Dátum: {date} - {completed}");
                ClearFields();

            }

        }

        private void taskListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string taskItem = taskListBox.Items[e.Index].ToString();

            bool isCompleted = taskItem.Contains("Kész");

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
                    doneCheckBox.Checked = parts[3].Trim() == "Kész";
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
            DialogResult result = MessageBox.Show("Biztosan ki szeretnél lépni?", "Kilépés megerõsítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                string completed = doneCheckBox.Checked ? "Kész" : "";

                if (!string.IsNullOrEmpty(task))
                {
                    // Kikapcsoljuk a SelectedIndexChanged eseménykezelõt, hogy ne zavarjon bele
                    taskListBox.SelectedIndexChanged -= taskListBox_SelectedIndexChanged;

                    int selectedIndex = taskListBox.SelectedIndex;
                    taskListBox.Items[selectedIndex] = $"{task} - Prioritás: {priority} - Dátum: {date} - {completed}";

                    // Visszakapcsoljuk a SelectedIndexChanged eseménykezelõt
                    taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;

                    taskListBox.Invalidate();  // Frissítés a kijelölt soron
                    ClearFields();  // Mezõk ürítése
                }
                else
                {
                    MessageBox.Show("Kérlek, add meg a feladatot!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show("Feladatok mentve a Teendok.txt fájlba.", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Válassz egy teendõ listát";

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

                    MessageBox.Show("Teendõk sikeresen importálva.", "Importálás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba a fájl olvasásakor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (sortBy == "Név szerint")
            {
                tasks = tasks.OrderBy(task => task.Split('-')[0].Trim()).ToList();
            }
            else if (sortBy == "Prioritás szerint")
            {
                tasks = tasks.OrderBy(task => task.Split('-')[1].Trim().Split(':')[1].Trim()).ToList();
            }
            else if (sortBy == "Dátum szerint")
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
