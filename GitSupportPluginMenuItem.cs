using FMT.PluginInterfaces;
using System.Windows;

namespace GitSupportAppPlugin
{
    public class GitSupportPluginMenuItem : IEditorTopMenuItem
    {
        public string HeaderText => "GitHub";
        public string IconType => "Github";
        public Action SelectedAction => () =>
        {
            MessageBox.Show("Hello from GitSupport");
        };

        public bool IsVisible => false;

        public bool IsEnabled => false;
    }
}
