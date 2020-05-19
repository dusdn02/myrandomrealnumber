using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
           int ran= r.Next(1000);
            while (true)
            {
                Console.WriteLine("숫자를 입력해주세요 : ");
                int num = int.Parse(Console.ReadLine());

                if (num > ran)
                {
                    Console.WriteLine(num + "보다는 작은 숫자 입니다.");
                }else if (num < ran)
                {
                    Console.WriteLine(num + "보다는 큰 숫자 입니다.");
                }
                else
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
