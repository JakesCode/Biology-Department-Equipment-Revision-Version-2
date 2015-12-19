using System;
using System.IO;
using System.Windows.Forms;

namespace BDER
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static class ControlID
        {
            public static string TextData { get; set; }
            public static string TextTags { get; set; }
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            if (name.Text.Contains(" "))
            {
                MessageBox.Show("There are spaces in the request's name. Please remove them and try again.");
            } else
            {
                ControlID.TextData = name.Text;
                ControlID.TextTags = tags.Text;
                this.Dispose();
            }
        }

        private void delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure? This will delete all of your past requests.", "Are you sure?", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string path = @"history.txt";
                System.IO.File.WriteAllText(path, string.Empty);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
