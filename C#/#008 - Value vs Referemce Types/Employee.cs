﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _008___Value_vs_Referemce_Types
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;
        public EmployeeType employeeType;

        const int minimalHoursWorkedUnit = 1;


        public Employee(string first, string last, string em, DateTime bd) : this(first,
        last, em, bd, 0, EmployeeType.StoreManager)
        {

        }
        public Employee(string first, string last, string em, DateTime bd, double rate,
            EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
            employeeType = empType;
        }

        public void PerformWork(int numberOfHours = minimalHoursWorkedUnit)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hours(s)!");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            if (employeeType == EmployeeType.Manager)
            {
                wage = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours) { numberOfHoursWorked = 0; }

            return wage;
        }
        public int CalculateBonus(int bonus)
        {
            if(numberOfHoursWorked > 10)
                bonus += 10;

            Console.WriteLine($"The emplyee got a bonus of {bonus}");
            return bonus;
        }
        public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public int CalculateBonusAndBonusTaxWithOut(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"" +
                $"\nFirst name: \t{firstName}" +
                $"\nLast name: \t{lastName}" +
                $"\nEmail: \t{email}" +
                $"\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

    }
}
