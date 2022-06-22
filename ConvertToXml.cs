﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace LatihanPolymorphism2
{
    internal class ConvertToXml : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            using (StringWriter writer = new StringWriter())
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
                    serializer.Serialize(writer, mhs);

                    string xml = writer.ToString();

                    Console.WriteLine("Hasil Konversi Ke XML:\n");
                    Console.WriteLine(xml);

                };
        }
    }
}
