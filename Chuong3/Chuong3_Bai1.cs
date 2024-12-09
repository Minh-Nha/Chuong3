//CHUONG 3 BT1 : Nhập 2 số nguyên in ra +, -, *, /
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
namespace Chuong3_Bai1;

internal class Chuong3_Bai1
{
    static void Main(string[] args)
    {
        //declare variables
        int num1, num2;
        //input
        Console.WriteLine("nhap num1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("nhap num2: ");
        int.TryParse(Console.ReadLine(), out num2);
        //processing
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"Chia lay phan nguyen: {num1} / {num2} = {num1 / num2}");
        Console.WriteLine($"Chia lay phan du:     {num1} % {num2} = {num1 % num2}");

    }
}
