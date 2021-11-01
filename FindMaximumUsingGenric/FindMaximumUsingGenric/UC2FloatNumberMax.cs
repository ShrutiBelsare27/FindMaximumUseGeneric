using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenric
{
   public  class UC2FloatNumberMax
    {
        public static double maximumFloateNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            //throw new Exception("firstValue,secondValue,thirdValue are same");
            return firstValue;
        }
    }
}
