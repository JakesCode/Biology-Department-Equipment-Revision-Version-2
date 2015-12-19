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

        private void submit2_Click(object sender, EventArgs e)
        {
            string requestName = name.Text;
            string requestTags = tags.Text;

            /* Make the tags into something usable */
            Array sortedTags = requestTags.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            string path = @"history.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("BEGINNAME\n");
                sw.WriteLine(requestName);
                sw.WriteLine("ENDNAME\n");
                sw.WriteLine("BEGINTAGS\n");
                foreach (string line in sortedTags)
                {
                    sw.WriteLine(line);
                }
                sw.WriteLine("ENDTAGS\n");
            }

            MessageBox.Show("Saved the request.");
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
    }
}
