namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxPriority.Items.AddRange(new string[] { "Alacsony", "K�zepes", "Magas" });
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
    }
}
