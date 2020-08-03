using System;

public class Person
{
    public Person(string sName, string sContact)
    {
        this.sName = sName;
        this.sContact = sContact;
    }
    public string sName { set; get; }
    public string sContact { set; get; }

}
