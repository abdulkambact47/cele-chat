using cele_chat.Models;
using CommunityToolkit.Mvvm.Input;

namespace cele_chat.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}