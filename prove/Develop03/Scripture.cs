using System;
using System.Runtime.CompilerServices;
using System.Text;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<string> _wordStrings;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _wordStrings = new List<string>(text.Split(' '));

        foreach (string word in _wordStrings)
        {
            Word word_1 = new Word(word);
            _words.Add(word_1);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> _toHide = new List<int>();
        Random random = new Random();


        for (int i = 0; i < numberToHide; i++)
        {
                int _randomIndex = random.Next(0, _words.Count);
                _toHide.Add(_randomIndex);
        }

        foreach (int index_2 in _toHide)
        {
            _words[index_2].Hide();
        }
    }

    public string GetDisplayText()
    {
        StringBuilder _displayText = new StringBuilder();
        _displayText.Append(_reference.GetDisplayText());
        _displayText.Append(" ");
        foreach (Word word in _words)
        {
            _displayText.Append(word.GetDisplayText());
            _displayText.Append(" ");
        }
        return _displayText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        bool _hidden_1 = true;

        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                _hidden_1 = false;
            }
        }

        return _hidden_1;
    }
}