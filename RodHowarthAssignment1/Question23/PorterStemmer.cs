using System;
using System.Runtime.InteropServices;

namespace RodHowarthAssignment1.Question23
{

    /**
      * Stemmer, implementing the Porter Stemming Algorithm
      *
      * The Stemmer class transforms a word into its root form.  The input
      * word can be provided a character at time (by calling add()), or at once
      * by calling one of the various stem(something) methods.
     * 
     * Taken from http://tartarus.org/~martin/PorterStemmer/ 
      */

    public interface StemmerInterface
    {
        string stemTerm(string s);
    }


    [ClassInterface(ClassInterfaceType.None)]
    public class PorterStemmer : StemmerInterface
    {
        private char[] _charBuffer;
        private int _startOffset,     /* offset into b */
            _endOffset, /* offset to end of stemmed word */
            _stemEndIndex, _slidingEndIndex;
        private static int INC = 200;
        /* unit of size whereby b is increased */

        #region Public Interface
        public PorterStemmer()
        {
            _charBuffer = new char[INC];
            _startOffset = 0;
            _endOffset = 0;
        }


        /// <summary>
        /// Gets the stem of the term.
        /// </summary>
        public string stemTerm(string s)
        {
            setTerm(s);
            Stem();
            return getTerm();
        }


        /// <summary>
        /// Sets the term up, intializes the buffer and start offset
        /// </summary>
        public void setTerm(string s)
        {
            _startOffset = s.Length;
            char[] new_b = new char[_startOffset];
            for (int c = 0; c < _startOffset; c++)
                new_b[c] = s[c];

            _charBuffer = new_b;
        }

        /// <summary>
        /// Gets the term in its current state, when stemmed, it will be the stem of the term.
        /// </summary>
        public string getTerm()
        {
            return new String(_charBuffer, 0, _endOffset);
        }

        public string getCurentstate()
        {

            return GetTextUpTo(_slidingEndIndex);
        }


        private string GetTextUpTo(int finish)
        {
            int start = 0;
            string text = string.Empty;
            for (int i = start; i <= finish; i++)
            {
                text += _charBuffer[i];
            }
            return text;
        }



        /**
         * After a word has been stemmed, it can be retrieved by toString(),
         * or a reference to the internal buffer can be retrieved by getResultBuffer
         * and getResultLength (which is generally more efficient.)
         */
        public override string ToString()
        {
            return new String(_charBuffer, 0, _endOffset);
        }

        /**
         * Returns the length of the word resulting from the stemming process.
         */
        public int getResultLength()
        {
            return _endOffset;
        }

        /**
         * Returns a reference to a character buffer containing the results of
         * the stemming process.  You also need to consult getResultLength()
         * to determine the length of the result.
         */
        public char[] getResultBuffer()
        {
            return _charBuffer;
        }

        #endregion


        /// <summary>
        /// Checks for a consonant at character position 
        /// </summary>
        /// <returns>true iff there is a consonant at the certain character position</returns>
        private bool IsConsonant(int position)
        {
            switch (_charBuffer[position])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': return false;
                case 'y': return (position == 0) ? true : !IsConsonant(position - 1);
                default: return true;
            }
        }

        /* m() measures the number of consonant sequences between 0 and j. if c is
           a consonant sequence and v a vowel sequence, and <..> indicates arbitrary
           presence,

              <c><v>       gives 0
              <c>vc<v>     gives 1
              <c>vcvc<v>   gives 2
              <c>vcvcvc<v> gives 3
              ....
        */
        /// <summary>
        /// Measures the number of consonent sequences between the start the end of the stem
        /// </summary>
        private int GetConsSeqCount()
        {
            int n = 0;
            int i = 0;
            while (true)
            {
                if (i > _stemEndIndex) return n;
                if (!IsConsonant(i)) break; i++;
            }
            i++;
            while (true)
            {
                while (true)
                {
                    if (i > _stemEndIndex) return n;
                    if (IsConsonant(i)) break;
                    i++;
                }
                i++;
                n++;
                while (true)
                {
                    if (i > _stemEndIndex) return n;
                    if (!IsConsonant(i)) break;
                    i++;
                }
                i++;
            }
        }

        /// <summary>
        /// Checks for a vowel somewhere in the stem
        /// </summary>
        /// <returns></returns>
        private bool IsVowelInStem()
        {
            int i;
            for (i = 0; i <= _stemEndIndex; i++)
                if (!IsConsonant(i))
                    return true;
            return false;
        }

        /// <summary>
        /// Checks for a double consanant at charPosition and position before it 
        /// </summary>
        private bool IsDoubleCons(int charPosition)
        {
            if (charPosition < 1)
                return false;
            if (_charBuffer[charPosition] != _charBuffer[charPosition - 1])
                return false;
            return IsConsonant(charPosition);
        }
        
