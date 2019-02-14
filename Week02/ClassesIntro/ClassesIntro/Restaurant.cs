using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Restaurant
    {
        public string Name;
        public string Owner;
        public string FoodType;
        public int Expenses;
        public int Money;

        public void NetRevenue()
        {
            int TotalMoney = Money - Expenses;
            Console.WriteLine(Convert.ToInt32(TotalMoney));
        }
    }
}
