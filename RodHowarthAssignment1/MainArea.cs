using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RodHowarthAssignment1.Question23;
using RodHowarthAssignment1.Question45;
using RodHowarthAssignment1.Question6;

namespace RodHowarthAssignment1
{
    public partial class MainArea : Form
    {
        public MainArea()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1.	The system must demonstrate false positive and false negative examples using any stemmer (Tutorial 1)
        /// </summary>
        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            //open Word Doc of positive + negative examples
            Process.Start(@"Question1\Question1.docx");
        }

        /// <summary>
        /// 2.	The system must demonstrate the differences between successive layers of the Porter 
        /// stemmer through a couple of examples. (Tutorial 2)
        /// 3.	The system must be able to automatically detect whether a text is in French or English 
        /// and stem it in the detected language. The stemmer for French will only be removing plurals.  (Tutorial 2)
        /// </summary>
        private void btnQuestion23_Click(object sender, EventArgs e)
        {
            //Open stemmer implementation
            StemmingForm stemmingForm = new StemmingForm();
            stemmingForm.Show();
        }

        /// <summary>
        /// 4.	The system must demonstrate the use of the Brill Tagger (Tutorial 3). 
        /// 5.	The system must demonstrate the use of POS tags for information extraction as follows (Tutorial 3):
        ///a.	From the Wikipedia page on Fish (http://en.wikipedia.org/wiki/Fish) extract
        ///all types of fish that are mentioned (eg. freshwater, typical, shell, star, big) using a regular expression and provided POS tags. 
        ///b.	Try your expression on the page for Tree (http://en.wikipedia.org/wiki/Tree). What do you need to change to make it work for tree?
        /// </summary>
        private void btnQuestion45_Click(object sender, EventArgs e)
        {
            //Open the program that processes the POS tagged text with regular expressions and shows outputs
            TaggingForm form = new TaggingForm();
            form.Show();
        }

        /// <summary>
        /// 6.	The system must demonstrate the use of WordNet to expand nouns with their synonyms and their hypernyms (Tutorial 4)
        /// </summary>
        private void btnQuestion6_Click(object sender, EventArgs e)
        {
            //Open wordnet program
            WordnetForm form = new WordnetForm();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
