using FrostySdk.Frostbite.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GitSupportAppPlugin
{
    public class GitSupportPluginMenuItem : IEditorTopMenuItem
    {
        public string HeaderText => "GitHub";
        public string IconType => "Github";
        public Action SelectedAction => () =>
        {
            MessageBox.Show("Yo from GitHubSupport");
        };
    }
}
