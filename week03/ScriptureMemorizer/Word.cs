using System.Runtime.InteropServices;

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

    public string giveWord(){
        if (_isHidden){
            // If the string is hidden, return dashes of that strings length
            int wordlen = _word.Length;
            return new string('-', wordlen);
        }
        return _word;
    }
    public void setHidden(bool status){
        _isHidden = status;
    }

    public bool getStatus(){
        return _isHidden;
    }
}