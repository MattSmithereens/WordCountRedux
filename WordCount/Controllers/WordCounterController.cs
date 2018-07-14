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
            Model.SetWords(Request.Form["checkPhrase"]);
            string lowCaseWord = Model.GetWord();
            string compareWords = Model.GetWords();
            string[] compareArray = Model.splitString(compareWords);

            int result = Model.WordOccurs(compareArray, lowCaseWord);
            Model.SetOccurTally(result);
            return View(Model);
        }
    }
}
