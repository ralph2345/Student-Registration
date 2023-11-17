using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmStudentRecord
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void frmRecordBtn_Click(object sender, EventArgs e)
        {
            StudentRecord record = new StudentRecord();
            record.ShowDialog();
        }

        private void frmRegisterBtn_Click(object sender, EventArgs e)
        {
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string studentNo = studentNoTxtBox.Text;
            string fullName = lastNameTextBox.Text + ", " + firstNameTextBox.Text + ", " + miTextBox.Text;
            string program = cbProgram.Text;
            string gender = cbGender.Text;
            string age = ageTextBox.Text;
            string birthday = birthdayPicker.Text;
            string contactNo = contactNoTextBox.Text;

            string[] registeredInfo = { studentNo, fullName, program, gender, age, birthday, contactNo };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter streamwriter = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                foreach (string list in registeredInfo)
                {
                    streamwriter.WriteLine(list);
                }
            }

            Close();
        }
    }
}
