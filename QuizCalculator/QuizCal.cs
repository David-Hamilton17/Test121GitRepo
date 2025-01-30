//Written by David Hamilton
//1/27/2025

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculator
{
    public class QuizCal
    {
        //class variables 
        private double quiz1 = -999.99;
        private double quiz2 = -999.99;
        private double quiz3 = -999.99;
        private double quiz4 = -999.99;

        //private double total = -40000.99;
        //private double average = -99999.99;

        //private string letterGrade = "n/a";

        //Beware of magic number

        //Gets and Sets
        public double Quiz1
        {
            get { return quiz1; }
            set
            {
                if (value > 100.0 || value < 0)
                { 
                    this.quiz1 = -9999.99;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }
        public double Quiz2
        {
            get { return quiz2; }
            set
            {
                if (value > 100.0 || value < 0)
                {
                    this.quiz2 = -9999.99;
                }
                else
                {
                    this.quiz2 = value;
                }
            }
        }
        public double Quiz3
        {
            get { return quiz3; }
            set
            {
                if (value > 100.0 || value < 0)
                {
                    this.quiz3 = -9999.99;
                }
                else
                {
                    this.quiz3 = value;
                }
            }
        }
        public double Quiz4
        {
            get { return quiz4; }
            set
            {
                if (value > 100.0 || value < 0)
                {
                    this.quiz4 = -9999.99;
                }
                else
                {
                    this.quiz4 = value;
                }
            }
        }

        //Methods
        public double CalcTotal()
        {
            double aTotal = 0.0;
            aTotal = this.Quiz1 + this.Quiz2 + this.Quiz3 + this.Quiz4;
            return aTotal;
        }
        public double CalcAverage() 
        {
            double aAverage = 0.0;
            //The 4 is a classic "Magic number"
            aAverage = (this.Quiz1 + this.Quiz2 + this.Quiz3 + this.Quiz4) / 4;
            return aAverage;
        }
        public string CalcLetterGrade()
        {
            double aAverage = 0.0;
            string LetterGrade = "n/a";
            aAverage = (this.Quiz1 + this.Quiz2 + this.Quiz3 + this.Quiz4) / 4;

            if (aAverage >= 0 && aAverage < 60.0)
            {
                LetterGrade = "F";
            }
            if (aAverage >= 60.0 && aAverage < 70.0)
            {
                LetterGrade = "D";
            }
            if (aAverage >= 70.0 && aAverage < 90.0)
            {
                LetterGrade = "B";
            }
            if (aAverage >= 90.0 && aAverage < 100.0)
            {
                LetterGrade = "A";
            }
            return LetterGrade;
        }

        public override string ToString()
        {
            string msg = "";
            return msg;
        }
    }
}
