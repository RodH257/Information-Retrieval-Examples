using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RodHowarthAssignment1.Question45
{
    public partial class TaggingForm : Form
    {
        public TaggingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the fish file 
        /// </summary>
        private string GetFishTagged()
        {
            return ReadStream(this.txtFishArticle.Text);
        }

        private string ReadStream(string fileLocation)
        {
            FileStream stream = File.Open(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string result = reader.ReadToEnd();
            stream.Close();
            return result;
        }

        /// <summary>
        /// Reads the tree file
        /// </summary>
        private string GetTreeTagged()
        {
            return ReadStream(this.txtTreeArticle.Text);
        }
        

        /// <summary>
        /// Runs the combined regex
        /// </summary>
        private void btnRunCombined_Click(object sender, EventArgs e)
        {
            //clear text boxes
            this.txtFishResults.Text = "";
            this.txtTreeResults.Text = "";

            string fishTagged = GetFishTagged();
            string treeTagged = GetTreeTagged();

            Regex combinedRegex = new Regex(this.txtCombinedRegex.Text);
            foreach (Match match in combinedRegex.Matches(fishTagged))
            {
                this.txtFishResults.Text += match.Value + Environment.NewLine;
            }

            foreach (Match match in combinedRegex.Matches(treeTagged))
            {
                this.txtTreeResults.Text += match.Value + Environment.NewLine;
            }
        }

        /// <summary>
        /// Runs the fish regex
        /// </summary>
        private void btnRunFish_Click(object sender, EventArgs e)
        {
            this.txtFishResults.Text = "";
            string fishTagged = GetFishTagged();

            Regex regex = new Regex(this.txtFishRegex.Text);
            foreach (Match match in regex.Matches(fishTagged))
            {
                this.txtFishResults.Text += match.Value + Environment.NewLine;
            }

        }

        /// <summary>
        /// Runs the tree regex
        /// </summary>
        private void btnRunTree_Click(object sender, EventArgs e)
        {
            this.txtTreeResults.Text = "";
            string treeTagged = GetTreeTagged();
            Regex regex = new Regex(this.txtTreeRegex.Text);
            foreach (Match match in regex.Matches(treeTagged))
            {
                this.txtTreeResults.Text += match.Value + Environment.NewLine;
            }
        }

        private void lnklblBrillTagger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://cst.dk/online/pos_tagger/uk/index.html");
        }
    }
}
