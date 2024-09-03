using CommunityToolkit.Mvvm.ComponentModel;
using ErmiiSoft.NitroKart.CharacterKart;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class KartAiParamsEditorViewModel : ViewModelBase
{
    private const string COURSE_LIST_FILE_PATH = "CourseList.txt";

    public bool IsFileLoaded => _kartAiParam is not null;

    [ObservableProperty]
    private int _courseId = 0;
    [ObservableProperty]
    private bool _isReadOnly;
    [ObservableProperty]
    private List<string> _courseList = new();

    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelGrandPrix50cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelGrandPrix100cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelGrandPrix150cc = new();

    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusEasy50cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusNormal50cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusHard50cc = new();

    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusEasy100cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusNormal100cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusHard100cc = new();

    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusEasy150cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusNormal150cc = new();
    [ObservableProperty]
    private KartAiParamsEditorEntryViewModel _entryViewModelVersusHard150cc = new();

    private KartAiParam? _kartAiParam;

    public KartAiParamsEditorViewModel()
    {
        IsReadOnly = true;
        PropertyChanged += OnPropertyChanged;
    }

    public async Task LoadFileAsync(string path)
    {
        IsInitialized = false;
        IsReadOnly = true;

        _kartAiParam = new KartAiParam(await File.ReadAllBytesAsync(path));

        CourseId = 0;

        await LoadCourseListAsync(_kartAiParam.Entries.Length);

        LoadSelectedCourseEntries();

        IsReadOnly = false;
        IsInitialized = true;
    }

    private async Task LoadCourseListAsync(int length)
    {
        if (!File.Exists(COURSE_LIST_FILE_PATH))
            await File.WriteAllTextAsync(COURSE_LIST_FILE_PATH, Resources.Resources.DefaultCourseList);

        var textFile = await File.ReadAllLinesAsync(COURSE_LIST_FILE_PATH);

        CourseList = textFile.Take(length).Select((x, i) => $"{i + 1} - {x}").ToList();
    }

    public async Task SaveFileAsync(string path)
    {
        if (_kartAiParam is null)
            return;

        await File.WriteAllBytesAsync(path, _kartAiParam.Write());
    }
    
    public void LoadSelectedCourseEntries()
    {
        if (_kartAiParam is null)
            return;

        var courseEntry = _kartAiParam.Entries[CourseId];

        EntryViewModelGrandPrix50cc.SetEntry(courseEntry.GrandPrix50cc);
        EntryViewModelGrandPrix100cc.SetEntry(courseEntry.GrandPrix100cc);
        EntryViewModelGrandPrix150cc.SetEntry(courseEntry.GrandPrix150cc);

        EntryViewModelVersusEasy50cc.SetEntry(courseEntry.VersusEasy50cc);
        EntryViewModelVersusNormal50cc.SetEntry(courseEntry.VersusNormal50cc);
        EntryViewModelVersusHard50cc.SetEntry(courseEntry.VersusHard50cc);

        EntryViewModelVersusEasy100cc.SetEntry(courseEntry.VersusEasy100cc);
        EntryViewModelVersusNormal100cc.SetEntry(courseEntry.VersusNormal100cc);
        EntryViewModelVersusHard100cc.SetEntry(courseEntry.VersusHard100cc);

        EntryViewModelVersusEasy150cc.SetEntry(courseEntry.VersusEasy150cc);
        EntryViewModelVersusNormal150cc.SetEntry(courseEntry.VersusNormal150cc);
        EntryViewModelVersusHard150cc.SetEntry(courseEntry.VersusHard150cc);
    }

    private void OnPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (!IsInitialized)
            return;

        if (e.PropertyName == nameof(CourseId))
            LoadSelectedCourseEntries();
    }
}
