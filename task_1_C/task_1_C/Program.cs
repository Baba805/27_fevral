using System;

namespace task_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_num = Console.ReadLine();
            int reqem = Convert.ToInt32(str_num);
            //Console.WriteLine(reqem);
            int kohneReqem = reqem;
            int tersReqem = 0;
            int qaliq = 0;
            while(reqem > 0)
            {
                qaliq = reqem % 10;
                tersReqem = (tersReqem * 10) + qaliq;
                reqem = reqem / 10;
            };
            if (kohneReqem == tersReqem)
            {
                Console.WriteLine("eded polindromdur");
            }
            else
            {
                Console.WriteLine("eded polindrom deyil");
            }

        }
    }
}
