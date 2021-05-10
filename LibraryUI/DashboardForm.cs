using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBookForm frm = new AddNewBookForm();
            frm.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooksForm frm = new ViewBooksForm();
            frm.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformationForm frm = new ViewStudentInformationForm();
            frm.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookForm frm = new IssueBookForm();
            frm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBookForm frm = new ReturnBookForm();
            frm.Show();
        }

        private void bookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookHistoryForm frm = new BookHistoryForm();
            frm.Show();
        }
    }
}
