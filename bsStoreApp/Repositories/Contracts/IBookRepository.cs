using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        IQueryable<Book> GetAllBooks(bool trankChanges);
        IQueryable<Book> GetAllBookById(int id, bool trankChanges);
        void CreateOneBook(Book book);
        void UpdateOneBook(Book book);
        void DeleteOneBook(Book book);
    }
}
