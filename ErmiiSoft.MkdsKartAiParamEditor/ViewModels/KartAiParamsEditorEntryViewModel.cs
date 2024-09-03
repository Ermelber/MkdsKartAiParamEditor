using CommunityToolkit.Mvvm.ComponentModel;
using ErmiiSoft.NitroKart.CharacterKart;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public partial class KartAiParamsEditorEntryViewModel : ViewModelBase
{
    private KartAiParamEntry _entry = new();

    [ObservableProperty]
    private double _rivalAggressiveness;
    [ObservableProperty]
    private double _groupControl;
    [ObservableProperty]
    private double _cpuRubberBanding;
    [ObservableProperty]
    private bool _isReadOnly;

    public KartAiParamsEditorEntryViewModel()
    {
        IsReadOnly = true;
        PropertyChanged += OnPropertyChanged;
    }

    public void SetEntry(KartAiParamEntry entry)
    {
        _entry = entry;

        IsInitialized = false;
        IsReadOnly = true;

        RivalAggressiveness = entry.RivalAggressiveness;
        GroupControl = entry.GroupControl;
        CpuRubberBanding = entry.CpuRubberBanding;

        IsReadOnly = false;
        IsInitialized = true;
    }

    private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (!IsInitialized)
            return;

        if (e.PropertyName == nameof(RivalAggressiveness))
            _entry.RivalAggressiveness = RivalAggressiveness;

        if (e.PropertyName == nameof(GroupControl))
            _entry.GroupControl = GroupControl;

        if (e.PropertyName == nameof(CpuRubberBanding))
            _entry.CpuRubberBanding = CpuRubberBanding;
    }
}
