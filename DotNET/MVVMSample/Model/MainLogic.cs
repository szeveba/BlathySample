using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace MVVMSample.Model
{
    class MainLogic
    {
        const string bookDbPath = "books.csv";
        public void SaveBooks(IEnumerable<Book> books)
        {
            var op = new List<string>();
            foreach (var book in books)
            {
                op.Add(book.ToCsv());
            }
            File.WriteAllLines(bookDbPath, op);
        }
        public void LoadBooks(ICollection<Book> books)
        {
            if (File.Exists(bookDbPath))
            {
                var lines = File.ReadAllLines(bookDbPath);
                foreach (var line in lines)
                {
                    books.Add(Book.FromCsv(line));
                }
            }
            else
            {
                File.Create(bookDbPath);
            }
        }

        internal void AddBookDialog()
        {
            throw new NotImplementedException();
        }

        internal void Search(string? searchPhrase, IEnumerable<Book> allBooks, ICollection<Book> listedBooks)
        {
            listedBooks.Clear();
            if (searchPhrase != null)
            {
                var keyword = searchPhrase.ToLower();
                foreach (var item in allBooks)
                {
                    if (item.Title!.ToLower().Contains(keyword)) listedBooks.Add(item);
                }
            }
            else
            {
                foreach (var item in allBooks)
                {
                    listedBooks.Add(item);
                }
            }
        }
    }
}
