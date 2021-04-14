using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork4.Folder
{
    class ClassTaskOne
    {
        private static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
            
        }

        private enum LastName
        { 
            Иванов,
            Сидоров,
            Леонов, 
            Марков,
            Сурнин,
            Беспалый
        };

        private enum FirstName
        { 
            Иван,
            Петр,
            Кирилл,
            Рамазан,
            Георгий,
            Владимир
        };

        private enum Patronymic
        { 
            Витальевич,
            Николаевич,
            Андреевич,
            Алексеевич,
            Владимирович,
            Сергеевич
        };

        public static void FullName()
        {
            Random rn = new Random();
            FirstName fN;
            LastName lN;
            Patronymic p;
            int number = 0;
            for (int i = 0; i < 5; i++)
            {               
                number = rn.Next(5);
                fN = (FirstName)Enum.GetValues(typeof(FirstName)).GetValue(number);
                string convertFirstName = Convert.ToString(fN);
                number = rn.Next(5);
                lN = (LastName)Enum.GetValues(typeof(LastName)).GetValue(number);
                string convertLastName = Convert.ToString(lN);
                number = rn.Next(5);
                p = (Patronymic)Enum.GetValues(typeof(Patronymic)).GetValue(number);
                string convertPatronymic = Convert.ToString(p);
                Console.WriteLine($"ФИО: {GetFullName(convertLastName, convertFirstName, convertPatronymic)} ");
                
            }
        }
    }
}
