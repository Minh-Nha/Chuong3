namespace Chuong3_Bai9;
//CHUONG 3 BT9 : Đảo ngược 3 số
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai9
{
    static void Main(string[] args)
    {
        //declare variables
        int number = 0;
        int ones = 0;
        int tens = 0;
        int hundreds = 0;
        int reversed = 0;
        //input
        do
        {
            Console.WriteLine("Nhap so nguyen duong co 3 chu so: ");
            int.TryParse(Console.ReadLine(), out number);
            if(number < 100 || number > 999)
            {
                Console.WriteLine("Vui long nhap theo yeu cau");
            }
        }
        while (number < 100 || number > 999);
        //Processing
        ones = number % 10;     //Lấy hàng đơn vị
        number = number / 10;   //Loại hàng đơn vị
        tens = number % 10;     //Lấy hàng chục
        number /= 10;           //Loại hàng chục
        hundreds = number % 10; //Lấy hàng trăm
        //Đảo ngược
        reversed = ones * 100 + tens * 10 + hundreds;
        //Output
        Console.WriteLine($"So da dao nguoc {reversed}");

    }
}
