using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int rnum, input_num;
            Random num = new Random();
            rnum = num.Next(100);

            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                input_num = int.Parse(Console.ReadLine());

                if (rnum > input_num)
                    Console.WriteLine(input_num + "보다는 큰 숫자입니다!!");
                else if (rnum < input_num)
                    Console.WriteLine(input_num + "보다는 작은 숫자입니다!!");
                else
                {
                    Console.WriteLine("축하합니다! 정답입니다! :D");
                    break;
                }
            }

        }
    }
}
