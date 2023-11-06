using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUDApp
{
    public partial class AddForm : Form
    {
        private ConDB conDB = new ConDB();
        public AddForm()
        {
            InitializeComponent();

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            Int64 studnetId = int.Parse(id.Text);
            string studentName = name.Text;
            string studentTel = tel.Text;
            string studentFb = fb.Text;

            // Construct and execute an INSERT SQL statement to add a new student to the database
            string insertSql = "INSERT INTO student (stu_id , stu_name, stu_tel, stu_fb) VALUES (@id,@name, @tel, @fb)";

            bool success = conDB.con_updateStudent(insertSql, "@id", studnetId, "@name", studentName, "@tel", studentTel, "@fb", studentFb);

            if (success)
            {
                MessageBox.Show("Student added successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close(); // Close the AddForm.
            }
            else
            {
                MessageBox.Show("Failed to add the student.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
