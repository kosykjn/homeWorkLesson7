using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_3
{
    class BankScore
    {
        #region Variant #1
        //public DateTime StartDate { get; set; }
        //public double StartMoney { get; set; }
        //public double YearRate { get; set; }

        //public BankScore()
        //{
        //}
        #endregion

        #region Variant #2
        public DateTime StartDate { get; private set; }
        public double StartMoney { get; private set; }
        public double YearRate { get; private set; }

        public BankScore(DateTime startDate, double startMoney, double yearRate)
        {
            StartDate = startDate;
            StartMoney = startMoney;
            YearRate = yearRate;
        }
        #endregion

        public double Money
        {
            get
            {
                return CalculateMoney(DateTime.Now.Year - StartDate.Year);
            }
        }

        public int GetDaysFromStart()
        {
            return (DateTime.Now - StartDate).Days;
        }

        public void ShowDaysFromStartInfo()
        {
            Console.WriteLine($"От начала открытия счета прошло {GetDaysFromStart()} дней!");
        }

        public double CalculateMoney(int yearCount)
        {
            double result = StartMoney;

            for (int i = 0; i < yearCount; i++)
            {
                var procentSum = (YearRate * result) / 100;
                result += procentSum;
            }

            return result;
        }

        public void ShowCalculateMoney(int yearCount)
        {
            Console.WriteLine($"На счете через {yearCount} года будет сумма в размере: {CalculateMoney(yearCount)}.");
        }
    }
}
