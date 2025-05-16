using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    
    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string author, string content){
        _comments.Add( new Comment(author, content));
    }

    public void ListComments(){
        foreach(Comment opinion in _comments){
            Console.WriteLine($"{opinion.GetAuthor()} wrote: {opinion.GetContent()}");
        }
    }

    public int GetCommentCount(){ return _comments.Count;}
    public string GetTitle(){ return _title;}
    public string GetAuthor(){ return _author;}
    public string GetNiceLength(){ 
        int min = _length/60;
        int sec = _length % 60;
        string len = $"{min} Min and {sec} Sec";
        return len;  
    }
}
