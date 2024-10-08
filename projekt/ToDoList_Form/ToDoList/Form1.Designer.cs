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
            button1 = new Button();
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
            buttonDelete = new Button();
            outputButton = new Button();
            button2 = new Button();
            sortComboBox = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1205, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(38, 36);
            button1.TabIndex = 12;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += App_quit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(511, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 62);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 219, 87);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 706);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1243, 39);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(595, 7);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "© Kőbányai";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 80);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1243, 626);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Form1_Load;
            // 
            // taskListBox
            // 
            taskListBox.BackColor = Color.FromArgb(245, 201, 41);
            taskListBox.ForeColor = Color.Black;
            taskListBox.FormattingEnabled = true;
            taskListBox.Location = new Point(14, 258);
            taskListBox.Margin = new Padding(3, 4, 3, 4);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(672, 404);
            taskListBox.TabIndex = 1;
            taskListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 131);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 1;
            label3.Text = "Feladat neve:";
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.BackColor = Color.White;
            taskNameTextBox.ForeColor = Color.Black;
            taskNameTextBox.Location = new Point(184, 131);
            taskNameTextBox.Margin = new Padding(3, 4, 3, 4);
            taskNameTextBox.Multiline = true;
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(241, 32);
            taskNameTextBox.TabIndex = 1;
            taskNameTextBox.Click += Form1_Load;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(245, 201, 41);
            dateTimePicker.CalendarTrailingForeColor = Color.Gray;
            dateTimePicker.Location = new Point(872, 361);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(236, 27);
            dateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(436, 131);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 3;
            label4.Text = "Prioritás:";
            // 
            // priorityComboBox
            // 
            priorityComboBox.BackColor = Color.White;
            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            priorityComboBox.ForeColor = Color.Black;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(560, 131);
            priorityComboBox.Margin = new Padding(3, 4, 3, 4);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(138, 29);
            priorityComboBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(245, 201, 41);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(922, 325);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 4;
            label5.Text = "Határidő";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(712, 131);
            label6.Name = "label6";
            label6.Size = new Size(144, 32);
            label6.TabIndex = 5;
            label6.Text = "Kész van- e";
            // 
            // doneCheckBox
            // 
            doneCheckBox.AutoSize = true;
            doneCheckBox.BackColor = Color.White;
            doneCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            doneCheckBox.ForeColor = Color.Black;
            doneCheckBox.Location = new Point(746, 167);
            doneCheckBox.Margin = new Padding(3, 4, 3, 4);
            doneCheckBox.Name = "doneCheckBox";
            doneCheckBox.Size = new Size(63, 24);
            doneCheckBox.TabIndex = 6;
            doneCheckBox.Text = "Kész";
            doneCheckBox.UseVisualStyleBackColor = false;
            doneCheckBox.CheckedChanged += doneCheckBox_CheckedChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdd.ForeColor = Color.Black;
            buttonAdd.Location = new Point(912, 209);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 80);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Hozzádás";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.White;
            editButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            editButton.ForeColor = Color.Black;
            editButton.Location = new Point(738, 209);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(135, 80);
            editButton.TabIndex = 9;
            editButton.Text = "Szerkesztés";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 0, 0);
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(1084, 209);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 80);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // outputButton
            // 
            outputButton.BackColor = Color.FromArgb(245, 201, 41);
            outputButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            outputButton.ForeColor = Color.Black;
            outputButton.Location = new Point(831, 504);
            outputButton.Margin = new Padding(3, 4, 3, 4);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(135, 80);
            outputButton.TabIndex = 11;
            outputButton.Text = "Fájlba írás";
            outputButton.UseVisualStyleBackColor = false;
            outputButton.Click += outputButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(245, 201, 41);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(985, 504);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(135, 80);
            button2.TabIndex = 12;
            button2.Text = "Importálás fájlból";
            button2.UseVisualStyleBackColor = false;
            button2.Click += importButton_Click;
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = Color.White;
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            sortComboBox.ForeColor = Color.Black;
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Location = new Point(138, 212);
            sortComboBox.Margin = new Padding(3, 4, 3, 4);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(138, 29);
            sortComboBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 213);
            label7.Name = "label7";
            label7.Size = new Size(121, 32);
            label7.TabIndex = 14;
            label7.Text = "Rendezés";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 745);
            Controls.Add(label7);
            Controls.Add(sortComboBox);
            Controls.Add(button2);
            Controls.Add(outputButton);
            Controls.Add(buttonDelete);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button buttonAdd;
        private Button editButton;
        private Button buttonDelete;
        private Button outputButton;
        private Button button1;
        private Button button2;
        private ComboBox sortComboBox;
        private Label label7;
    }
}
