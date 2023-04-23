using System;
namespace Phan1_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhập vào số nguyên tố
            Console.WriteLine("Nhập vào một số:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Số có thể chia hết cho 3 và 5 là:");
            //thực hiện vòng lặp tính toán số nguyên tố chia hết cho 3 và chia hết cho 5/
            //in ra số nguyên tố là bội số
            for (int i = 1; i <= a; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
