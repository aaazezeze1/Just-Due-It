namespace DSA_FinalProject
{
    partial class ToDoListForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            TitleLabel = new Label();
            titleTextBox = new TextBox();
            label2 = new Label();
            toDoListView = new DataGridView();
            label1 = new Label();
            descriptionTextBox = new TextBox();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            label3 = new Label();
            taskTypeComboBox = new ComboBox();
            label4 = new Label();
            dueDateTimePicker = new DateTimePicker();
            searchTextBox = new TextBox();
            searchButton = new Button();
            sortTypeButton = new Button();
            sortDateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(38, 126);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(53, 34);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTextBox.Location = new Point(38, 163);
            titleTextBox.Multiline = true;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(476, 81);
            titleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 276);
            label2.Name = "label2";
            label2.Size = new Size(107, 34);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.White;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            toDoListView.DefaultCellStyle = dataGridViewCellStyle6;
            toDoListView.Location = new Point(536, 163);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersVisible = false;
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(825, 513);
            toDoListView.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dubai", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(402, 9);
            label1.Name = "label1";
            label1.Size = new Size(556, 110);
            label1.TabIndex = 6;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTextBox.Location = new Point(38, 313);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(476, 160);
            descriptionTextBox.TabIndex = 7;
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.Highlight;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newButton.ForeColor = Color.White;
            newButton.Location = new Point(617, 693);
            newButton.Name = "newButton";
            newButton.Size = new Size(171, 68);
            newButton.TabIndex = 8;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            newButton.MouseLeave += newButton_MouseLeave;
            newButton.MouseHover += newButton_MouseHover;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.Highlight;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(794, 693);
            editButton.Name = "editButton";
            editButton.Size = new Size(171, 68);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            editButton.MouseLeave += editButton_MouseLeave;
            editButton.MouseHover += editButton_MouseHover;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.Highlight;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(971, 693);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(171, 68);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            deleteButton.MouseLeave += deleteButton_MouseLeave;
            deleteButton.MouseHover += deleteButton_MouseHover;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.Highlight;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(1148, 693);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(171, 68);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            saveButton.MouseLeave += saveButton_MouseLeave;
            saveButton.MouseHover += saveButton_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 598);
            label3.Name = "label3";
            label3.Size = new Size(90, 34);
            label3.TabIndex = 12;
            label3.Text = "Due Date";
            // 
            // taskTypeComboBox
            // 
            taskTypeComboBox.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskTypeComboBox.FormattingEnabled = true;
            taskTypeComboBox.Location = new Point(38, 531);
            taskTypeComboBox.Name = "taskTypeComboBox";
            taskTypeComboBox.Size = new Size(476, 42);
            taskTypeComboBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 494);
            label4.Name = "label4";
            label4.Size = new Size(98, 34);
            label4.TabIndex = 14;
            label4.Text = "Task Type";
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.CalendarFont = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDateTimePicker.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDateTimePicker.Location = new Point(38, 635);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(476, 41);
            dueDateTimePicker.TabIndex = 15;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(536, 122);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for Task";
            searchTextBox.Size = new Size(422, 27);
            searchTextBox.TabIndex = 16;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.Highlight;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(971, 113);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(83, 44);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            searchButton.MouseLeave += searchButton_MouseLeave;
            searchButton.MouseHover += searchButton_MouseHover;
            // 
            // sortTypeButton
            // 
            sortTypeButton.BackColor = SystemColors.Highlight;
            sortTypeButton.FlatAppearance.BorderSize = 0;
            sortTypeButton.FlatStyle = FlatStyle.Flat;
            sortTypeButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortTypeButton.ForeColor = Color.White;
            sortTypeButton.Location = new Point(1060, 113);
            sortTypeButton.Name = "sortTypeButton";
            sortTypeButton.Size = new Size(158, 44);
            sortTypeButton.TabIndex = 18;
            sortTypeButton.Text = "Sort by Type";
            sortTypeButton.UseVisualStyleBackColor = false;
            sortTypeButton.Click += sortTypeButton_Click;
            sortTypeButton.MouseLeave += sortTypeButton_MouseLeave;
            sortTypeButton.MouseHover += sortTypeButton_MouseHover;
            // 
            // sortDateButton
            // 
            sortDateButton.BackColor = SystemColors.Highlight;
            sortDateButton.FlatAppearance.BorderSize = 0;
            sortDateButton.FlatStyle = FlatStyle.Flat;
            sortDateButton.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortDateButton.ForeColor = Color.White;
            sortDateButton.Location = new Point(1224, 113);
            sortDateButton.Name = "sortDateButton";
            sortDateButton.Size = new Size(137, 44);
            sortDateButton.TabIndex = 19;
            sortDateButton.Text = "Sort By Date";
            sortDateButton.UseVisualStyleBackColor = false;
            sortDateButton.Click += sortDateButton_Click;
            sortDateButton.MouseLeave += sortDateButton_MouseLeave;
            sortDateButton.MouseHover += sortDateButton_MouseHover;
            // 
            // ToDoListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1373, 781);
            Controls.Add(sortDateButton);
            Controls.Add(sortTypeButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(dueDateTimePicker);
            Controls.Add(label4);
            Controls.Add(taskTypeComboBox);
            Controls.Add(label3);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(toDoListView);
            Controls.Add(label2);
            Controls.Add(titleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ToDoListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoListApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox titleTextBox;
        private Label label2;
        private DataGridView toDoListView;
        private Label label1;
        private TextBox descriptionTextBox;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private Label label3;
        private ComboBox taskTypeComboBox;
        private Label label4;
        private DateTimePicker dueDateTimePicker;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button sortTypeButton;
        private Button sortDateButton;
    }
}
