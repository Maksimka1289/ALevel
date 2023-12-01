using System.Text.RegularExpressions;

namespace Alevel_HW12
{
    public class ContactColections
    {
        private readonly Dictionary<string, List<Contact>> _dictionary;

        public ContactColections()
        {
            _dictionary = new Dictionary<string, List<Contact>>();
            _dictionary.Add("#", new List<Contact>());
            _dictionary.Add("English", new List<Contact>());
            _dictionary.Add("Ukrainian", new List<Contact>());
            _dictionary.Add("Number", new List<Contact>());
        }

        public void AddContact(Contact contact)
        {
            if (contact.PhoneNumber.Contains("+380"))
            {
                var list = _dictionary["Ukrainian"];
                list.Add(contact);
            }
            else if (contact.PhoneNumber.Contains("+44"))
            {
                var list = _dictionary["English"];
                list.Add(contact);
            }
            else if (!contact.PhoneNumber.Contains("+"))
            {
                var list = _dictionary["#"];
                list.Add(contact);
            }
            else
            {
                var list = _dictionary["Number"];
                list.Add(contact);
            }
        }

        public List<Contact> GetContactByPhone(string phone)
        {
            if(phone == null)
            {
                return _dictionary["English"];
            }
            if ( phone.Contains("+380") )
            {
                return _dictionary["Ukrainian"].OrderBy(x => x.Name).ToList();
            }
            else if ( phone.Contains("+44"))
            {
                return _dictionary["English"].OrderBy(x => x.Name).ToList();
            }
            else if (Regex.IsMatch(phone, @"^\d{9}$"))
            {
                return _dictionary["#"].OrderBy(x => x.Name).ToList();
            }
            else
            {
                return _dictionary["Number"].OrderBy(x => x.Name).ToList();
            }
        }
    }
}
