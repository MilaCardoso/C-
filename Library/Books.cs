using System;

public class Books
{
    public Books(string sTypeBook, string sTitleBook, string sAuthorBook)
    {
        this.sTypeBook = sTypeBook;
        this.sTitleBook = sTitleBook;
        this.sAuthorBook = sAuthorBook;
    }
    public string sTypeBook { set; get; }
    public string sTitleBook { set; get; }
    public string sAuthorBook { set; get; }

}
