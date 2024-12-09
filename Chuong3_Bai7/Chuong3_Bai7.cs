namespace Chuong3_Bai7;
//CHUONG 3 BT7 : Nhap vao so giay, doi thanh gio:phut:giay
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai7
{
    static void Main(string[] args)
    {
        //declare variables
        int hour = 0;
        int minute = 0;
        int second = 0;
        int secondInput = 0;
        //input
        Console.WriteLine("Nhap vao so giay tu 0 den 83699");
        int.TryParse(Console.ReadLine(), out secondInput);
        //processing
        if (secondInput < 0 || secondInput < 86399)
        {
            Console.WriteLine("Vui long nhap theo yeu cau");
            return;
        }
        hour = secondInput / 3600;
        minute = (secondInput % 3600) / 60;
        second = secondInput % 60;
        //output
        Console.WriteLine($"Da doi so giay {secondInput} thanh {hour}:{minute}:{second}");



    }
}
