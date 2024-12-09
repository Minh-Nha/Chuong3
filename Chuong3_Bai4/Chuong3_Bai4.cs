namespace Chuong3_Bai4;
//CHUONG 3 BT4 : Nhập vào số nguyên dương, in ra chẵn hoặc lẻ
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai4
{
    static void Main(string[] args)
    {
        //declare variables
        int num = 0;
        //input
        Console.WriteLine("Nhap so nguyen duong: ");
        int.TryParse(Console.ReadLine(), out num );
        //processing & ouput
        if (num <= 0)
        {
            Console.WriteLine("Vui long nhap vao 1 so nguyen duong lon hon 1");
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine($"{num} la so chan");
        }
        else
        {
            Console.WriteLine($"{num} la so le");
        }
    }
}
