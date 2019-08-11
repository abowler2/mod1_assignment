﻿using System;

namespace mod1_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables for student and teacher
            string studentFName = "";
            string studentLName = "";
            DateTime studentBirthdate;
            string studentAddressLine1 = "";
            string studentAddressLine2 = "";
            string studentCity = "";
            string studentStateProvince = "";
            string studentCountry = "";

            string teacherFName = "";
            string teacherLName = "";
            DateTime teacherBirthdate;
            string teacherAddressLine1 = "";
            string teacherAddressLine2 = "";
            string teacherCity = "";
            string teacherStateProvince = "";
            string teacherCountry = "";

            //create variables for program info
            string programName = "";
            string deptHead = "";
            string degrees = "";

            //create variables for degree info
            string degreeName = "";
            int creditsRequired = 0;

            //create variables for course info
            string courseName = "";
            int credits = 0;
            int durationWeeks = 0;
            string teacher = "";


            //assign values to the variables
            studentFName = "Alice";
            studentLName = "Smith";
            studentBirthdate = new DateTime(2001, 8, 6);
            studentAddressLine1 = "123 Main St";
            studentAddressLine2 = "Apt. 4";
            studentCity = "Anytown";
            studentStateProvince = "CA";
            studentCountry = "United States";

            teacherFName = "Jack";
            teacherLName = "Frost";
            teacherBirthdate = new DateTime(1971, 10, 6);
            teacherAddressLine1 = "1200 Univrsity Way";
            teacherAddressLine2 = "Ste. 200";
            teacherCity = "UniTown";
            teacherStateProvince = "CA";
            teacherCountry = "United States";

            programName = "Mathmatics";
            deptHead = "Jack Frost";
            degrees = "Mathmatics";

            degreeName = "Mathmatics";
            creditsRequired = 200;

            courseName = "Calculus 101";
            credits = 4;
            durationWeeks = 11;
            teacher = "Jack Frost";


            //output values from variables
            Console.WriteLine("{0} {1}", studentFName, studentLName);
            Console.WriteLine("Born on " + studentBirthdate);
            Console.WriteLine($"Lives at {studentAddressLine1}, {studentAddressLine2},"
                              + $"{studentCity}, {studentStateProvince}");
            Console.WriteLine($"in {studentCountry}");
            Console.WriteLine($"and is getting a degree in {degrees} under {deptHead}");
     
        }
    }
}
