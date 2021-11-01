using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenric
{
    public class UC5PrintMaxMethodToStdOut<T>where T:IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public T[] value;
        private int[] arr;

        public UC5PrintMaxMethodToStdOut(T firstValue, T secondValue, T thirdValue, T[] value)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
            this.value = value;
        }

        public UC5PrintMaxMethodToStdOut(int[] arr)
        {
            this.arr = arr;
        }

        public static T testMaximum<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
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



        public T maxMethod()
        {
            T max = UC5PrintMaxMethodToStdOut<T>.testMaximum(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }


        public static T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }


        public static T maxValue(params T[] values)
        {
            T[] sortedValues = Sort(values);
            return sortedValues[^1];
        }

        public static T GetMaxValue(params T[] value)
        {
            T max = maxValue(value);
            return max;
        }

        public T printMaxValue()
        {
            return UC5PrintMaxMethodToStdOut<T>.GetMaxValue(this.value);
        }
    }
}
