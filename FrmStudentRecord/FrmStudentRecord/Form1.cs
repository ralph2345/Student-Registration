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
    public partial class StudentRecord : Form
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    listBoxShowText.Items.Add(_getText);
                }
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecord = new FrmStudentRecord();
            studentRecord.ShowDialog();
            Close();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Records Successfully Uploaded.");
            listBoxShowText.Items.Clear();
        }
    }
}
