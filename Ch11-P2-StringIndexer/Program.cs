using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P2_StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****\n");


            #region Indexing with Strings in C#

            //CustomPeopleList PeopleList = new CustomPeopleList()
            //{
            //    peopleList = { new Person {  FirstName = "Ammar1" , LastName = "Shaukat" , Age = 22},
            //                   new Person {  FirstName = "Ammar1" , LastName = "Shaukat" , Age = 22},
            //                   new Person {  FirstName = "Ammar1" , LastName = "Shaukat" , Age = 22}
            //                    },
            //};

            ////PeopleList["3"] = new Person() { FirstName = "ammar4"}

            //Person person = PeopleList["2"];
            //Console.WriteLine(person);
            //Console.WriteLine();

            #endregion

            PersonCollection myPeople = new PersonCollection();

            myPeople["Homer"] = new Person("Homer", "Simpson", 40);
            myPeople["Marge"] = new Person("Marge", "Simpson", 38);
            
            // Get "Homer" and print data.
            Person homer = myPeople["Homer"];

            Console.WriteLine(homer.ToString());


            Console.ReadLine();
        }
    }
}
