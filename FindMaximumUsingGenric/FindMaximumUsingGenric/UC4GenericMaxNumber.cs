using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenric
{
    public   class UC4GenericMaxNumber
    {
        /*public T firstValue, secondValue, thirdValue;
        private int[] arr;

        public UC4GenericMaxNumber(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public UC4GenericMaxNumber(int[] arr)
        {
            this.arr = arr;
        }
*/
        public static T findMaximum<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
                thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,thirdValue are same");
        }
       








        /* public T maxMethod()
          {
              T max = UC4GenericMaxNumber<T>.TestMaximum(this.firstValue, this.secondValue, this.thirdValue);
              return max;
          }
  
        public T TestMaximum(T firstValue, T secondValue, T thirdValue)
        {
            throw new NotImplementedException();
        }

        public static T maxValue(params T[] values)
        {
            T[] sortedValues = Sort(values);
            return sortedValues[^1];
        }


        public static T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }*/
    }
}
