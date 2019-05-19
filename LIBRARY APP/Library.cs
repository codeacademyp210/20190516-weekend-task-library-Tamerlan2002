using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LIBRARY_APP
{
    public partial class Library : Form
    {

        Readingbook allbooks = new Readingbook();
        public Library()
        {
            InitializeComponent();
        }

        private void createANewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newbook nb = new newbook();
            nb.Show();
            this.Hide();
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allbooks.Show();
            this.Hide();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }
    }
}
