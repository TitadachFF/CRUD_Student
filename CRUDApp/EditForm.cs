using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDApp
{
    public partial class EditForm : Form
    {
        private int studentID;
        private ConDB conDB;

        public EditForm(int studnetId, ConDB db)
        {
            InitializeComponent();
            studentID = studnetId;
            conDB = db;

            id.Text = studentID.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string editedName = name.Text;
            string editedTel = tel.Text;
            string editedFb = fb.Text;

            // Construct and execute an UPDATE SQL statement with parameters.
            string updateSql = "UPDATE student SET stu_name = @name, stu_tel = @tel, stu_fb = @fb WHERE stu_id = @id";

            bool success = conDB.con_updateStudent(updateSql, "@name", editedName, "@tel", editedTel, "@fb", editedFb, "@id", studentID);

            if (success)
            {
                // Indicate that the save operation was successful.
                MessageBox.Show("Updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close(); // Close the EditForm.
            }
            else
            {
                MessageBox.Show("Failed to save changes.");
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
