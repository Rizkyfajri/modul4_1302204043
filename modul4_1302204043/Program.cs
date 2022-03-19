// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Nim : 1302204043
//NIM berakhiran 3, 4 atau 5: tipe data input double

namespace modul4_1302204043
{
    public class Program
    {
        static void Main()
        {
            //Console.WriteLine("Masukan NIM : ");
            //double A = Convert.ToDouble(Console.ReadLine());
            //double B = Convert.ToDouble(Console.ReadLine());
            //double C = Convert.ToDouble(Console.ReadLine());

            double A = 13;//memberi isi variable
            double B = 44;
            double C = 43;

            SimpleDataBase<double> DB = new SimpleDataBase<double>(); //inisialisasi SimpleDataBase ke DB

            DB.AddNewData(A); //mengisi DB method AddNewData
            DB.AddNewData(B);
            DB.AddNewData(C);

            DB.PrintAllData(); //meng print nilai yang disimpan
        }
    }
}