        /* cvc(i) is true <=> i-2,i-1,i has the form consonant - vowel - consonant
           and also if the second c is not w,x or y. this is used when trying to
           restore an e at the end of a short word. e.g.

              cav(e), lov(e), hop(e), crim(e), but
              snow, box, tray.

        */
        /// <summary>
        /// Checks charPosition and previous 2 spots for a Consonant - Vowel - Consonant sequence
        /// </summary>
        private bool IsCVC(int charPosition)
        {
            if (charPosition < 2 || !IsConsonant(charPosition) || IsConsonant(charPosition - 1) || !IsConsonant(charPosition - 2))
                return false;
            int ch = _charBuffer[charPosition];
            if (ch == 'w' || ch == 'x' || ch == 'y')
                return false;
            return true;
        }


        /// <summary>
        /// Checks if it ends with string
        /// Sets the end of the stem to be 
        /// </summary>
        private bool EndsWith(String s)
        {
            int l = s.Length;
            int o = _slidingEndIndex - l + 1;
            if (o < 0)
                return false;
            char[] sc = s.ToCharArray();
            for (int i = 0; i < l; i++)
                if (_charBuffer[o + i] != sc[i])
                    return false;
            _stemEndIndex = _slidingEndIndex - l;
            return true;
        }


        /// <summary>
        /// Sets the end of the stem. ReAdjusts the slidingEndIndex to account for new stem
        /// </summary>
        private void ChangeEndOfStem(String postStem)
        {
            int l = postStem.Length;
            int o = _stemEndIndex + 1;
            char[] sc = postStem.ToCharArray();
            for (int i = 0; i < l; i++)
                _charBuffer[o + i] = sc[i];
            _slidingEndIndex = _stemEndIndex + l;
        }

        /// <summary>
        /// Sets the post stem text to be 
        /// </summary>
        private void ChangeStemEndIfNoCons(String s)
        {
            if (GetConsSeqCount() > 0)
                ChangeEndOfStem(s);
        }

        #region Stemming Steps 

        /// <summary>
        /// Does the actual stemming. Result can be retrieved through ToString
        /// </summary>
        public void Stem()
        {
            _slidingEndIndex = _startOffset - 1;
            if (_slidingEndIndex > 1)
            {
                Step1();
                Step2();
                Step3();
                Step4();
                Step5();
                Step6();
            }
            _endOffset = _slidingEndIndex + 1;
            _startOffset = 0;
        }
        public void PreStem()
        {
            _slidingEndIndex = _startOffset - 1;
        }
        public void PostStem()
        {
            _endOffset = _slidingEndIndex + 1;
            _startOffset = 0;
        }
        /* step1() gets rid of plurals and -ed or -ing. e.g.
               caresses  ->  caress
               ponies    ->  poni
               ties      ->  ti
               caress    ->  caress
               cats      ->  cat

               feed      ->  feed
               agreed    ->  agree
               disabled  ->  disable

               matting   ->  mat
               mating    ->  mate
               meeting   ->  meet
               milling   ->  mill
               messing   ->  mess

               meetings  ->  meet

        */
        public void Step1()
        {
            if (_charBuffer[_slidingEndIndex] == 's')
            {
                if (EndsWith("sses"))
                    _slidingEndIndex -= 2;
                else if (EndsWith("ies"))
                    ChangeEndOfStem("i");
                else if (_charBuffer[_slidingEndIndex - 1] != 's')
                    _slidingEndIndex--;
            }
            if (EndsWith("eed"))
            {
                if (GetConsSeqCount() > 0)
                    _slidingEndIndex--;
            }
            else if ((EndsWith("ed") || EndsWith("ing")) && IsVowelInStem())
            {
                _slidingEndIndex = _stemEndIndex;
                if (EndsWith("at"))
                    ChangeEndOfStem("ate");
                else if (EndsWith("bl"))
                    ChangeEndOfStem("ble");
                else if (EndsWith("iz"))
                    ChangeEndOfStem("ize");
                else if (IsDoubleCons(_slidingEndIndex))
                {
                    _slidingEndIndex--;
                    int ch = _charBuffer[_slidingEndIndex];
                    if (ch == 'l' || ch == 's' || ch == 'z')
                        _slidingEndIndex++;
                }
                else if (GetConsSeqCount() == 1 && IsCVC(_slidingEndIndex)) ChangeEndOfStem("e");
            }

        }

   
        /* step2() turns terminal y to i when there is another vowel in the stem. */
        public void Step2()
        {
            if (EndsWith("y") && IsVowelInStem())
                _charBuffer[_slidingEndIndex] = 'i';
        }

