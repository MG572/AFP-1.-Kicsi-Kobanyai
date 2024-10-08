using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            priorityComboBox.Items.AddRange(new string[] { "Alacsony", "K�zepes", "Magas" });
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
                ClearFields(); // T�r�lni a mez�ket

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            taskListBox.DrawMode = DrawMode.OwnerDrawFixed;
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
                int selectedIndex = taskListBox.SelectedIndex;

                string task = taskNameTextBox.Text;
                string priority = priorityComboBox.SelectedItem?.ToString() ?? "Nincs megadva";
                string date = dateTimePicker.Value.ToShortDateString();
                string completed = doneCheckBox.Checked ? "K�sz" : "";

                if (!string.IsNullOrEmpty(task))
                {
                    taskListBox.Items[selectedIndex] = $"{task} - Priorit�s: {priority} - D�tum: {date} - {completed}";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doneCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taskListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = taskListBox.Items[e.Index].ToString();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else if (itemText.Contains("K�sz"))
            {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            Color textColor = Color.Black;

            e.Graphics.DrawString(itemText, e.Font, new SolidBrush(textColor), e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
