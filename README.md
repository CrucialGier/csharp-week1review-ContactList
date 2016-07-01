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
