using System.IO;
using System.Windows;
using System.Windows.Controls;



namespace FileManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void sortFolder_Click(object sender, RoutedEventArgs e)
        {
            content.Children.Clear();
            Events events = new Events();
            Button sortBrowseButton = new Button
            {
                Width = 80,
                Height = 38,
                Content = "Browse",
                Background = header.Background,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(0, 30, 100, 0),
            };
            Button sortButton = new Button
            {
                Width = 80,
                Height = 38,
                Content = "Sort",
                Background = header.Background,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(0, 100, 100, 0),
            };

            TextBox sortFolderWayBox = new TextBox
            {
                Width = 400,
                Height = 40,
                FontSize = 30,
                Margin = new Thickness(0, -235, 150, 0),
            };
            sortBrowseButton.Click += (s, e) =>
            {
                events.FolderBrowser(ref sortFolderWayBox);
            };
            sortButton.Click += (s, e) =>
            {
                string newFolderName = "";

                string[] files = Directory.GetFiles(sortFolderWayBox.Text);
                foreach (string file in files)
                {
                    FileInfo f = new FileInfo(file);
                    events.Move(file, sortFolderWayBox, ref newFolderName);
                    f.MoveTo($"{sortFolderWayBox.Text}\\{newFolderName}\\{f.Name}");
                }
                MessageBox.Show("File is moved successfuly!");
            };
            content.Children.Add(sortBrowseButton);
            content.Children.Add(sortFolderWayBox);
            content.Children.Add(sortButton);
        }


    }
}
