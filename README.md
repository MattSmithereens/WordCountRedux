M# Word Counter with MVC

#### Epicodus C#: Independent Code Review #2 07/06/2018

#### By Matt Smith

## Description

A program that checks how frequently a word appears in a given string. The program will check for instances of only the complete word and return a count of how many instances of that complete word occur within a subsequent inputted string.


### Specs
| Spec | Input 1 | Input 2 | Output |
| :-------------     | :------- | :-------- | :-----------
| **Program stores the inputted key word and an inputted string to be compared**|  "bang"  | "bang" | |
| **Program converts both key and comparative strings to lower to avoid case sensitivity**|  "BANG" | "bang" | "**bang**" = "**bang**" |
| **Program recognizes punctuation and does not match**|  "were" | "we're" | "**were**" =//= "**we're**" however "**we're**" = "**we're**"|
| **Program does not recognize numbers**|  "4" | "4"| "Please try again"|
| **Program does recognize words that contain numbers**|  "4ever" | "4ever"| "**4ever**" = "**4ever**"|
| **Program does not allow for multiple keywords**|  "bang bang" | "bang bang"| "Please try again"|
| **Program disregards and does not tally words that contain the keyword addended or otherwise different from inputted form of keyword**| "bang" | "she bangs" | (**bang**) =//= (**bangs**) |
| **Program continues to the end of the string after encountering an initial instance of the key word and records all separate subsequent instances**| "bang" | chitty chitty bang bang" | "**bang**" = "**bang**, **bang**" |
| **When program reaches end of character array, it returns the number of keyword instances as an integer**| "bang" |chitty chitty bang bang" | Result: **2** |

## Known Bugs

1. Seeing as the project is already overdue, I completed only a few edge cases.  Program presently does not scrub punctuation, so "this." would match with "this." but not "this"

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at https://github.com/MattSmithereens/WordCountRedux
1. Open WordCount.Solution.sln in Microsoft Visual Studio and click the play button on the top left.  Alternately, use BASH to navigate into the directory and type `dotnet restore` then `dotnet run`
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .NET Core 1.1 SDK
* .NET runtime
* Mono
* MicroSoft Visual Studio
* Atom

## Links

* Github Repository: https://github.com/MattSmithereens/WordCountRedux

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Matt Smith**
