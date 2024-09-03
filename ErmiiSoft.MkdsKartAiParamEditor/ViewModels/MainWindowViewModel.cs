using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO;
using System.Threading.Tasks;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public const string DEFAULT_FILE_NAME = "kartAIparam.bin";
    public const string BIN_FILE_PATTERN = "*.bin";
    public const string ALL_FILES_PATTERN = "*.bin";

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
            FileTypeFilter = 
            [
                new("MKDS Kart AI Parameters") { Patterns = [DEFAULT_FILE_NAME] },
                new("Binary files") { Patterns = [BIN_FILE_PATTERN] },
                new("All files") { Patterns = [ALL_FILES_PATTERN] }
            ],
            AllowMultiple = false
        };

        if (await _storageProvider.OpenFilePickerAsync(options) is [var pickedFile])
        {
            await KartAiParamsEditorViewModel.LoadFileAsync(pickedFile.Path.AbsolutePath);
        }
    }

    [RelayCommand]
    public async Task SaveFileAsync()
    {
        if (_storageProvider is null || !KartAiParamsEditorViewModel.IsFileLoaded)
            return;

        var options = new FilePickerSaveOptions
        {
            Title = "Save KartAIParam File",
            SuggestedFileName = DEFAULT_FILE_NAME
        };

        if (await _storageProvider.SaveFilePickerAsync(options) is var pickedFile && pickedFile is not null)
        {
            await KartAiParamsEditorViewModel.SaveFileAsync(pickedFile.Path.AbsolutePath);
        }
    }
}
