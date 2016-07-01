using Nancy;
using ContactList.Objects;
using System.Collections.Generic;

namespace Contacts
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
    }
  }
}
