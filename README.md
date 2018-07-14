# Word Counter with MVC

#### Epicodus C#: Independent Code Review #2 07/06/2018

#### By Matt Smith

## Description

A program that checks how frequently a word appears in a given string. The program will check for instances of only the complete word and return a count of how many instances of that complete word occur within a subsequent inputted string.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program stores the inputted key word and an inputted string to be compared**|  "bang" "bang" |  |
| **Program converts both key and comparative strings to lower to avoid case sensitivity**|  "BANG" "bang" | "**bang**" == "**bang**" |
| **Program recognizes punctuation and does not match**|  "were" "we're" | "**were**" =//= "**we're**" |
| **Program disregards and does not tally words that contain the keyword addended or otherwise different from inputted form of keyword**| "bang" "she bangs" | keyword (**bang**) =//= (**bangs**) |
| **Program continues to the end of the string after encountering an initial instance of the key word and records all separate subsequent instances**| "chitty chitty bang bang" | keyword "**bang**" = "**bang**, **bang**" |
| **When program reaches end of character array, it returns the number of keyword instances as an integer**| "chitty chitty bang bang" | Result: 2 |

## Known Bugs

1. Model is not being called properly in the controller this resulting in a non-tally of occurrences.  Default value of zero renders
1. The C# model program presently does not filter out non-alphabetic characters.  The filter allows for special characters to pass through given that they are adjacent to alphabetic characters.  Thus, "b@ng" would pass through whereas "#$%" would not.  Amusingly enough, in the program's present state, "b@ng" would throw a match if the corresponding compare sentence contained "b@ng"
1. as of right now, one can enter multiple words into the keyword field which will not be broken up.

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at https://github.com/MattSmithereens/wordcount-mvc
1. Open WordCount.Solution.sln in Microsoft Visual Studio and click the play button on the top left.  Alternately, use BASH to navigate into the directory and type `dotnet restore`
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

* Github Repository: https://github.com/MattSmithereens/wordcount-mvc

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Matt Smith**
