namespace Chuong3_Bai8;
//CHUONG 3 BT8 : Nhập số nguyên dương, nếu chẳng thì +1, nếu lẻ thì -1
//Date 12/10/2024
//Name : Nguyễn Ngọc Minh Nhã
internal class Chuong3_Bai8
{
    static void Main(string[] args)
    {
        //declare variables 
        int num;
        //input
        Console.WriteLine("Nhap vao so nguyen duong: ");
        int.TryParse(Console.ReadLine(), out num);
        //processing
        if (num <= 0)
        {
            Console.WriteLine("Vui long nhap theo yeu cau");
            return;
        }
        if (num % 2 == 0)
        {
            ++num;
            Console.WriteLine(num);
        }
        else { 
            --num;
            Console.WriteLine(num);
        }
    }
}
