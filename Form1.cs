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

            searchButton.Click += searchButton_Click;
            sortDateButton.Click += sortDateButton_Click;
            sortTypeButton.Click += sortTypeButton_Click;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // Save the current row index to re-select it after clearing the textboxes
            int selectedRowIndex = toDoListView.CurrentCell.RowIndex;

            // Clear the textboxes for new task entry
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            TaskTypeComboBox.SelectedIndex = -1; // Optionally reset the combo box
            dueDateTimePicker.Value = DateTime.Now; // Reset due date to current date or default

            // Re-select the previously selected row to keep the highlight
            if (selectedRowIndex >= 0 && selectedRowIndex < todoList.Rows.Count)
            {
                toDoListView.CurrentCell = toDoListView.Rows[selectedRowIndex].Cells[0]; // Re-focus the row
            }
        }

        // Application of Arrays
        private int currentEditIndex = -1; // This will store the index of the task being edited

        private void editButton_Click(object sender, EventArgs e)
        {
            // Set the isEditing flag to true
            isEditing = true;

            // Get the index of the selected row
            currentEditIndex = toDoListView.CurrentCell.RowIndex;

            // Set the textboxes with the current task data
            titleTextBox.Text = todoList.Rows[currentEditIndex]["Title"].ToString();
            descriptionTextBox.Text = todoList.Rows[currentEditIndex]["Description"].ToString();
            TaskTypeComboBox.Text = todoList.Rows[currentEditIndex]["Task Type"].ToString();
            dueDateTimePicker.Value = Convert.ToDateTime(todoList.Rows[currentEditIndex]["Due Date"]);

        }

        // Application of Stack
        private Stack<DataRow> deletedItems = new Stack<DataRow>();
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Delete To Do", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataRow rowToDelete = todoList.Rows[toDoListView.CurrentCell.RowIndex];
                    deletedItems.Push(rowToDelete); // Push deleted row onto the stack
                    rowToDelete.Delete(); // Delete the row from DataTable
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: Unable to Delete");
                }
            }
        }

        // Application of Queue
        private Queue<ToDoItem> taskQueue = new Queue<ToDoItem>();

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Create a new task object
            var newTask = new ToDoItem
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                TaskType = TaskTypeComboBox.Text,
                DueDate = dueDateTimePicker.Value
            };

            if (isEditing && currentEditIndex != -1)
            {
                // If we're editing an existing task, update that row in the DataTable
                DataRow editedRow = todoList.Rows[currentEditIndex];
                editedRow["Title"] = newTask.Title;
                editedRow["Description"] = newTask.Description;
                editedRow["Task Type"] = newTask.TaskType;
                editedRow["Due Date"] = newTask.DueDate;
                // Clear the editing state
                isEditing = false;
                currentEditIndex = -1; // Reset the edit index
            }
            else
            {
                // If we're not editing, add a new task to the DataTable
                todoList.Rows.Add(newTask.Title, newTask.Description, newTask.TaskType, newTask.DueDate);
            }

            // Save data to JSON after editing or adding
            SaveDataToJson();

            // Clear the input fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.ToLower();

            // Filter rows containing the keyword in any column like title, description and type
            DataView dv = todoList.DefaultView;
            dv.RowFilter = $"Title LIKE '%{keyword}%' OR Description LIKE '%{keyword}%' OR [Task Type] LIKE '%{keyword}%'";
        }

        private void sortTypeButton_Click(object sender, EventArgs e)
        {
            DataView dv = todoList.DefaultView;
            dv.Sort = "[Task Type] ASC"; // Sort by Task Type in alphabetical order
        }

        private void sortDateButton_Click(object sender, EventArgs e)
        {
            DataView dv = todoList.DefaultView;
            dv.Sort = "Due Date ASC"; // Sort by Due Date in ascending or decending order
        }

        private void searchButton_MouseHover(object sender, EventArgs e)
        {
            searchButton.BackColor = Color.Black;
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.ResetBackColor();
            searchButton.BackColor = SystemColors.Highlight;
        }

        private void sortTypeButton_MouseHover(object sender, EventArgs e)
        {
            sortTypeButton.BackColor = Color.Black;
        }

        private void sortTypeButton_MouseLeave(object sender, EventArgs e)
        {
            sortTypeButton.ResetBackColor();
            sortTypeButton.BackColor = SystemColors.Highlight;
        }

        private void sortDateButton_MouseHover(object sender, EventArgs e)
        {
            sortDateButton.BackColor = Color.Black;
        }

        private void sortDateButton_MouseLeave(object sender, EventArgs e)
        {
            sortDateButton.ResetBackColor();
            sortDateButton.BackColor = SystemColors.Highlight;
        }
    }
}
