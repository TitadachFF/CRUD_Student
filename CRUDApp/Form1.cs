using MySql.Data.MySqlClient;
using System.Data;

namespace CRUDApp
{
    public partial class Form1 : Form
    {
        private ConDB conDB;
        private DataGridView dataGridView = new DataGridView();
        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
        {
            Name = "EditButtonColumn",
            Text = "Edit",
            UseColumnTextForButtonValue = true
        };

        DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
        {
            Name = "DeleteButtonColumn",
            Text = "Delete",
            UseColumnTextForButtonValue = true
        };

        public Form1()
        {
            InitializeComponent();
            conDB = new ConDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM student"; // Replace 'your_table_name' with the name of your table
            System.Data.DataSet data = conDB.con_db(sql);

            if (data.Tables.Count > 0)
            {
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Columns.Add(editButtonColumn);
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            else
            {
                MessageBox.Show("No data found.");
            }

            // Add the DataGridView to your form
            this.Controls.Add(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                int studentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["stu_id"].Value);

                string sql = "DELETE FROM student WHERE stu_id = " + studentID;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bool success = conDB.con_update(sql);

                    if (success)
                    {
                        MessageBox.Show("Deleted student successfully.");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the student.");
                    }
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["EditButtonColumn"].Index && e.RowIndex >= 0)
            {
                int studentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["stu_id"].Value);

                EditForm editForm = new EditForm(studentID, conDB);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Handle the save operation's result if needed.
                    // Refresh the DataGridView if the edit was successful.
                    RefreshDataGridView();
                }

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            string sql = "SELECT * FROM student"; // Replace 'your_table_name' with the name of your table
            DataSet data = conDB.con_db(sql);

            if (data.Tables.Count > 0)
            {
                dataGridView1.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
