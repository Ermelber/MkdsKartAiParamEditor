using HaroohiePals.IO;

namespace ErmiiSoft.NitroKart.CharacterKart;

public class KartAiParamCourseEntry
{
    public const int SIZE = KartAiParamEntry.SIZE * 12;

    public KartAiParamEntry GrandPrix50cc = new();
    public KartAiParamEntry GrandPrix100cc = new();
    public KartAiParamEntry GrandPrix150cc = new();

    public KartAiParamEntry VersusEasy50cc = new();
    public KartAiParamEntry VersusNormal50cc = new();
    public KartAiParamEntry VersusHard50cc = new();

    public KartAiParamEntry VersusEasy100cc = new();
    public KartAiParamEntry VersusNormal100cc = new();
    public KartAiParamEntry VersusHard100cc = new();

    public KartAiParamEntry VersusEasy150cc = new();
    public KartAiParamEntry VersusNormal150cc = new();
    public KartAiParamEntry VersusHard150cc = new();

    public KartAiParamCourseEntry(EndianBinaryReaderEx er)
    {
        GrandPrix50cc = er.ReadObject<KartAiParamEntry>();
        GrandPrix100cc = er.ReadObject<KartAiParamEntry>();
        GrandPrix150cc = er.ReadObject<KartAiParamEntry>();

        VersusEasy50cc = er.ReadObject<KartAiParamEntry>();
        VersusNormal50cc = er.ReadObject<KartAiParamEntry>();
        VersusHard50cc = er.ReadObject<KartAiParamEntry>();

        VersusEasy100cc = er.ReadObject<KartAiParamEntry>();
        VersusNormal100cc = er.ReadObject<KartAiParamEntry>();
        VersusHard100cc = er.ReadObject<KartAiParamEntry>();

        VersusEasy150cc = er.ReadObject<KartAiParamEntry>();
        VersusNormal150cc = er.ReadObject<KartAiParamEntry>();
        VersusHard150cc = er.ReadObject<KartAiParamEntry>();
    }

    public void Write(EndianBinaryWriterEx ew)
    {
        ew.WriteObject(GrandPrix50cc);
        ew.WriteObject(GrandPrix100cc);
        ew.WriteObject(GrandPrix150cc);

        ew.WriteObject(VersusEasy50cc);
        ew.WriteObject(VersusNormal50cc);
        ew.WriteObject(VersusHard50cc);

        ew.WriteObject(VersusEasy100cc);
        ew.WriteObject(VersusNormal100cc);
        ew.WriteObject(VersusHard100cc);

        ew.WriteObject(VersusEasy150cc);
        ew.WriteObject(VersusNormal150cc);
        ew.WriteObject(VersusHard150cc);
    }
}
