using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P2_StringIndexer
{
    class CustomPeopleList
    {
        public List<Person> peopleList { get; set; }

        public CustomPeopleList()
        {
            peopleList = new List<Person>();
        }

        public Person this[string name]
        {
            get => (Person)peopleList[int.Parse(name)];
            //set => peopleList.Add(int.Parse(name));
        }

        public Person this[int index]
        {
            get => (Person)peopleList[index];
            //set => peopleList.Add(int.Parse(name));
        }
    }
}
