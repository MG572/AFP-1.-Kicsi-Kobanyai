using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxPriority.Items.AddRange(new string[] { "Alacsony", "Közepes", "Magas" });
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
    }
}
