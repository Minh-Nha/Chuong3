//CHUONG 3 BT2 : Nhập vào độ F, đổi ra độ C
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
namespace Chuong3_Bai2;

internal class Chuong3_Bai2
{
    static void Main(string[] args)
    {
        //declare variables
        double fahrenheit;
        double celsius;
        //input
        Console.WriteLine("Nhap vao do F: ");
        double.TryParse(Console.ReadLine(), out fahrenheit);
        //processing
        celsius = ((fahrenheit - 32) * 5) / 9;
        //output
        Console.WriteLine($"Chuyen tu do F: {fahrenheit} sang do C: {Math.Round(celsius, 1)}");
    }
}
