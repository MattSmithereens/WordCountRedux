using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WordCount.Models;

namespace WordCount.Controllers
{
    public class WordCounterController : Controller
    {

        [HttpGet("/form")]
        public ActionResult Form()
        {
            return View();
        }

        // Breaks build

        [HttpPost("/result")]
        public ActionResult Result(string checkWord, string checkPhrase)
        {
            WordCount inputVariable = new



            //WordCounter inputVariable = new WordCounter();
            //inputVariable.SetWord(Request.Query["checkWord"]);
            //inputVariable.SetWords(Request.Query["checkPhrase"]);

            // this is where shit breaks
            //string string1 = inputVariable.GetWord();
            //string string2 = inputVariable.GetWords(words);
            //string[] array = inputVariable.splitstring(string2);
            //inputVariable.SetOccurTally(inputVariable.CheckString(array));
              //}
              //else
              //{
              //    return View("Error");
              //}

          return View();





           // testWordCount.WordOccurs(listArray, lowCaseWord)

          // add call to method for counting words

          //return View(score);

// END OF MY CODE

        //[HttpPost("/inputlist")]
        //public ActionResult InputList()
        //{
        //    Item word = new Item();
        //    word.SetStringOne(Request.Form["word-one"]);
        //    word.SetStringTwo(Request.Form["list-words"]);
        //    string string1 = word.GetStringOne();
        //    string string2 = word.GetStringTwo();
        //    if (word.CorrectInput(string1) == true && word.CorrectInputTwo(string2) == true)
        //    {
        //        string[] array = word.splitWord(string2);
        //        word.SetVarX(word.CheckString(array));
        //    }
        //    else
        //    {
        //        return View("Error");
        //    }

        //    return View(word);
        //}

        }
    }
}
