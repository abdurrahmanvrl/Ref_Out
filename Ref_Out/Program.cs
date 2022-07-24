using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ref_Out");
            int number1 = 20;        // ref in çalışabilmesi için number1 burada set edilmesi gerekli
            int number2 = 100;
            int number3;           // out da burada set etmemiz gerekmez
            var result = Add1(number1);
            Console.WriteLine("number1 (20) + number2 = " + result);

            Console.WriteLine("number1 (30) + number2 = " + Add2(number1, number2));
            Console.WriteLine("number1 = " + number1);

            Console.WriteLine("number1 (30) + number2 = " + Add3(ref number1, number2));
            Console.WriteLine("number1 = " + number1 + " > number1 ref olarak çağırıldığı için geriye dönük güncellendi ve 30 değerini aldı");

            Console.WriteLine("number1 (30) + number2 = " + Add4(out number1, number2));
            Console.WriteLine("number1 = " + number1 + " > number1 out olarak çağırıldığı için geriye dönük güncellendi ve 30 değerini aldı");
        }

        static int Add1(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add2(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add3(ref int number3, int number2)
        {
            number3 = 30;
            return number3 + number2;
        }

        static int Add4(out int number1, int number2)
        {
            number1 = 30; // out da metotun içerisinde değerin set edilmesi gerekli
            return number1 + number2;
        }

    }
}