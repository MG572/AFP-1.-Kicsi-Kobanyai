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
            taskListBox = new ListBox();
            label3 = new Label();
            taskNameTextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            priorityComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            doneCheckBox = new CheckBox();
            buttonAdd = new Button();
            editButton = new Button();
            deleteButton = new Button();
            outputButton = new Button();
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
            // taskListBox
            // 
            taskListBox.BackColor = SystemColors.WindowFrame;
            taskListBox.ForeColor = SystemColors.Window;
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(12, 157);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(592, 349);
            taskListBox.TabIndex = 1;
            taskListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            // taskNameTextBox
            // 
            taskNameTextBox.BackColor = Color.Black;
            taskNameTextBox.ForeColor = SystemColors.Window;
            taskNameTextBox.Location = new Point(146, 98);
            taskNameTextBox.Multiline = true;
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(128, 25);
            taskNameTextBox.TabIndex = 1;
            taskNameTextBox.Click += buttonAdd_Click;
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
            // priorityComboBox
            // 
            priorityComboBox.BackColor = Color.Black;
            priorityComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            priorityComboBox.ForeColor = SystemColors.Window;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(396, 98);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(121, 25);
            priorityComboBox.TabIndex = 1;
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
            // doneCheckBox
            // 
            doneCheckBox.AutoSize = true;
            doneCheckBox.BackColor = Color.Black;
            doneCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            doneCheckBox.ForeColor = SystemColors.Window;
            doneCheckBox.Location = new Point(566, 124);
            doneCheckBox.Name = "doneCheckBox";
            doneCheckBox.Size = new Size(52, 19);
            doneCheckBox.TabIndex = 6;
            doneCheckBox.Text = "Kész";
            doneCheckBox.UseVisualStyleBackColor = false;
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
            // editButton
            // 
            editButton.BackColor = Color.Black;
            editButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            editButton.ForeColor = SystemColors.Window;
            editButton.Location = new Point(816, 157);
            editButton.Name = "editButton";
            editButton.Size = new Size(89, 60);
            editButton.TabIndex = 9;
            editButton.Text = "Szerkeszt";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteButton.ForeColor = SystemColors.Window;
            deleteButton.Location = new Point(970, 157);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(89, 60);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Töröl";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // outputButton
            // 
            outputButton.BackColor = Color.Black;
            outputButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            outputButton.ForeColor = SystemColors.Window;
            outputButton.Location = new Point(816, 464);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(89, 60);
            outputButton.TabIndex = 11;
            outputButton.Text = "Fájlba írás";
            outputButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 559);
            Controls.Add(outputButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(buttonAdd);
            Controls.Add(doneCheckBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(priorityComboBox);
            Controls.Add(label4);
            Controls.Add(dateTimePicker);
            Controls.Add(taskNameTextBox);
            Controls.Add(label3);
            Controls.Add(taskListBox);
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
        private ListBox taskListBox;
        private Label label3;
        private TextBox taskNameTextBox;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private ComboBox priorityComboBox;
        private Label label5;
        private Label label6;
        private CheckBox doneCheckBox;
        private Button App_quit;
        private Button buttonAdd;
        private Button editButton;
        private Button deleteButton;
        private Button outputButton;
    }
}
