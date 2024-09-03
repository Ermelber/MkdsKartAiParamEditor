using CommunityToolkit.Mvvm.ComponentModel;
using ErmiiSoft.NitroKart.CharacterKart;
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


    public async Task LoadFileAsync(string path)
    {
        await Task.CompletedTask;
    }
}
