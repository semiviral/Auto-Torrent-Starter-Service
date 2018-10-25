﻿using System.IO;

namespace AutoTorrentStarterService.Model {
    public class AutoFileSystemWatcher {
        public AutoFileSystemWatcher(string directoryToWatch) {
            _directoryToWatch = directoryToWatch;
            _fileSystemWatcher = new FileSystemWatcher(_directoryToWatch);
            _fileSystemWatcher.Created += OnFileSystemWatcher_Created;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        #region MEMBERS

        private readonly string _directoryToWatch;
        private readonly FileSystemWatcher _fileSystemWatcher;

        #endregion

        #region EVENTS

        public event FileSystemEventHandler FileSystemWatcher_Created;

        private void OnFileSystemWatcher_Created(object sender, FileSystemEventArgs args) {
            FileSystemWatcher_Created?.Invoke(sender, args);
        }

        #endregion
    }
}