using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMSample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMSample.ViewModel
{
    class MainVM : ObservableObject
    {
        private string? searchPhrase;
        private Book? selectedBook;
        private MainLogic logic;
        private bool bookManipulatingEnabled;

        public MainVM()
        {
            Books = new ObservableCollection<Book>();
            logic = new MainLogic();
            logic.LoadBooks(Books);
            ListedBooks = new ObservableCollection<Book>(Books);
            this.PropertyChanged += MainVM_PropertyChanged;
            CMD_AddBook = new RelayCommand(() => logic.AddBookDialog());
        }

        private void MainVM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(SelectedBook):
                    BookManipulatingEnabled = selectedBook != null;
                    break;
                case nameof(SearchPhrase):
                    logic.Search(searchPhrase, Books, ListedBooks);
                    break;
                default:
                    break;
            }
        }

        public ObservableCollection<Book> Books { get; }
        public ObservableCollection<Book> ListedBooks { get; }
        public string? SearchPhrase { get => searchPhrase; set => SetProperty(ref searchPhrase, value); }
        public Book? SelectedBook { get => selectedBook; set => SetProperty(ref selectedBook, value); }
        public ICommand CMD_AddBook { get; }
        public ICommand CMD_RemoveBook { get; }
        public ICommand CMD_EditBook { get; }
        public bool BookManipulatingEnabled { get => bookManipulatingEnabled; set => SetProperty(ref bookManipulatingEnabled, value); }
    }
}
