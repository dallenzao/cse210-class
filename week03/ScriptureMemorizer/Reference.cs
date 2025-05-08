using System.Data;
using System.IO.Compression;

public class Reference{
    private List<Scripture> _verses = new List<Scripture>();
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    //For serialization to a file, below are gets and sets for that purpose
    public List<Scripture> Verses{
        get => _verses;
        set => _verses = value;
    }
    public string Book{
        get => _book;
        set => _book = value;
    }
    public int Chapter{
        get => _chapter;
        set => _chapter = value;
    }
    public int FirstVerse{
        get => _firstVerse;
        set => _firstVerse = value;
    }
    public int LastVerse{
        get => _lastVerse;
        set => _lastVerse = value;
    }

    public Reference(){} // Blank constructor for serialization

    public Reference(List<Scripture> verseList, string book, int chapter){
        _verses = verseList;
        _book = book;
        _chapter = chapter;
        _firstVerse = _verses[0].GetVerse();
        _lastVerse = _verses[0].GetVerse();
        foreach (Scripture verse in _verses){
            if (verse.GetVerse() > _lastVerse){
                _lastVerse = verse.GetVerse();
            }
            else if (verse.GetVerse() < _firstVerse){
                _firstVerse = verse.GetVerse();
            }
        }
    }

    //Gets i used to return the book and chapter nums
    public string GetBook(){ return _book;}
    public int GetChapter(){ return _chapter;}

    public string GetReferenceName(){
        if (_lastVerse == _firstVerse){
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        else{
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        } 
    }

    public void GetDisplayText(){
        string toReturn = "";
        GetReferenceName();
        foreach (Scripture verse in _verses){
            string fullVerseString = verse.GetVerse() + " " + verse.GetDisplayText()+ "\n";
            toReturn = toReturn + fullVerseString;
        }
        Console.WriteLine(toReturn);
    }

    public void RandomizeHiddenWords(int numWords){ //Randomizes the number of hidden words in the verses. 
        foreach (Scripture verse in _verses){
            verse.HideRandomWords(numWords);
        }
    }

    public void ResetHiddenWords(){
        foreach (Scripture verse in _verses){
            verse.ResetHiddenWords();
        }
    }
}