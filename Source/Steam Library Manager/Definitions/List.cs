﻿using System.Collections.Generic;
using System.Globalization;
using System.Windows.Media;

namespace Steam_Library_Manager.Definitions
{
    // Our Library and Game definitions exists there
    public class List
    {
        // Make a new list for Library details
        public static Framework.AsyncObservableCollection<Library> Libraries = new Framework.AsyncObservableCollection<Library>();

        public static Framework.AsyncObservableCollection<contextMenu> contextMenuItems = new Framework.AsyncObservableCollection<contextMenu>();

        public static List<Language> Languages = new List<Language>();

        public class contextMenu
        {
            public bool IsVisible { get; set; } = true;
            public string Header { get; set; }
            public string Action { get; set; }
            public FontAwesome.WPF.FontAwesomeIcon Icon { get; set; } = FontAwesome.WPF.FontAwesomeIcon.None;
            public Brush IconColor { get; set; }
            public bool shownToBackup { get; set; }
            public bool shownToCompressed { get; set; }
            public bool IsSeparator { get; set; }
        }

        public class Language
        {
            public string shortName { get; set; }
            public string displayName { get; set; }

            public CultureInfo culture;
            public string externalFileName;
            public bool isDefault, requiresExternalFile;
        }

    }
}
