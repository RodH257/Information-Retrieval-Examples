using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using LAIR.ResourceAPIs.WordNet;

namespace RodHowarthAssignment1.Question6
{
    /// <summary>
    /// Wordnet by:
    /// George A. Miller (1995). WordNet: A Lexical Database for English. 
    ///Communications of the ACM Vol. 38, No. 11: 39-41. 
    ///Christiane Fellbaum (1998, ed.) WordNet: An Electronic Lexical Database. Cambridge, MA: MIT Press.
    /// </summary>
    public partial class WordnetForm : Form
    {
        private WordNetEngine _wordNetEngine;
        public WordnetForm()
        {
            InitializeComponent();
            //  string root = Directory.GetDirectoryRoot(".");
            _wordNetEngine = new WordNetEngine(@"WordnetDicts\", true);
        }

        /// <summary>
        /// Reads a stream to a string
        /// </summary>
        private string ReadStream(string fileLocation)
        {
            FileStream stream = File.Open(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string result = reader.ReadToEnd();
            stream.Close();
            return result;
        }

        /// <summary>
        /// Reads both tagged files to a string
        /// </summary>
        /// <returns></returns>
        private string ReadBothFiles()
        {
            return ReadStream(this.txtTreeTagged.Text) + ReadStream(this.txtFishTagged.Text);
        }

        /// <summary>
        /// Extracts the nouns
        /// </summary>
        private HashSet<string> GetNouns(string taggedText)
        {
            HashSet<string> nouns = new HashSet<string>();
            Regex regex = new Regex("[a-zA-Z]*/NNS?");

            foreach (Match match in regex.Matches(taggedText))
            {
                string word = match.Value
                    .Replace(@"/NNS", "")
                    .Replace(@"/NN", "");
                if (word.Normalize().Length > 0)
                    nouns.Add(word);
            }

            return nouns;
        }

        /// <summary>
        /// Extracts the adjectives
        /// </summary>
        private HashSet<string> GetAdjectives(string taggedText)
        {
            HashSet<string> adjs = new HashSet<string>();
            Regex regex = new Regex("[a-zA-Z]*/JJ");

            foreach (Match match in regex.Matches(taggedText))
            {
                //remove JJ, NN, NNS
                string word = match.Value.Replace(@"/JJ", "");

                if (word.Normalize().Length > 0)
                    adjs.Add(word);
            }

            return adjs;
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            this.txtSynonyms.Text = "";
            this.txtHypernyms.Text = "";
            //get the pos tagged text
            string taggedText = ReadBothFiles();

            HashSet<string> nouns = GetNouns(taggedText);
            HashSet<string> adjs = GetAdjectives(taggedText);

            OutputSynonyms(nouns, WordNetEngine.POS.Noun);
            OutputSynonyms(adjs, WordNetEngine.POS.Adjective);
            OutputHypernyms(nouns, WordNetEngine.POS.Noun);
        }


        /// <summary>
        /// Outputs the Hypernyms (words that the original word is a meaning of)
        /// </summary>
        private void OutputHypernyms(IEnumerable<string> words, WordNetEngine.POS pos)
        {
            StringBuilder output = new StringBuilder();
            int limitCounter = 0;
            foreach (string word in words)
            {
                limitCounter++;

                //get the synsets
                var synSets = _wordNetEngine.GetSynSets(word, pos);

                //retrieve hypernymSynsets
                output.Append(word + "[");
                foreach (SynSet directSynset in synSets)
                {
                    var hypernymSynSets =
                       directSynset.GetRelatedSynSets(WordNetEngine.SynSetRelation.Hypernym, false);

                    foreach (SynSet hypernymSynSet in hypernymSynSets)
                    {

                        //have the synset, find all the words in that synset
                        IEnumerable<string> outputList =
                            hypernymSynSet.Words.Where(synonym => synonym != word);

                        if (outputList.Count() > 0)
                        {
                            output.Append("(");

                            int count = 0;
                            foreach (string synonym in outputList)
                            {
                                count++;
                                output.Append(synonym);

                                //add comma not to the last one 
                                if (count != outputList.Count())
                                    output.Append(",");
                            }
                            output.Append(")");
                        }
                    }
                }

                output.Append("]" + Environment.NewLine);

                if (limitCounter > nupdLimit.Value)
                    break;
            }
            this.txtHypernyms.Text += output.ToString();
        }


        /// <summary>
        /// Outputs synonyms of the specified words
        /// </summary>
        private void OutputSynonyms(IEnumerable<string> words, WordNetEngine.POS pos)
        {
            StringBuilder synonymOutput = new StringBuilder();
            int limitCounter = 0;
            foreach (string word in words)
            {
                limitCounter++;

                //Words are synonyms if they share the same Synsets
                //So find synsets and then find the words connected to these synsets. 
                var synSets = _wordNetEngine.GetSynSets(word, pos);


                synonymOutput.Append(word + "[");
                foreach (SynSet synSet in synSets)
                {
                    //have the synset, find all the words in that synset
                    IEnumerable<string> outputList = synSet.Words
                        .Where(synonym => synonym != word);
                    //add to dictionary

                    if (outputList.Count() > 0)
                    {
                        synonymOutput.Append("(");


                        int count = 0;
                        foreach (string synonym in outputList)
                        {
                            count++;
                            synonymOutput.Append(synonym);

                            //add comma not to the last one 
                            if (count != outputList.Count())
                                synonymOutput.Append(",");
                        }
                        synonymOutput.Append(")");
                    }
                }

                synonymOutput.Append("]" + Environment.NewLine);

                if (limitCounter > nupdLimit.Value)
                    break;
            }
            this.txtSynonyms.Text += synonymOutput.ToString();

        }

        private void btnSeeResults_Click(object sender, EventArgs e)
        {
            Process.Start(@"Question6\Query Expansion.docx");
        }
    }
}
