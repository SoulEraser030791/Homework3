﻿using System;

namespace Homework3
{
        internal class CComplex
{
        static void Main(string[] args)
        { }
        private double im;
        double re;
        public CComplex()
        {
            im = 0;
            re = 0;
        }
        public CComplex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public CComplex Minus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public CComplex Multi(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }


        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}



