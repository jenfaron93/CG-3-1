using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("The Months");
			Console.WriteLine("Please enter a number of a month (1-12): "); //prompting user
			int mon = Int32.Parse(Console.ReadLine()); //parsing response from user into an integer
			string month = string.Empty; //setting month to an empty string

			//if the user enters a certain number, 
			//a certain string will be assigned to variable month
			if (mon == 1)
				month = "January";
			else if (mon == 2)
				month = "February";
			else if (mon == 3)
				month = "March";
			else if (mon == 4)
				month = "April";
			else if (mon == 5)
				month = "May";
			else if (mon == 6)
				month = "June";
			else if (mon == 7)
				month = "July";
			else if (mon == 8)
				month = "August";
			else if (mon == 9)
				month = "September";
			else if (mon == 10)
				month = "October";
			else if (mon == 11)
				month = "November";
			else if (mon == 12)
				month = "December";
			else
				month = "We're sorry. We cannot understand your response.";


			Console.WriteLine(month); //writing the variable to console
			Console.ReadLine();

        }
    }
}
