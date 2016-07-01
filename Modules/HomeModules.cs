using Nancy;
using ContactList.Objects;
using System.Collections.Generic;

namespace ContactList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> contactList = Contact.GetList();
        return View["contact_list.cshtml", contactList];
      };
      Get["/new_contact"] = _ => View["add_contact.cshtml"];
      Post["/contact_added"] = _ => {
        Contact newContact = new Contact();
        newContact.SetAddress(Request.Form["contactAddress"]);
        newContact.SetName(Request.Form["contactName"]);
        newContact.SetPhone(Request.Form["contactPhone"]);
        return View["contact_added.cshtml", newContact];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
