using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounting
{
    public class Logic
    {
        public string Text { get; set; }
        public char[] ListSeparator = new char[5];
        public string Separator { get; set; }

        public Dictionary<string,int> CountWord()
        {
            Dictionary<string, int> countedWord = new Dictionary<string, int>();


            var ret = Text.Split(ListSeparator);
            for (int i = 0; i < ret.Length; i++)
            {
                if (countedWord.ContainsKey(ret[i]))
                {
                    //int value = countedWord[i];
                    //countedWord[ret[i]] = value + 1;
                    countedWord[ret[i]] += 1; 
                }
                else
                {
                    countedWord.Add(ret[i], 1);   
                }
            }


            return countedWord;
        }

        public void FillSeparator()
        {
            var ret = Separator.Split('*');
            for (int i = 0; i < ret.Length; i++)
            {
                ListSeparator[i] = Convert.ToChar(ret[i]);
            }
        }
    }
}
