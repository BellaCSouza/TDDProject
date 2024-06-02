using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Calculator
    {
        private List<string> historyList;
        private string date;

        public Calculator(string date)
        {
            historyList = new List<string>();
            this.date = date;
        }

        public int add(int x, int y)
        {
            int result = x + y;
            historyList.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }

        public int subtract(int x, int y) {
            int result = x - y;
            historyList.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }

        public int multiply(int x, int y)
        {
            int result = x * y;
            historyList.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }

        public int divide(int x, int y)
        {
            int result = x / y;
            historyList.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }

        public List<string> history()
        {
            historyList.RemoveRange(3, historyList.Count - 3);
            return historyList;
        }
    }
}
