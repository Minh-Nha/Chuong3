namespace Chuong3_Bai5;
//CHUONG 3 BT5 : Nhập 2 số vào bàn phím, in ra giá trị lớn nhất
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai5
{
    static void Main(string[] args)
    {
        //declare variables
        int num1, num2;
        //input
        Console.WriteLine("Nhap num1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Nhap num2: ");
        int.TryParse(Console.ReadLine(), out num2);
        //processing
        if (num1 == num2)
        {
            Console.WriteLine($"{num1} = {num2} vui long nhap lai");
        }
        else if (num1 > num2)
        {
            Console.WriteLine($"{num1} co gia tri lon nhat");
        }
        else
        {
            Console.WriteLine($"{num2} co gia tri lon nhat");
        }
    }
}
