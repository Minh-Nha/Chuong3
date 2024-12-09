namespace Chuong3_Bai3;
//CHUONG 3 BT3 : Nhập điểm 3 môn Toán, Lý, Hoá tính điểm trung bình và in ra với 2 số lẻ thập phân
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai3
{
    static void Main(string[] args)
    {
        //declare variable
        double math, physics, chemistry;
        double meanScore;
        //input
        Console.WriteLine("nhap diem mon toan: ");
        double.TryParse(Console.ReadLine(), out math);
        Console.WriteLine("nhap diem mon ly: ");
        double.TryParse(Console.ReadLine(), out physics);
        Console.WriteLine("nhap diem mon hoa: ");
        double.TryParse(Console.ReadLine(), out chemistry);
        //processing
        meanScore = (math + physics + chemistry) / 3;
        //output
        Console.WriteLine($"Diem trung binh cua 3 mon Toan, Ly, Hoa la: {Math.Round(meanScore, 2)}" );
    }
}
