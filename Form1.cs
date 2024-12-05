using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;

namespace DSA_FinalProject
{
    public partial class ToDoListForm : Form
    {
        // To Do Class for JSON data storage
        public class ToDoItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string TaskType { get; set; }
            public DateTime DueDate { get; set; }
        }

        public ToDoListForm()
        {
            InitializeComponent();
            taskTypeComboBox.Items.AddRange(new string[] { "Personal Tasks", "School Tasks", "Work Tasks", "Other Tasks" });
        }
        private DateTimePicker DueDateTimePicker;
        private ComboBox TaskTypeComboBox;

        // Add data source to data grid view or to do list view
        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            TaskTypeComboBox = taskTypeComboBox;

            // Create the columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");
            todoList.Columns.Add("Task Type");
            todoList.Columns.Add("Due Date", typeof(DateTime));

            toDoListView.DataSource = todoList;

            // Load data from the JSON file if it exists
            LoadDataFromJson();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Unable to Delete");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Task Type"] = TaskTypeComboBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Due Date"] = dueDateTimePicker.Value;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text, TaskTypeComboBox.Text, dueDateTimePicker.Value);
            }

            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;

            // Save the data after saving
            SaveDataToJson();
        }

        // Method to save data to JSON
        private void SaveDataToJson()
        {
            List<ToDoItem> items = new List<ToDoItem>();

            // Convert the rows from DataTable to ToDoItem objects
            foreach (DataRow row in todoList.Rows)
            {
                items.Add(new ToDoItem
                {
                    Title = row["Title"].ToString(),
                    Description = row["Description"].ToString(),
                    TaskType = row["Task Type"].ToString(),
                    DueDate = Convert.ToDateTime(row["Due Date"])
                });
            }

            // Serialize the list of ToDoItem objects into JSON
            string json = JsonSerializer.Serialize(items);

            // Define the file path
            string filePath = Path.Combine(Application.StartupPath, "todoList.json");

            // Write the JSON to a file
            File.WriteAllText(filePath, json);

            MessageBox.Show("Data saved successfully.");
        }

        // Method to load data from JSON
        private void LoadDataFromJson()
        {
            string filePath = Path.Combine(Application.StartupPath, "todoList.json");

            if (File.Exists(filePath))
            {
                // Read the JSON string from the file
                string json = File.ReadAllText(filePath);

                // Deserialize the JSON string into a list of ToDoItem objects
                List<ToDoItem> items = JsonSerializer.Deserialize<List<ToDoItem>>(json);

                // Clear the current data in the DataTable
                todoList.Clear();

                // Add each item to the DataTable
                foreach (var item in items)
                {
                    todoList.Rows.Add(item.Title, item.Description, item.TaskType, item.DueDate);
                }

                MessageBox.Show("Welcome to ToDoList App!.\n\nMade by Amazing Cabiles, Karylle Banaag, Ivory Deriquito, Miyuki Oshiro, Zyrhus Brinas, Clyde Reyes");
            }
            else
            {
                MessageBox.Show("No saved data found.");
            }
        }

        // Method to handle form closing and save the data
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveDataToJson();  // Save data when the form is closing
            base.OnFormClosing(e);
        }

        private void newButton_MouseHover(object sender, EventArgs e)
        {
            newButton.BackColor = Color.Black;
        }

        private void newButton_MouseLeave(object sender, EventArgs e)
        {
            newButton.ResetBackColor();
            newButton.BackColor = SystemColors.Highlight;
        }

        private void editButton_MouseHover(object sender, EventArgs e)
        {
            editButton.BackColor = Color.Black;
        }

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            editButton.ResetBackColor();
            editButton.BackColor = SystemColors.Highlight;
        }

        private void deleteButton_MouseHover(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.Black;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.ResetBackColor();
            deleteButton.BackColor = SystemColors.Highlight;
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.Black;
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.ResetBackColor();
            saveButton.BackColor = SystemColors.Highlight;
        }
    }
}
