using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class Scripture{
    private List<Word> _content = new List<Word>();
    private int _verse;

    //For serialization to a file, below are gets and sets for that purpose
    public int VerseNumber
    {
        get => _verse;
        set => _verse = value;
    }
    public List<Word> Content
    {
        get => _content;
        set => _content = value;
    }

    //Argumentless Constructor for Serialization
    public Scripture(){
        _verse = 0;
    }

    public Scripture(int verse){
        _verse = verse;
    }
    //Return the scripture number as it is private.
    public int GetVerse(){ return _verse;}

    public void SetScripture(string verse){
        string[] words = verse.Split(' ');
        foreach (string wordToAdd in words){
            _content.Add(new Word(wordToAdd));
        }
    }

    public string GetDisplayText(){
        string verse = "";
        foreach (Word word in _content){
            verse = verse + word.giveWord() + " ";
        }
        return verse;
    }

    public void ResetHiddenWords(){
        for(int i = 0; i < _content.Count; i++){
                _content[i].setHidden(false);
            }
    }

    public void HideRandomWords(int numWords){
        //Start off this by making everything Shown. Only the specified number of hidden words at the end will be hidden
        for(int i = 0; i < _content.Count; i++){
                _content[i].setHidden(false);
            }

        // if the given number of words to hide is greater than the length of the scripture, just hide it all
        if(numWords >= _content.Count){
            for(int i = 0; i < _content.Count; i++){
                _content[i].setHidden(true);
            }
        }
        
        else{
            //We need to randomly set some words hidden based on the given number
            //Make a list of all possible numbers
            List<int> poolOfNum = new List<int>();
            for(int i = 0; i <_content.Count; i++){ 
                poolOfNum.Add(i);
            }
            Random rng = new Random();
            for(int i = 0; i < numWords; i++){
                int randomHidden = rng.Next(0, poolOfNum.Count); // Gets a spot in the Pool of possible numbers to hide
                _content[poolOfNum[randomHidden]].setHidden(true); // It sets this spot in the Scripture as hidden
                poolOfNum.RemoveAt(randomHidden); // Removes that option from the pool so it doesnt double hide something.
            }
        }
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _content){
            // if one word is not hidden, it return false
            if (word.getStatus() ==  false){
                return false;
            }
        }
        // Otherwise return true 
        return true;
    }
}