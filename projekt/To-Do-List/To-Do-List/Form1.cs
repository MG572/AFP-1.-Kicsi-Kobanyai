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
            string completed = checkBoxCompleted.Checked ? "K�sz" : "";

            if (!string.IsNullOrWhiteSpace(task))
            {
                listBoxTasks.Items.Add($"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}");
                ClearFields(); // T�r�lni a mez�ket
            }
            else
            {
                MessageBox.Show("K�rlek, add meg a feladatot!", "Figyelmeztet�s", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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