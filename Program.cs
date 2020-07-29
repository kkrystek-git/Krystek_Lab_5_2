using System;
using System.Collections.Generic;
using System.IO;

namespace Krystek_Lab_5_2
{
	class Program
	{
		public enum WeekDays {
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}




		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.30.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 5_2
			// =========================================================================
			//
			//
			// 1.Create Lists.
			//

			// 1.Create Enum for Days of Week.

				// See Above Main Section fopr Enum.


			// 2. Create List for Task Items.

			List<string> TaskList = new List<string>();


			// 3.Create Loop to Collect Tasks.

			foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
			{
				Console.WriteLine("Type in a new task for " + day);
				string dayspace = day.ToString();
				string task = dayspace.PadRight(10) + " : " + Console.ReadLine();
				Console.WriteLine("\n");
				TaskList.Add(task);
			};


			// 3.Display List of Tasks by Day.

			Console.Clear();

			foreach (string task in TaskList)
			{
				Console.WriteLine(task);
			};

			Console.WriteLine("\n\n\n");

			// End

		}
	}
}
