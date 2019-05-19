using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_APP
{

    public partial class newbook : Form
    {
        //Some regex
        Regex priceregex = new Regex(@"-?\d+(?:\.\d+)?");
        Regex onlynumbers = new Regex(@"^\d+$");

        LibraryWorkEntities db = new LibraryWorkEntities();
        public newbook()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
        }
        //Checking if values are not empty
        private void newbook_MouseHover(object sender, EventArgs e)
        {
            if (BookNametxt.Text.Length == 0 && BookNametxt.Text.Length == 0
                && BookNametxt.Text.Length == 0 && BookNametxt.Text.Length == 0 &&
                BookNametxt.Text.Length == 0)
            {
                ResetBtn.Enabled = false;
            }
            else
            {
                ResetBtn.Enabled = true;
            }
        }
        //Resetter for inputs
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void ClearInputs()
        {
            BookNametxt.Clear();
            Pricetxt.Clear();
            Counttxt.Clear();
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //Firstly Validation
            if (ValidateChildren())
            {
                MessageBox.Show("Succesfully accepted");
            }
        }

        private void newbook_Load(object sender, EventArgs e)
        {
            FillAuthors();
            FillCategories();
        }
        private void FillCategories()
        {
            using (LibraryWorkEntities db = new LibraryWorkEntities())
            {
                Categorytxt.DataSource = db.Categories.Select(a => a.Name).ToList();
            }
        }
        private void FillAuthors()
        {
            using (LibraryWorkEntities db = new LibraryWorkEntities())
            {
                AuthorCmb.DataSource = db.Authors.Select(a => a.Name + " " + a.Surname).ToList();
            }
        }

        private void BookNametxt_Validating(object sender, CancelEventArgs e)
        {
            if(BookNametxt.Text.Length == 0)
            {
                MessageBox.Show("Fill out the name box");
                e.Cancel = true;
            }
        }

        private void Pricetxt_Validating(object sender, CancelEventArgs e)
        {
            if (Pricetxt.Text.Length == 0)
            {
                MessageBox.Show("Fill out the price box");
                e.Cancel = true;
            }
            else if (!priceregex.IsMatch(Pricetxt.Text))
            {
                MessageBox.Show("Price tag must be xx.xx");
                e.Cancel = true;
            }
        }

        private void Counttxt_Validating(object sender, CancelEventArgs e)
        {
            if(Counttxt.Text.Length == 0)
            {
                MessageBox.Show("Fill out count");
                e.Cancel = true;
            }
            else if (!onlynumbers.IsMatch(Counttxt.Text))
            {
                MessageBox.Show("Count should contain only numbers ");
                e.Cancel = true;
            }
        }

        private void Categorytxt_Validating(object sender, CancelEventArgs e)
        {
            if (!Categorytxt.Text.Contains(Categorytxt.DataSource.ToString()))
            {
                MessageBox.Show("Please choose category from list");
                e.Cancel = true;
            }
        }
    }
}
