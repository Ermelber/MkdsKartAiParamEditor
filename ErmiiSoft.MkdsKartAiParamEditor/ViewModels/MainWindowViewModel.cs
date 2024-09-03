using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    public KartAiParamsEditorViewModel _kartAiParamsEditorViewModel = new();

    private readonly IStorageProvider? _storageProvider = null;

    public MainWindowViewModel()
    {
    }

    public MainWindowViewModel(IStorageProvider storageProvider)
    {
        _storageProvider = storageProvider;
    }

    [RelayCommand]
    public async Task OpenFileAsync()
    {
        if (_storageProvider is null)
            return;

        var options = new FilePickerOpenOptions
        {
            Title = "Open KartAIParam File",
            FileTypeFilter = [new("MKDS Kart AI Parameters") { Patterns = ["kartAIparam.bin"] }],
            AllowMultiple = false
        };

        if (await _storageProvider.OpenFilePickerAsync(options) is [var pickedFile])
        {
            
        }
    }
}
