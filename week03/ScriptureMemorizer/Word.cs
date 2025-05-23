using System.Runtime.InteropServices;

//Dallen Harmon
//CSE210

public class Word{
    private bool _isHidden;
    private string _word;

    //For serialization to a file, below are gets and sets for that purpose
    public string Text{
        get => _word;
        set => _word = value;
    }
    public bool IsHidden{
        get => _isHidden;
        set => _isHidden = value;
    }

    //Argumentless Constructor
    public Word(){
        _word = "";
        _isHidden = false;
    }
    public Word(string givenWord){
        _word = givenWord;
        _isHidden = false;
    }
    public Word(string givenWord, bool hiddenStatus){
        _word = givenWord;
        _isHidden = hiddenStatus;
    }

    //Returns the word, unless its hidden. Then return dashes instead
    public string giveWord(){
        if (_isHidden){
            // If the string is hidden, return dashes of that strings length
            int wordlen = _word.Length;
            return new string('-', wordlen);
        }
        return _word;
    }

    //Sets the hidden status
    public void setHidden(bool status){
        _isHidden = status;
    }

    //Returns the hidden status
    public bool getStatus(){
        return _isHidden;
    }
}