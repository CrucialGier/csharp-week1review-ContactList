#Contact List
###By Stewart Cole 7/1/2016

##Setup

*Assuming you are running on windows and you have mono and nancy installed.* (http://www.mono-project.com/docs/getting-started/install/windows/)
*Clone the repository at*
(https://github.com/CrucialGier/csharp-week1review-ContactList.git)
*using the command git clone*
*Enter the files directory using the console and enter dnu restore and then dnx kestrel*
*Visit localhost:5004 in your web browser.*


##Specs

Each contact should have info containing their Name, PhoneNumber and Address.
  Example: Judy { Judy, Foster / (123) 456-7890 / 123 Oak street }

All Contacts should be saved into a list so they can be viewed in an All Contacts page.
  Example: Click "View All Contacts";

            Kevin Rogers,
              Phone: (012) 345-6789,
              Address: 456 Pine Ave

            Judy Foster,
              Phone: (123) 456-7890,
              Address: 123 Oak Street

An AddContact meathod to add contacts to the ContactList.
  Example: ContactList = {(Kevin, Phone, Address)};
            Click "Add Contact" => Fill out Form (Judy, Phone, Address);
            ContactList = {(Kevin, Phone Address), (Judy, Phone, Address)};

A ClearContacts meathod to remove all contacts from ContactList.
  Example: ContactList = {(Kevin, Phone Address), (Judy, Phone, Address)};
            Click "Clear All Contacts";
            ContactList = {};

[EXTRA] A RemoveContact meathod to remove contacts from the ContactList.
  Example: ContactList = {(Kevin, Phone Address), (Judy, Phone, Address)};
            Click "Remove Contact" on contact Judy;
            ContactList = {(Kevin, Phone, Address)};

##Known Bugs

None at the moment

##Technologies Used

Atom
C#
Html
Nancy
Razor

##Copyright

Stewart Cole copyright(c) 7/1/2016
