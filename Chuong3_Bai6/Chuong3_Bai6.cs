namespace Chuong3_Bai6;
//CHUONG 3 BT6 : Nhập vào số nguyên dương có 2 chữ số, in ra số đảo ngược
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai6
{
    static void Main(string[] args)
    {
        //declare variables
        int num;
        int tens;
        int units;
        int reversedNum;
        //input
        Console.WriteLine("Nhap so nguyen duong co 2 chu so");
        int.TryParse(Console.ReadLine(), out num);
        //processing
        if (num <= 10 || num > 99)
        {
            Console.WriteLine("Vui long nhap dung yeu cau");
            return;
        }
        tens = num / 10;
        units = num % 10;
        reversedNum = units * 10 + tens;
        //output
        Console.WriteLine($"So dao nguoc {reversedNum}");
    }
}
