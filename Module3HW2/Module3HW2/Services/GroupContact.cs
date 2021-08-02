using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class GroupContact<T> : IGroupContactsService<T>
    {
        private const string _digitGroupKey = "0-9";
        private const string _otherGroupKey = "#";
        private string _englishAlphabet;
        private string _russianAlphabet;
        private CultureInfo _currentCulture;
        private GroupType _currentGroupingType;
        private List<string> _keys;
        private List<Contact> _values;
        private SortedList<string, List<Contact>> _contactList;

        public GroupContact()
        {
            _currentCulture = new CultureInfo("en-US");
            _currentGroupingType = GroupType.GroupByFullName;
        }

        public CultureInfo CultureInfo
        {
            set { _currentCulture = value; }
        }

        public GroupType GroupType
        {
            set { _currentGroupingType = value; }
        }

        public SortedList<string, List<Contact>> GroupedContactList => _contactList;

        public void GroupAlphabetically(List<T> values)
        {
            ResetContactList();
            GroupAlphabetically(values, _currentCulture, _currentGroupingType);
        }

        public void GroupAlphabetically(List<T> values, CultureInfo cultureInfo, GroupType groupingType)
        {
            _values = values as List<Contact>;
            var alphabet = ChooseAlphabet(cultureInfo);
            FillKeysList(alphabet);
            FillContactList();
            GroupingContacts(groupingType);
        }

        private void GroupingContacts(GroupType groupingType)
        {
            switch (groupingType)
            {
                case GroupType.GroupByFullName:
                default:
                    GroupByFullName();
                    break;
            }
        }

        private void GroupByFullName()
        {
            var comparer = new SortFullName();

            foreach (var item in _values)
            {
                var key = item.FullName[0].ToString().ToUpper();

                if (char.IsDigit(key, 0))
                {
                    AddContact(_digitGroupKey, item, comparer);
                }
                else if (!_contactList.ContainsKey(key))
                {
                    AddContact(_otherGroupKey, item, comparer);
                }
                else
                {
                    AddContact(key, item, comparer);
                }
            }
        }

        private void AddContact(string key, Contact newContact, IComparer<Contact> comparer)
        {
            var value = _contactList[key];
            value.Add(newContact);
            value.Sort(comparer);
        }

        private string ChooseAlphabet(CultureInfo cultureInfo)
        {
            switch (cultureInfo.ToString())
            {
                case "ru-RU":
                    if (string.IsNullOrEmpty(_russianAlphabet))
                    {
                        _russianAlphabet = LanguageDeserializer.DownlodAlphabet(new CultureInfo("ru-RU"));
                    }

                    return _russianAlphabet;
                case "en-US":
                default:
                    if (string.IsNullOrEmpty(_englishAlphabet))
                    {
                        _englishAlphabet = LanguageDeserializer.DownlodAlphabet(new CultureInfo("en-US"));
                    }

                    return _englishAlphabet;
            }
        }

        private void FillKeysList(string alphabet)
        {
            foreach (var item in alphabet)
            {
                _keys.Add(item.ToString());
            }

            _keys.Add(_digitGroupKey);
            _keys.Add(_otherGroupKey);
        }

        private void FillContactList()
        {
            foreach (var item in _keys)
            {
                _contactList.Add(item, new List<Contact>());
            }
        }

        private void ResetContactList()
        {
            _keys = new List<string>();
            _contactList = new SortedList<string, List<Contact>>(new SortList());
        }
    }
}
