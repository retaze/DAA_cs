﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MembersUndFinalizers
{
    class Members
    {
        //member - privat fields
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public fields
        public int age;

        //member - property - eröffnet jobTitle auf einem sicheren Wege
        // Properties beginnen mit einem Großbustaben
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member Method - kann von anderen Klassen aus aufgerufen werden
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, ich bin {0} und mein Jobtitel ist {1}. Ich bin {2} Jahre alt.", memberName, jobTitle, age);

            }
        }

        //private member Method
        private void SharingPrivateInfo()
        {
            Console.WriteLine("Mein Gehalt ist {0}", salary);
        }

        //member constructor - Default Constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Entwickler";
            Console.WriteLine("Objekt erzeugt");

        }

        //member - Finalizer - Destructor
        ~Members()
        {
            //Aufräumarbeiten
        }

    }
}
