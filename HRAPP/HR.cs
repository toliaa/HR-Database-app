using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection; // Connection to the SQLite database
        private SQLiteDataAdapter adapter; // Adapter to manage the data exchange between database and DataSet
        private DataSet dataSet; // DataSet to hold the data fetched from the database

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();

            // Setting placeholder text for textboxes
            SetPlaceholderText(txtFirstName, "First Name");
            SetPlaceholderText(txtLastName, "Last Name");
            SetPlaceholderText(txtPosition, "Position");
            SetPlaceholderText(txtDepartmentID, "Department ID");
            SetPlaceholderText(txtSearch, "Search");
            SetPlaceholderText(txtDepartmentIDForReport, "Department ID");
        }

        // Initializes the SQLite database connection and creates the Employees table if it does not exist
        private void InitializeDatabase()
        {
            connection = new SQLiteConnection("Data Source=employees.db;Version=3;");
            connection.Open();

            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Employees (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    Position TEXT NOT NULL,
                    DepartmentID INTEGER NOT NULL,
                    HireDate TEXT NOT NULL
                )";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
        }

        // Event handler for adding a new employee to the database
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, Position, DepartmentID, HireDate) VALUES (@FirstName, @LastName, @Position, @DepartmentID, @HireDate)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            command.Parameters.AddWithValue("@LastName", txtLastName.Text);
            command.Parameters.AddWithValue("@Position", txtPosition.Text);
            command.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text);
            command.Parameters.AddWithValue("@HireDate", dtpHireDate.Value.ToString("yyyy-MM-dd"));
            command.ExecuteNonQuery();
            MessageBox.Show("Employee added successfully.");
        }

        // Event handler for searching employees in the database based on the search criteria
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE FirstName LIKE @Search OR LastName LIKE @Search OR Position LIKE @Search OR DepartmentID LIKE @Search";
            adapter = new SQLiteDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Employees");
            dataGridView1.DataSource = dataSet.Tables["Employees"];
        }

        // Event handler for generating a report based on the department ID
        private void btnReportByDepartment_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE DepartmentID = @DepartmentID";
            adapter = new SQLiteDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@DepartmentID", txtDepartmentIDForReport.Text);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Employees");
            dataGridView1.DataSource = dataSet.Tables["Employees"];
        }

        // Event handler for generating a report based on the hire date
        private void btnReportByHireDate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE HireDate >= @HireDate";
            adapter = new SQLiteDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@HireDate", dtpHireDateForReport.Value.ToString("yyyy-MM-dd"));
            dataSet = new DataSet();
            adapter.Fill(dataSet, "Employees");
            dataGridView1.DataSource = dataSet.Tables["Employees"];
        }

        // Method to set placeholder text in TextBox controls
        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
    }
}
