using Alevel_HW12;

public class Program
{
    private static void Main(string[] args)
    {
        var phoneBook = new ContactColections();
        var value = new List<Contact> { new Contact { Name = "Maksim", PhoneNumber = "+380950634449" } };

        phoneBook.AddContact(new Contact { Name = "Maksim", PhoneNumber = "+38095065" });
        phoneBook.AddContact(new Contact { Name = "Vlad", PhoneNumber = "+44555555" });
        phoneBook.AddContact(new Contact { Name = "Bohdan", PhoneNumber = "38095065" });
        phoneBook.AddContact(new Contact { Name = "Marina", PhoneNumber = "+568095065" });

        phoneBook.GetContactByPhone("+3809506");
        phoneBook.GetContactByPhone("+4409506");
        phoneBook.GetContactByPhone("380950689");
        phoneBook.GetContactByPhone("+53809506");
    }
}