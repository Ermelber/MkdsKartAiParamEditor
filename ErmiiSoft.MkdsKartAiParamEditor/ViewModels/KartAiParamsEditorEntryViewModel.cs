using ErmiiSoft.NitroKart.CharacterKart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class KartAiParamsEditorEntryViewModel : ViewModelBase
{
    public uint RivalAggressiveness { get; set; }
    public uint GroupControl { get; set; }
    public uint CpuRubberBanding { get; set; }
}
