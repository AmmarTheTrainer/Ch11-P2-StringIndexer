using System;
using System.Collections.Generic;
using System.Data;
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

            OverLoadingIndexerMethods();

            MultiIndexerWithDataTable();

            Console.ReadLine();
        }

        private static void MultiIndexerWithDataTable()
        {
            // Make a simple DataTable with 3 columns.
            DataTable myTable = new DataTable();

            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));

            // Now add a row to the table.
            myTable.Rows.Add("Mel", "Appleby", 60);
            
            // Use multidimension indexer to get details of first row.
            Console.WriteLine("First Name: {0}", myTable.Rows[0][0]);
            Console.WriteLine("Last Name: {0}", myTable.Rows[0][1]);
            Console.WriteLine("Age : {0}", myTable.Rows[0][2]);

        }

        private static void IndexersWithMultipleDimensions()
        {

        }

        private static void OverLoadingIndexerMethods()
        {

            // DataTableCollection


            CustomPeopleList PeopleList = new CustomPeopleList()
            {
                peopleList = { new Person {  FirstName = "Ammar1" , LastName = "Shaukat" , Age = 22},
                               new Person {  FirstName = "Ammar1" , LastName = "Shaukat" , Age = 22},
                               new Person {  FirstName = "Ammar1" , LastName = "Shaukat" , Age = 22}
                                },
            };

            //PeopleList["3"] = new Person() { FirstName = "ammar4"}

            Person person = PeopleList["2"];
            Person person2 = PeopleList[2];

            Console.WriteLine(person);
            Console.WriteLine(person2);
            Console.WriteLine();
        }
    }
}