        /* step3() maps double suffices to single ones. so -ization ( = -ize plus
           -ation) maps to -ize etc. note that the string before the suffix must give
           GetConsSeqCount() > 0. */
        public void Step3()
        {
            if (_slidingEndIndex == 0)
                return;

            switch (_charBuffer[_slidingEndIndex - 1])
            {
                case 'a':
                    if (EndsWith("ational")) { ChangeStemEndIfNoCons("ate"); break; }
                    if (EndsWith("tional")) { ChangeStemEndIfNoCons("tion"); break; }
                    break;
                case 'c':
                    if (EndsWith("enci")) { ChangeStemEndIfNoCons("ence"); break; }
                    if (EndsWith("anci")) { ChangeStemEndIfNoCons("ance"); break; }
                    break;
                case 'e':
                    if (EndsWith("izer")) { ChangeStemEndIfNoCons("ize"); break; }
                    break;
                case 'l':
                    if (EndsWith("bli")) { ChangeStemEndIfNoCons("ble"); break; }
                    if (EndsWith("alli")) { ChangeStemEndIfNoCons("al"); break; }
                    if (EndsWith("entli")) { ChangeStemEndIfNoCons("ent"); break; }
                    if (EndsWith("eli")) { ChangeStemEndIfNoCons("e"); break; }
                    if (EndsWith("ousli")) { ChangeStemEndIfNoCons("ous"); break; }
                    break;
                case 'o':
                    if (EndsWith("ization")) { ChangeStemEndIfNoCons("ize"); break; }
                    if (EndsWith("ation")) { ChangeStemEndIfNoCons("ate"); break; }
                    if (EndsWith("ator")) { ChangeStemEndIfNoCons("ate"); break; }
                    break;
                case 's':
                    if (EndsWith("alism")) { ChangeStemEndIfNoCons("al"); break; }
                    if (EndsWith("iveness")) { ChangeStemEndIfNoCons("ive"); break; }
                    if (EndsWith("fulness")) { ChangeStemEndIfNoCons("ful"); break; }
                    if (EndsWith("ousness")) { ChangeStemEndIfNoCons("ous"); break; }
                    break;
                case 't':
                    if (EndsWith("aliti")) { ChangeStemEndIfNoCons("al"); break; }
                    if (EndsWith("iviti")) { ChangeStemEndIfNoCons("ive"); break; }
                    if (EndsWith("biliti")) { ChangeStemEndIfNoCons("ble"); break; }
                    break;
                case 'g':
                    if (EndsWith("logi")) { ChangeStemEndIfNoCons("log"); break; }
                    break;
                default:
                    break;
            }
        }

        /* step4() deals with -ic-, -full, -ness etc. similar strategy to step3. */
        public void Step4()
        {
            switch (_charBuffer[_slidingEndIndex])
            {
                case 'e':
                    if (EndsWith("icate")) { ChangeStemEndIfNoCons("ic"); break; }
                    if (EndsWith("ative")) { ChangeStemEndIfNoCons(""); break; }
                    if (EndsWith("alize")) { ChangeStemEndIfNoCons("al"); break; }
                    break;
                case 'i':
                    if (EndsWith("iciti")) { ChangeStemEndIfNoCons("ic"); break; }
                    break;
                case 'l':
                    if (EndsWith("ical")) { ChangeStemEndIfNoCons("ic"); break; }
                    if (EndsWith("ful")) { ChangeStemEndIfNoCons(""); break; }
                    break;
                case 's':
                    if (EndsWith("ness")) { ChangeStemEndIfNoCons(""); break; }
                    break;
            }
        }

        /* step5() takes off -ant, -ence etc., in context <c>vcvc<v>. */
        public void Step5()
        {
            if (_slidingEndIndex == 0)
                return;

            switch (_charBuffer[_slidingEndIndex - 1])
            {
                case 'a':
                    if (EndsWith("al")) break; return;
                case 'c':
                    if (EndsWith("ance")) break;
                    if (EndsWith("ence")) break; return;
                case 'e':
                    if (EndsWith("er")) break; return;
                case 'i':
                    if (EndsWith("ic")) break; return;
                case 'l':
                    if (EndsWith("able")) break;
                    if (EndsWith("ible")) break; return;
                case 'n':
                    if (EndsWith("ant")) break;
                    if (EndsWith("ement")) break;
                    if (EndsWith("ment")) break;
                    /* element etc. not stripped before the m */
                    if (EndsWith("ent")) break; return;
                case 'o':
                    if (EndsWith("ion") && _stemEndIndex >= 0 && (_charBuffer[_stemEndIndex] == 's' || _charBuffer[_stemEndIndex] == 't')) break;
                    /* j >= 0 fixes Bug 2 */
                    if (EndsWith("ou")) break; return;
                /* takes care of -ous */
                case 's':
                    if (EndsWith("ism")) break; return;
                case 't':
                    if (EndsWith("ate")) break;
                    if (EndsWith("iti")) break; return;
                case 'u':
                    if (EndsWith("ous")) break; return;
                case 'v':
                    if (EndsWith("ive")) break; return;
                case 'z':
                    if (EndsWith("ize")) break; return;
                default:
                    return;
            }
            if (GetConsSeqCount() > 1)
                _slidingEndIndex = _stemEndIndex;

        }

        /* step6() removes a final -e if consonant sequence count > 1. */
        public void Step6()
        {
            _stemEndIndex = _slidingEndIndex;

            if (_charBuffer[_slidingEndIndex] == 'e')
            {
                int a = GetConsSeqCount();
                if (a > 1 || a == 1 && !IsCVC(_slidingEndIndex - 1))
                    _slidingEndIndex--;
            }
            if (_charBuffer[_slidingEndIndex] == 'l' && IsDoubleCons(_slidingEndIndex) && GetConsSeqCount() > 1)
                _slidingEndIndex--;


        }

        #endregion 

     

    }
}
