using System;

namespace Parsing
{
    public static class Parsing
    {
        public static void Parse()
        {
            //method Parse
            Console.WriteLine("Введіть ціле");
            string strdata = Console.ReadLine();
            int intdata = int.Parse(strdata);

            Console.WriteLine("Введіть число з дробовою частиною і порядком");
            strdata = Console.ReadLine();
            double doubdata = double.Parse(strdata);
            Console.WriteLine("intdata = {0}; doubdata = {1}", intdata, doubdata);
            Console.ReadKey();
        }

        public static void InputVars()
        {
            string strInput;
            Console.WriteLine("INPUT_BYTE");
            strInput = Console.ReadLine();
            byte b1;
            b1 = byte.Parse(strInput);
            Console.WriteLine(b1);

            Console.WriteLine("INPUT_INT");
            strInput = Console.ReadLine();
            int n;
            n = int.Parse(strInput);
            Console.WriteLine(n);

            Console.WriteLine("INPUT_FLOAT");
            strInput = Console.ReadLine();
            float x;
            x = float.Parse(strInput);
            Console.WriteLine(x);

            Console.WriteLine("INPUT_CHAR");
            strInput = Console.ReadLine();
            char ch;
            ch = char.Parse(strInput);
            Console.WriteLine(ch);

            Console.ReadKey();
        }

        public static void ToStringConvertation()
        {
            string name;
            int age;
            double salary;

            name = "Василь Іванов";
            age = 20;
            salary = 2700;

            string s = "Ім'я: " + name +
            ". Вік: " + age.ToString() +
            ". Зарплата: " + salary;

            Console.WriteLine(s);
            Console.ReadKey();
        }

        public static void ConvertDemo()
        {
            string s;
            byte b;
            int n;
            double x;
            bool flag;
            char sym;
            DateTime dt;
            sym = '7';
            s = Convert.ToString(sym);
            x = Convert.ToDouble(s);
            n = Convert.ToInt32(x);
            b = Convert.ToByte(n);
            flag = Convert.ToBoolean(b);
            x = Convert.ToDouble(flag);
            s = Convert.ToString(flag);
            s = "300";
            n = Convert.ToInt32(s);
            s = "14.09";
            s = "14.09.2008";  // "09/14/2008"
            dt = Convert.ToDateTime(s);

        }
    }
}