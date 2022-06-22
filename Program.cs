using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "21.11.4414";
            mhs.nama = "Akmal Rafi Fadhillah";
            mhs.email = "akmal.mil@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data");
            Console.WriteLine("1. Json ");
            Console.WriteLine("2. XML ");
            Console.WriteLine("3. Csv\n ");

            Console.Write("Nomor Format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert;

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();
            convert.Convert(mhs);
            Console.ReadKey();
        }
    }
}
