using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace DelegateTest
{
    #region 测试一

    //public delegate int ComputeDel(int a, int b);

    //public class ComputeTools
    //{
    //    public int Multiple(int a, int b)
    //    {
    //        return a * b;
    //    }
    //    public int Divide(int a, int b)
    //    {
    //        return a / b;

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ComputeTools tool = new ComputeTools();
    //        //ComputeDel del = new ComputeDel(tool.Multiple);
    //        ComputeDel del = tool.Multiple;
    //        del += tool.Divide;

    //        int res = del(8, 6);
    //        Console.WriteLine(res);
    //        Console.ReadKey();
    //    }
    //} 
    #endregion




    #region 测试二

    public delegate void ComputeDel();

    public delegate string HandleStrDel(string str);

    public class ComputeTools
    {
        public void Multiple()
        {
            Console.WriteLine("第一个方法");

        }
        public void Divide()
        {
            Console.WriteLine("第二个方法");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComputeTools tool = new ComputeTools();
            //ComputeDel del = new ComputeDel(tool.Multiple);
            ComputeDel del = tool.Multiple;

            //del += tool.Divide;
            //del += tool.Multiple;
            //del -= tool.Multiple;
            //del();

            var str = "absBHN";
            var res = HandleStr(str,StrTolower);

            res = HandleStr(str, delegate(string s) { return s.ToUpper(); });
            Console.WriteLine(res);


            Console.WriteLine("结束。。。");
            Console.ReadKey();
        }



        public static string HandleStr(string str, HandleStrDel del)
        {
            return del(str);
        }


        public static string StrToUpper(string str)
        {
            return str.ToUpper();
        }
        public static string StrTolower(string str)
        {
            return str.ToLower();
        }



        #region 测试4
        public static void add()
        {
            //测试4测试4测试4 
        }

        #endregion
    }

    #endregion




}



