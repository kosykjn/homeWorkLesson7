using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variant #1
            //BankScore bankScore = new BankScore();
            //bankScore.StartDate = new DateTime(2017, 1, 1);
            //bankScore.StartMoney = 1000.0;
            //bankScore.YearRate = 10.0;
            #endregion

            #region Variant #2
            BankScore bankScore = new BankScore(new DateTime(2017, 1, 1), 10000.0, 10.0);
            #endregion

            var currentMoney = bankScore.Money; //кол-во денег на счете в текущий момент
            var daysFromStart = bankScore.GetDaysFromStart();
            bankScore.ShowDaysFromStartInfo();

            var moneyAfter5Year = bankScore.CalculateMoney(5);
            bankScore.ShowCalculateMoney(5);

            Console.ReadKey();
        }
    }  
}
