using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{ //// Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;


    struct Complex

    {
        public double im;
        public double re;

        public Complex(int v1, int v2) : this()
        {
        }

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
            public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
    
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;


            Console.WriteLine("Рассмотрим результат работы структуры:");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результом операции сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результом операции умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Результом операции вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());

            Console.WriteLine();

            Console.WriteLine("Рассмотрим результат работы класса:");
            Complex ccomplex1 = new Complex (1, 1);
            Complex ccomplex2 = new Complex (2, 2);
            ccomplex2.im = 3;
           Complex cresult = ccomplex1.Plus(ccomplex2);
            Console.WriteLine("Результом операции сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                + cresult.ToString());
            cresult = ccomplex1.Multi(ccomplex2);
            Console.WriteLine("Результом операции умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());
            cresult = ccomplex1.Minus(ccomplex2);
            Console.WriteLine("Результом операции вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());
            Console.ReadKey();
        }
    }
}
