using HaroohiePals.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ErmiiSoft.NitroKart.CharacterKart;

public class KartAiParam
{
    public KartAiParamCourseEntry[] Entries { get; set; }

    public KartAiParam(byte[] data)
    {
        int courseCount = data.Length / KartAiParamCourseEntry.SIZE;

        using (var m = new MemoryStream(data))
        {
            var er = new EndianBinaryReaderEx(m, Endianness.LittleEndian);
            var entries = new List<KartAiParamCourseEntry>();

            for (int i = 0; i < courseCount; i++)
                entries.Add(new KartAiParamCourseEntry(er));

            Entries = entries.ToArray();
        }
    }

    public byte[] Write()
    {
        using (var m = new MemoryStream())
        {
            var ew = new EndianBinaryWriterEx(m, Endianness.LittleEndian);

            foreach (var entry in Entries)
                entry.Write(ew);

            return m.ToArray();
        }
    }
}
