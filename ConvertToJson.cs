using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    internal class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);
            Console.WriteLine("Hasil Konversi ke json: \n");
            Console.WriteLine(json);
        }
    }
}
