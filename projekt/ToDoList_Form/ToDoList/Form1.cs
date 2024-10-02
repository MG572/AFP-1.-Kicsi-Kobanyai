using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            priorityComboBox.Items.AddRange(new string[] { "Alacsony", "Közepes", "Magas" });
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
                string task = taskListBox.Text;
                string priority = priorityComboBox.SelectedItem?.ToString() ?? "Nincs megadva";
                string date = dateTimePicker.Value.ToShortDateString();
                string completed = doneCheckBox.Checked ? "Kész" : "";

                if (!string.IsNullOrWhiteSpace(task))
                {
                    int selectedIndex = taskListBox.SelectedIndex;
                    taskListBox.Items[selectedIndex] = $"{task} - Prioritás: {priority} - Dátum: {date} - {completed}";
                    ClearFields();
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
        
    }
}
