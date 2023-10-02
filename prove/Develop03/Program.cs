using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> _scriptureQuotes = new List<string>
        {
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.",
            "And because my words shall hiss forth—many of the Gentiles shall say: A Bible! A Bible! We have got a Bible, and there cannot be any more Bible. But thus saith the Lord God: O fools, they shall have a Bible; and it shall proceed forth from the Jews, mine ancient covenant people. And what thank they the Jews for the Bible which they receive from them? Yea, what do the Gentiles mean? Do they remember the travails, and the labors, and the pains of the Jews, and their diligence unto me, in bringing forth salvation unto the Gentiles?"
        };

        List<Reference> _quoteReferences = new List<Reference>
        {
            new Reference("1 Nephi", 3, 7),
            new Reference("2 Nephi", 29, 3, 4)
        };
        Random random = new Random();
        int _scriptureNumber = random.Next(0, _scriptureQuotes.Count);
        string _quote = _scriptureQuotes[_scriptureNumber];
        Scripture _theScripture = new Scripture(_quoteReferences[_scriptureNumber], _quote);


        Console.WriteLine(_theScripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string _userInput = Console.ReadLine();
        bool continue_1 = true;
        if (_userInput == "quit")
        {
            continue_1 = false;
        }

        do
        {
            _theScripture.HideRandomWords(4);
            if (_theScripture.IsCompletelyHidden() == true)
            {
                continue_1 = false;
            }
            Console.Clear();
            Console.WriteLine(_theScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            _userInput = Console.ReadLine();
        } while (continue_1 == true);


    }
}