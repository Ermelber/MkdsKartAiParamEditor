using CommunityToolkit.Mvvm.ComponentModel;
using ErmiiSoft.NitroKart.CharacterKart;
using System.IO;
using System.Threading.Tasks;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class KartAiParamsEditorViewModel : ViewModelBase
{
    [ObservableProperty]
    public KartAiParamsEditorEntryViewModel _entryViewModelGrandPrix50cc = new();
    [ObservableProperty]
    public KartAiParamsEditorEntryViewModel _entryViewModelGrandPrix100cc = new();
    [ObservableProperty]
    public KartAiParamsEditorEntryViewModel _entryViewModelGrandPrix150cc = new();

    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusEasy50cc = new();
    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusNormal50cc = new();
    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusHard50cc = new();

    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusEasy100cc = new();
    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusNormal100cc = new();
    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusHard100cc = new();

    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusEasy150cc = new();
    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusNormal150cc = new();
    [ObservableProperty] 
    public KartAiParamsEditorEntryViewModel _entryViewModelVersusHard150cc = new();

    private KartAiParam? _kartAiParams;

    public async Task LoadFileAsync(string path)
    {
        _kartAiParams = new KartAiParam(await File.ReadAllBytesAsync(path));

        await Task.CompletedTask;
    }
}
