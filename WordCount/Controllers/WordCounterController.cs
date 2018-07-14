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
       

        [HttpPost("/result")]
        public ActionResult Result()
        {
            WordCounter Model = new WordCounter();
            Model.SetWord(Request.Form["checkWord"]);
            Model.SetWord(Request.Form["checkPhrase"]);
            string lowCaseWord = Model.GetWord();                       //take word from form and feed it though getter, run methods
            string compareWords = Model.GetWords();
            string[] compareArray = Model.splitString(compareWords);    //take words from form and run through split method
            int result = Model.WordOccurs(compareArray, lowCaseWord);   //actually run method checking words
            Model.SetOccurTally(result);
            return View(Model);
        }
    }
}
