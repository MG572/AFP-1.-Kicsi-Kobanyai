namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            App_quit = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            listBoxTasks = new ListBox();
            label3 = new Label();
            textBoxTask = new TextBox();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            comboBoxPriority = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            checkBoxCompleted = new CheckBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(App_quit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 60);
            panel1.TabIndex = 0;
            // 
            // App_quit
            // 
            App_quit.BackColor = Color.Black;
            App_quit.Dock = DockStyle.Right;
            App_quit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            App_quit.ForeColor = SystemColors.Window;
            App_quit.Location = new Point(1013, 0);
            App_quit.Name = "App_quit";
            App_quit.Size = new Size(75, 60);
            App_quit.TabIndex = 7;
            App_quit.Text = "Kilépés";
            App_quit.UseVisualStyleBackColor = false;
            App_quit.Click += App_quit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(471, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 50);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 530);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 29);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(521, 5);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 0;
            label2.Text = "© Kőbányai";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1088, 470);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = SystemColors.WindowFrame;
            listBoxTasks.ForeColor = SystemColors.Window;
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(12, 157);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(592, 349);
            listBoxTasks.TabIndex = 1;
            listBoxTasks.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 1;
            label3.Text = "Feladat neve:";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = Color.Black;
            textBoxTask.ForeColor = SystemColors.Window;
            textBoxTask.Location = new Point(146, 98);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(128, 25);
            textBoxTask.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(773, 272);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(182, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(298, 98);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Prioritás:";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.BackColor = Color.Black;
            comboBoxPriority.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            comboBoxPriority.ForeColor = SystemColors.Window;
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(396, 98);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(121, 25);
            comboBoxPriority.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(816, 244);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 4;
            label5.Text = "Határidő";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(536, 96);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 5;
            label6.Text = "Kész van- e";
            // 
            // checkBoxCompleted
            // 
            checkBoxCompleted.AutoSize = true;
            checkBoxCompleted.BackColor = Color.Black;
            checkBoxCompleted.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBoxCompleted.ForeColor = SystemColors.Window;
            checkBoxCompleted.Location = new Point(566, 124);
            checkBoxCompleted.Name = "checkBoxCompleted";
            checkBoxCompleted.Size = new Size(52, 19);
            checkBoxCompleted.TabIndex = 6;
            checkBoxCompleted.Text = "Kész";
            checkBoxCompleted.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Black;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdd.ForeColor = SystemColors.Window;
            buttonAdd.Location = new Point(651, 157);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(89, 60);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Hozzád";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Black;
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonEdit.ForeColor = SystemColors.Window;
            buttonEdit.Location = new Point(816, 157);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(89, 60);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Szerkeszt";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(970, 157);
            button4.Name = "button4";
            button4.Size = new Size(89, 60);
            button4.TabIndex = 10;
            button4.Text = "Töröl";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button5.ForeColor = SystemColors.Window;
            button5.Location = new Point(816, 464);
            button5.Name = "button5";
            button5.Size = new Size(89, 60);
            button5.TabIndex = 11;
            button5.Text = "Fájlba írás";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 559);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(checkBoxCompleted);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxPriority);
            Controls.Add(label4);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxTask);
            Controls.Add(label3);
            Controls.Add(listBoxTasks);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "ToDoList";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox listBoxTasks;
        private Label label3;
        private TextBox textBoxTask;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private ComboBox comboBoxPriority;
        private Label label5;
        private Label label6;
        private CheckBox checkBoxCompleted;
        private Button App_quit;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button button4;
        private Button button5;
    }
}
