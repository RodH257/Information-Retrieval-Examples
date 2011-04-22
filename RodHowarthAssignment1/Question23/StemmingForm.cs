using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RodHowarthAssignment1.Properties;
using RodsExtensions;

namespace RodHowarthAssignment1.Question23
{
    public partial class StemmingForm : Form
    {
        public StemmingForm()
        {
            InitializeComponent();
        }

        private IDictionary<string, int> _englishStemmedCounts = new Dictionary<string, int>();
        private IDictionary<string, int> _frenchStemmedCounts = new Dictionary<string, int>();
        private const int TOP_LIMIT = 20;

        /// <summary>
        /// Does a stemming of the text in english, with step by step output.
        /// </summary>
        private void btnEnglishStem_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            this.txtOutput.Text = "";
            this.txtFinalText.Text = "";
            
            foreach (string term in input.Split(' '))
            {
                if (string.IsNullOrEmpty(term))
                    continue;

                //check that its actually goign to do anything 
                PorterStemmer preStemmer = new PorterStemmer();
                string stemmedTerm = preStemmer.stemTerm(term);


                //save the stemmed term to the stemmed counts
                // do this before you skip it if its already done
                if (_englishStemmedCounts.ContainsKey(stemmedTerm))
                {
                    _englishStemmedCounts[stemmedTerm]++;
                }
                else
                {
                    _englishStemmedCounts.Add(stemmedTerm, 1);
                }


                txtFinalText.Text += stemmedTerm + " ";
                if (term.Equals(stemmedTerm))
                    continue;


                //expand out the steps in full
                PorterStemmer stemmer = new PorterStemmer();
                stemmer.setTerm(term);
                stemmer.PreStem();
                // txtOutput.Text += term + @" -> " + stemmer.stemTerm(term) + Environment.NewLine;
                stemmer.Step1();
                txtOutput.Text += term + " Step 1 " + stemmer.getCurentstate() + Environment.NewLine;
                stemmer.Step2();
                txtOutput.Text += term + " Step 2 " + stemmer.getCurentstate() + Environment.NewLine;
                stemmer.Step3();
                txtOutput.Text += term + " Step 3 " + stemmer.getCurentstate() + Environment.NewLine;
                stemmer.Step4();
                txtOutput.Text += term + " Step 4 " + stemmer.getCurentstate() + Environment.NewLine;
                stemmer.Step5();
                txtOutput.Text += term + " Step 5 " + stemmer.getCurentstate() + Environment.NewLine;
                stemmer.Step6();
                txtOutput.Text += term + " Step 6 " + stemmer.getCurentstate() + Environment.NewLine;
                txtOutput.Text += Environment.NewLine;
                stemmer.PostStem();

         

                txtOutput.Text += "Final Stem: " + stemmer.getTerm() + Environment.NewLine + Environment.NewLine;

               
            }
        }


        /// <summary>
        /// Does a french stemming
        /// </summary>
        private void btnFrenchStem_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = "";
            this.txtFinalText.Text = "";
            string input = txtInput.Text;
            foreach (string term in input.Split(' '))
            {
                if (string.IsNullOrEmpty(term))
                    continue;

                FrenchStemmer stemmer = new FrenchStemmer();
                string stemmedTerm = stemmer.stemTerm(term);

                if (stemmedTerm != term)
                    txtOutput.Text += term + @" -> " + stemmedTerm + Environment.NewLine;

                //save the stemmed term to the stemmed counts
                if (_frenchStemmedCounts.ContainsKey(stemmedTerm))
                {
                    _frenchStemmedCounts[stemmedTerm]++;
                } else
                {
                    _frenchStemmedCounts.Add(stemmedTerm, 1);
                }

                txtFinalText.Text += stemmedTerm + " ";
            }
        }


        /// <summary>
        /// Detects the language by finding the  top french words, and top english 
        /// PRECONDITION: french stem and english stem must have been run at least once
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetectLanguage_Click(object sender, EventArgs e)
        {
            //get the most popular french words
            IEnumerable<string> topFrench = GetMostPopularWords(_frenchStemmedCounts);
            //get the most popular english words
            IEnumerable<string> topEnglish = GetMostPopularWords(_englishStemmedCounts);

            int frenchCounter = 0;
            int englishCounter = 0;

            FrenchStemmer frenchStemmer = new FrenchStemmer();
            PorterStemmer englishStemmer = new PorterStemmer();

            //find the top french in text
            string input = this.txtInput.Text;
            foreach (string term in input.Split(' '))
            {
                string frenchStem = frenchStemmer.stemTerm(term);
                string englishStem = englishStemmer.stemTerm(term);

                if (string.IsNullOrEmpty(term))
                    continue;
                foreach (string frenchTerm in topFrench)
                {
                   // if (frenchTerm.IgnoringCaseEquals(term))
                    if (frenchTerm.IgnoringCaseEquals(frenchStem))
                        frenchCounter++;
                }

                foreach (string englishTerm in topEnglish)
                {
                   // if (englishTerm.IgnoringCaseEquals(term))
                    if (englishTerm.IgnoringCaseEquals(englishStem))
                        englishCounter++;
                }

            }

            if (frenchCounter > englishCounter)
                MessageBox.Show("French");
            else if (englishCounter > frenchCounter)
                MessageBox.Show("English");
            else
                MessageBox.Show("Not sure, have you run a stem on each language to train it?");

        }


        private IEnumerable<string> GetMostPopularWords(IDictionary<string, int> counts)
        {

            var sortedDict = (from entry in counts 
                              orderby entry.Value descending 
                              select entry).ToList();

            for (int i = 0; i <TOP_LIMIT && i < sortedDict.Count ; i++)
            {
                yield return sortedDict[i].Key;
            }
        }

        private void btnEnglishSample_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = Resources.EnglishSampleText;
        }

        private void btnFrenchSample_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = Resources.FrenchSampleText;
        }

        ////Detect Language
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int frenchCount = 0;
        //    int englishCount = 0;
        //     string input = txtInput.Text;
        //     foreach (string term in input.Split(' '))
        //     {
        //         if (string.IsNullOrEmpty(term))
        //             continue;

        //         PorterStemmer.FrenchStemmer frenchStemmer = new PorterStemmer.FrenchStemmer();
        //         frenchStemmer.setTerm(term);
        //         frenchStemmer.PreStem();
        //         frenchStemmer.Step1();
        //         string frenchTerm = frenchStemmer.getCurentstate();
        //         if (!frenchTerm.Equals(term))
        //             frenchCount++;

        //         PorterStemmer.PorterStemmer englishStemmer = new PorterStemmer.PorterStemmer();
        //         englishStemmer.setTerm(term);
        //         englishStemmer.PreStem();
        //         englishStemmer.Step1();
        //         string englishTerm = englishStemmer.getCurentstate();
        //         if (!englishTerm.Equals(term))
        //             englishCount++;


        //     }

        //     if (frenchCount > englishCount)
        //         MessageBox.Show("French");
        //     else
        //         MessageBox.Show("English");

        //}



        
    }
}
