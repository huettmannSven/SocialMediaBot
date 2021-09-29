using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsSocialMediaNotifier.Bots
{
    class FolderOberserver
    {
        public void Watcher(string folder)
        {
            using var watcher = new FileSystemWatcher(folder);


            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastWrite;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.EnableRaisingEvents = true;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
        }

        
    }
}
