using System;

class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;



    public string GetDisplayText()
    {
        return $"{_book} {_chapter}: {_verse}{_endVerse}";
    }

}