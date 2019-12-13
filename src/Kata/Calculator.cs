using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string val="")
        {
            if(string.IsNullOrEmpty(val)) return 0;

            if (val.Length == 1)
                return Int32.Parse(val[0]+"");
                                
            var vals = val.Split(",");
            int sum = 0;
            for(int x=0; x < 2; x++)
            {
                sum += Int32.Parse(vals[x]);
            }

            return sum;
        }
    }
}