using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string task = textBoxTask.Text;
            string priority = comboBoxPriority.SelectedItem?.ToString() ?? "Nincs megadva";
            string date = dateTimePicker.Value.ToShortDateString();
            string completed = checkBoxCompleted.Checked ? "Kész" : "";

            if (!string.IsNullOrWhiteSpace(task))
            {
                listBoxTasks.Items.Add($"{task} - Prioritás: {priority} - Dátum: {date} - {completed}");
                ClearFields(); // Törölni a mezõket
            }
            else
            {
                MessageBox.Show("Kérlek, add meg a feladatot!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void ClearFields()
        {
            textBoxTask.Clear();
            comboBoxPriority.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
            checkBoxCompleted.Checked = false;
        }
    }
}