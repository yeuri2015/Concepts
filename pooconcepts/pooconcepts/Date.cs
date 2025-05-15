﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pooconcepts
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = checkmonth(month);
            _day = Checkday(year, month, day);
        }

        private int Checkday(int year, int month, int day)
        {
            if (month == 2 && day == 29 && Isleapyear(year))
            {
                return day;
            }

            int[] dayspermonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= dayspermonth[month])

            {
                return day;
            
            }
                throw new DayException("Invalid day");
        }

        private bool Isleapyear(int year)

        {
            return year % 400 == 0  || year % 4 == 0 &&  year % 100 != 0;
            //if (year % 4 == 0)
            // {
            //     if (year %100 == 0) 
            //     {
            //         if (year % 400 == 0)
            //         {
            //        return true;




             }

                        private int checkmonth(int month)
                        {
                            if (month >= 1 && month <= 12)

                                return month;

                            throw new MonthException($"Invalid month");
                        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
