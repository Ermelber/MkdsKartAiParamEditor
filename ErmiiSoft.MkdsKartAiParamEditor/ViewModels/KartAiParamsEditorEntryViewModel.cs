using CommunityToolkit.Mvvm.ComponentModel;
using ErmiiSoft.NitroKart.CharacterKart;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class KartAiParamsEditorEntryViewModel : ViewModelBase
{
    [ObservableProperty]
    private KartAiParamEntry _entry = new();

    public double RivalAggressiveness
    {
        get => Entry.RivalAggressiveness; 
        set => Entry.RivalAggressiveness = value;
    }

    public double GroupControl
    {
        get => Entry.GroupControl; 
        set => Entry.GroupControl = value;
    }

    public double CpuRubberBanding
    {
        get => Entry.CpuRubberBanding; 
        set => Entry.CpuRubberBanding = value;
    }
}
