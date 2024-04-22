using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSample2
{
    partial class Author : ObservableObject
    {
        [ObservableProperty]
        string? name;
        [ObservableProperty]
        DateTime? birthDate;
    }
    partial class Book : ObservableObject
    {
        [ObservableProperty]
        string? title;
        [ObservableProperty]
        string? type;
        [ObservableProperty]
        Author? author;
        [ObservableProperty]
        DateTime? published;
    }
    internal partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();
        public ObservableCollection<Author> Authors { get; } = new ObservableCollection<Author>();
        [ObservableProperty]
        Book? selectedBook;
        [ObservableProperty]
        Author? selectedAuthor;


        [ObservableProperty]
        string? text;
        [RelayCommand]
        private void Message()
        {
            if (text != null)
            {
                MessageBox.Show(text);
            }
        }
        [RelayCommand]
        private void Add()
        {
            Items.Add(text);
        }
        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();
        
    }
}
