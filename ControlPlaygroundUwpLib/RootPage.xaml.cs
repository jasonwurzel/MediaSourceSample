using System.Collections.Generic;
using ClassLibraryStandard;

namespace ControlPlaygroundUwpLib
{
    public sealed partial class RootPage
    {
        public RootPage()
        {
            InitializeComponent();

            Loaded += (_, __) =>
            {
                var files = Dummy?.EnumerateFiles(@"C:\Windows");
                TheListView.ItemsSource = files;
            };
        }

        public IDummyFromNetCore Dummy { get; set; }
    }
}
