using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMSample.Model
{
    class Book : ObservableObject
    {
        public Book()
        {
            this.PropertyChanged += Book_PropertyChanged; ;
        }

        private void Book_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Title):
                case nameof(Author):
                case nameof(Publish):
                case nameof(Type):
                    CheckValidity();
                    break;
                default:
                    break;
            }
        }

        private void CheckValidity()
        {
            var validityStatus = !string.IsNullOrWhiteSpace(Author) && !string.IsNullOrWhiteSpace(Title) && !string.IsNullOrWhiteSpace(Type) && Publish.HasValue;
            if (validityStatus != isValid) IsValid = validityStatus;
        }

        const char separator = '|';
        private string? title;
        private string? author;
        private DateTime? publish;
        private string? type;
        private bool isValid;

        public string? Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public string? Author
        {
            get => author;
            set => SetProperty(ref author, value);
        }
        public DateTime? Publish
        {
            get => publish;
            set => SetProperty(ref publish, value);
        }
        public string? Type
        {
            get => type;
            set => SetProperty(ref type, value);
        }

        public bool IsValid
        {
            get { return isValid; }
            set { SetProperty(ref isValid, value); }
        }

        public string ToCsv()
        {
            var op = new StringBuilder();
            op.Append(Title).Append(separator)
              .Append(Author).Append(separator)
              .Append(Type).Append(separator)
              .Append(Publish);
            return op.ToString();
        }
        public static Book FromCsv(string line)
        {
            var splits = line.Split(separator);
            return new Book
            {
                Title = splits[0],
                Author = splits[1],
                Type = splits[2],
                Publish = DateTime.Parse(splits[3])
            };
        }
    }
}
