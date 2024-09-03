using HaroohiePals.IO;
using HaroohiePals.IO.Serialization;

namespace ErmiiSoft.NitroKart.CharacterKart;

public class KartAiParamEntry
{
    public const int SIZE = 12;

    [Fx32]
    public double RivalAggressiveness;
    [Fx32]
    public double GroupControl;
    [Fx32]
    public double CpuRubberBanding;
}