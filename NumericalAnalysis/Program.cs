using System;
using System.Collections;

namespace NumericalAnalysis
{
    class Program
    {

        static int count;
        static double wucha;
        Program()
        {
           
        }
        static void Main(string[] args)
        {
            wucha = 0.00001;
          //  double x = Double(1, 1.5);
           // Console.WriteLine(x.ToString()+"  迭代次数："+count.ToString());
       //    double x1 = Newton(10);
         //   Console.WriteLine(x1.ToString()+"  迭代次数：" + count.ToString());
            double x2 = ChordCut(0.5, 0.6);
            Console.WriteLine(x2.ToString() + "  迭代次数：" + count.ToString());
            Console.Read();
            
        }
        static double Double(double a,double b)//二分法
        {
            count = 0;
            double x=0;
            while(true)
            {
                double c = (a + b) / 2;
                if (Func(c) == 0)
                {
                    x = c;
                    return x;
                }
                if (b - a < wucha)
                {
                    x = c;
                    return x;
                }
                if (Func(a) * Func(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                count++;
            }
        }
        static double Newton(double x0)//牛顿法
        {
            count = 0;
            double x = 0;
            double x1 = x0;
            double x2 = 0;
            x2 = x0-Func(x0) / fun(x0);
            while(Math.Abs(x2-x1)>=wucha)
            {
                x1 = Math.Round(x2, 6);
                x2 = Math.Round(x1 - Func(x1) / fun(x1), 6);
                count++;
            }
            x = x2;
            return x;
        }
        static double ChordCut(double _x0,double _x1)//双点弦截法
        {
            double x = 0;
            count = 0;
            double x1 = _x1;
            double x0 = _x0;
            double x2 = 0;
            count++;
            x2 = Math.Round(x1 - Func(x1) * ((x1 - x0) / (Func(x1) - Func(x0))), 5);
            while(Math.Abs(x2-x1)>=wucha)
            {
                x0 = x1;
                x1 = x2;
                x2 = Math.Round(x1 - Func(x1) * ((x1 - x0) / (Func(x1) - Func(x0))), 5);
                count++;
            }
            x = x2;
            return x;
        }
        static double Func(double x)
        {
            double y=0;
            //  y = Math.Pow(x, 4) - 1.4 * Math.Pow(x, 3) - 0.48 * Math.Pow(x, 2) + 1.408 * Math.Pow(x, 1) - 0.512 * Math.Pow(x, 0);
            //   y = Math.Pow(x, 3) - Math.Pow(x, 1) - 1;
              y = x * Math.Exp(x) - 1;
          //  y = Math.Pow(x, 2) - 115;
            
            return y;
        }
        static double fun(double x)
        {
            double y = 0;
            //y = 4 * Math.Pow(x, 3) - 4.2 * Math.Pow(x, 2) - 0.96 * Math.Pow(x, 1) + 1.408 * Math.Pow(x, 0);
            //y = Math.Exp(x) + x * Math.Exp(x);
            y = 2 * x;
            return y;
        }
        
    }
}
