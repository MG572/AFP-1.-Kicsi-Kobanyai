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
            buttonDeleteAll = new Button();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Microsoft New Tai Lue", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1054, 0);
            button1.Name = "button1";
            button1.Size = new Size(33, 27);
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
            label1.Location = new Point(447, 7);
            label1.Name = "label1";
            label1.Size = new Size(200, 51);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 219, 87);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 530);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 29);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
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
            pictureBox1.Click += Form1_Load;
            // 
            // taskListBox
            // 
            taskListBox.BackColor = Color.FromArgb(245, 201, 41);
            taskListBox.ForeColor = Color.Black;
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(12, 179);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(588, 304);
            taskListBox.TabIndex = 1;
            taskListBox.DrawItem += taskListBox_DrawItem;
            taskListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 1;
            label3.Text = "Feladat neve:";
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.BackColor = Color.White;
            taskNameTextBox.ForeColor = Color.Black;
            taskNameTextBox.Location = new Point(161, 98);
            taskNameTextBox.Multiline = true;
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(128, 25);
            taskNameTextBox.TabIndex = 1;
            taskNameTextBox.Click += Form1_Load;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(245, 201, 41);
            dateTimePicker.CalendarTrailingForeColor = Color.Gray;
            dateTimePicker.Location = new Point(756, 282);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(207, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(298, 98);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Prioritás:";
            // 
            // priorityComboBox
            // 
            priorityComboBox.BackColor = Color.White;
            priorityComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            priorityComboBox.ForeColor = Color.Black;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(407, 98);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(121, 25);
            priorityComboBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(245, 201, 41);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(807, 244);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 4;
            label5.Text = "Határidő";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(540, 98);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 5;
            label6.Text = "Kész van- e";
            // 
            // doneCheckBox
            // 
            doneCheckBox.AutoSize = true;
            doneCheckBox.BackColor = Color.White;
            doneCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            doneCheckBox.ForeColor = Color.Black;
            doneCheckBox.Location = new Point(570, 125);
            doneCheckBox.Name = "doneCheckBox";
            doneCheckBox.Size = new Size(52, 19);
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
            buttonAdd.Location = new Point(724, 157);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 60);
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
            editButton.Location = new Point(603, 157);
            editButton.Name = "editButton";
            editButton.Size = new Size(118, 60);
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
            buttonDelete.Location = new Point(845, 157);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 60);
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
            outputButton.Location = new Point(794, 360);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(118, 60);
            outputButton.TabIndex = 11;
            outputButton.Text = "Fájlba írás";
            outputButton.UseVisualStyleBackColor = false;
            outputButton.Click += outputButton_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.FromArgb(192, 0, 0);
            buttonDeleteAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonDeleteAll.Location = new Point(966, 157);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(119, 60);
            buttonDeleteAll.TabIndex = 12;
            buttonDeleteAll.Text = "Minden törlése";
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 559);
            Controls.Add(buttonDeleteAll);
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
        private Button buttonDeleteAll;
    }
}
