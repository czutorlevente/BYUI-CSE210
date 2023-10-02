using System;
using System.Runtime.CompilerServices;

class Word
{
    private string _text;
    private string _originalText;
    private bool _isHidden;
    private int length_1;

    public Word(string text)
    {
        _text = text;
        _originalText = text;
        length_1  = _text.Length;
        _isHidden = false;
    }

    public void Hide()
    {
        _text = new string('_', length_1);
        _isHidden = true;
    }

    public void Show()
    {
        _text = _originalText;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}