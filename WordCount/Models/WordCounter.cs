using System;

namespace WordCount.Models
{
    public class WordCounter
    {
        private string _keyWord;            //keyword
        private string _words;              //comparative word
        private string[] _wordArray;        //comparative word array
        private int _occurance = 0;         //tallies instances of keyword

        public void SetOccurTally(int score)
        {
            _occurance = score;
        }

        public int GetOccurTally()
        {
            return _occurance;
        }

        public void SetWord(string keyWord)
        {
            if (this.WordLettersOnly(keyWord) && WordNoSpaces(keyWord))  // 
            {
                string LowCaseWord = keyWord.ToLower();
                _keyWord = LowCaseWord;
            }
            else
            {
                _keyWord = String.Empty;
            }
        }

        public string GetWord()
        {
            return _keyWord;
        }

        public bool WordLettersOnly(string keyWord)
        {
            char[] letterArray = keyWord.ToCharArray();
            foreach (char x in letterArray)
            {
                //if(Char.)
                if (Char.IsLetter(x))
                {
                    return true;
                }
            }
            return false;
        }

        public bool WordNoSpaces(string keyWord)
        {
            string[] listArray = keyWord.Split();
            if (listArray.Length == 1)
            {
                return true;
            }
            return false;
        }

        public void SetWords(string words)
        {
            if (this.WordsLettersOnly(words))
            {
                string LowCaseWords = words.ToLower();
                _words = LowCaseWords;
            }
            else
            {
                _words = String.Empty;
            }
        }

        public string GetWords()
        {
            return _words;
        }

        public bool WordsLettersOnly(string words)
        {
            char[] lettersArray = words.ToCharArray();
            foreach (char x in lettersArray)
            {
                if (Char.IsLetter(x))
                {
                    return true;
                }
            }
            return false;
        }

        public void SetArray(string[] cutWords)
        {
            _wordArray = cutWords;
        }

        public string[] GetArray()
        {
            return _wordArray;
        }

        public string[] splitString(string lowCaseWords)
        {
            string[] listArray = lowCaseWords.Split();
            SetArray(listArray);
            return GetArray();
        }


        public int WordOccurs(string[] listArray, string lowCaseWord)
        {
            int i = GetOccurTally();
            foreach (string word in listArray)
            {
                if (word == lowCaseWord)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
