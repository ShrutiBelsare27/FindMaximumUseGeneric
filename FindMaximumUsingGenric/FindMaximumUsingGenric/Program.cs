using System;

namespace FindMaximumUsingGenric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maximum integer number");
           
            int maxIntNumber = MaximumNumberCheck.maximumIntegerNumber(50, 150, 600);
            Console.WriteLine(maxIntNumber);

           Console.WriteLine("Maximum float value ");
            double maxFloateNumber = UC2FloatNumberMax.maximumFloateNumber(4.5, 9.5, 2.1);
            Console.WriteLine(maxFloateNumber);

            Console.WriteLine("Maximum string name ");
            string maxString = UC3MaxString.MaximumString("Apple", "Peach", "Banana");
            Console.WriteLine(maxString);


            Console.WriteLine("Generic value in use case 4 ");
            int maxNumber = UC4GenericMaxNumber.findMaximum<int>(100, 300,500);
            double maxdoubleNumber = UC4GenericMaxNumber.findMaximum<double>(5.6, 3.5, 5.9);
            string maxStringName = UC4GenericMaxNumber.findMaximum<string>("Apple", "Peach","Banana");
            Console.WriteLine(maxNumber);
            Console.WriteLine(maxdoubleNumber);
            Console.WriteLine(maxStringName);
     

            
            

            /*Console.WriteLine("Generic value in use case 5 ");
            int[] arr = { 123, 160, 450, 60 };
            UC5PrintMaxMethodToStdOut<int> generic = new UC5PrintMaxMethodToStdOut<int>(arr);
            generic.printMaxValue();
*/




        }
    }

    

        
    }

