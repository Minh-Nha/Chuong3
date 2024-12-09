namespace Chuong3_Bai10;
//CHUONG 3 BT10 : Tính khoảng cách giữa 2 toạ độ
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai10
{
    static void Main(string[] args)
    {
        //declare variables
        double x1, y1, x2, y2;
        //input
        Console.WriteLine("Nhap toa do x1, y1");
        double.TryParse(Console.ReadLine(), out x1);
        double.TryParse(Console.ReadLine(), out y1);
        Console.WriteLine("Nhap toa do x2, y2");
        double.TryParse(Console.ReadLine(), out x2);
        double.TryParse(Console.ReadLine(), out y2);
        //processing
        double distance = Math.Sqrt(Math.Pow(y2 - y1, 2)+ Math.Pow(x2 - x1, 2));
        //Output
        Console.WriteLine($"Khoang cach giua 2 diem toa do : {Math.Round(distance,2)}");

    }
}
