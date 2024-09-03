using CommunityToolkit.Mvvm.ComponentModel;

namespace ErmiiSoft.MkdsKartAiParamEditor.ViewModels;

public class ViewModelBase : ObservableObject
{
    protected bool IsInitialized { get; set; } = false;
}
