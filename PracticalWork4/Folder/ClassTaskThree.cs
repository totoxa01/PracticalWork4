using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork4.Folder
{
    class ClassTaskThree
    {
        public static string DeterminingTheTimeOfYearMonths(int number)
        {
            ClassEnumMonths.Months months=new ClassEnumMonths.Months();
            string timeOfYear = "";
            if (number == 12 && number >= 1 && number <= 2)
            {
                months = (ClassEnumMonths.Months)Enum.GetValues(typeof(ClassEnumMonths.Months)).GetValue(0);
                timeOfYear= Convert.ToString(months);                
            }
            else if (number >= 3 && number <= 5)
            {
                months = (ClassEnumMonths.Months)Enum.GetValues(typeof(ClassEnumMonths.Months)).GetValue(1);
                timeOfYear = Convert.ToString(months);
            }
            else if (number >= 6 && number <= 8)
            {
                months = (ClassEnumMonths.Months)Enum.GetValues(typeof(ClassEnumMonths.Months)).GetValue(2);
                timeOfYear = Convert.ToString(months);
            }
            else if (number >= 9 && number <= 11)
            {
                months = (ClassEnumMonths.Months)Enum.GetValues(typeof(ClassEnumMonths.Months)).GetValue(3);
                timeOfYear = Convert.ToString(months);
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                timeOfYear = "";
            }            
            return timeOfYear;
        }


        public static string DeterminingTheTimeOfYearEnum(string monthsEmun)
        {
            string months = "";
            switch (monthsEmun)
            {
                case "Winter":
                    months = "зима";
                    break;
                case "Spring":
                    months = "весна";
                    break;
                case "Summer":
                    months = "лето";
                    break;
                case "Autumn":
                    months = "осень";
                    break;
            }
            return months;
        }




    }
}
