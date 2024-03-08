using FrameSample.View;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FrameSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainPage = new MainPage();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainPage.BTN_CreateBook.Click += BTN_CreateBook_Click;
            MainFrame.Content = mainPage;
        }

        private void BTN_CreateBook_Click(object sender, RoutedEventArgs e)
        {
            bookEditorPage = new BookEditorPage();
            bookEditorPage.BTN_Back.Click += BTN_BookEditor_Back_Click;
            bookEditorPage.BTN_Save.Click += BTN_BookEditor_Back_Click;
            bookEditorPage.BTN_SelectAuthor.Click += BTN_BookEditor_SelectAuthor_Click;
            MainFrame.Content = bookEditorPage;
        }

        private void BTN_BookEditor_SelectAuthor_Click(object sender, RoutedEventArgs e)
        {
            var page = new AuthorEditorPage();
            MainFrame.Content = page;
        }

        private void BTN_BookEditor_Back_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = mainPage;
        }

        private MainPage mainPage;
        private BookEditorPage bookEditorPage;
        private void PageSwitchClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var name = ((Type)button.CommandParameter).UnderlyingSystemType.Name;
            Page page;
            switch (name)
            {
                case nameof(MainPage): page = new MainPage(); break;
                case nameof(AuthorEditorPage): page = new AuthorEditorPage(); break;
                case nameof(BookEditorPage): page = new BookEditorPage(); break;
                default: throw new InvalidProgramException();
            }
            MainFrame.Content = page;
        }
    }
}