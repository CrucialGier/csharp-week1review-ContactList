using System.Collections.Generic;

namespace ContactList.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;

    private static List<Contact> _contactList = new List<Contact> {};

    public Contact()
    {
      _contactList.Add(this);
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string phone)
    {
      _phone = phone;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string address)
    {
      _address = address;
    }

    public static List<Contact> GetList()
    {
      return _contactList;
    }
  }
}
