using Entities.Models;
using Entities.RequestFeature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        Task<PagedList<Book>> GetAllBooksAsync(BookParameters bookParameters,
            bool trankChanges);
        Task<Book> GetOneBookByIdAsync(int id, bool trankChanges);
        void CreateOneBook(Book book);
        void UpdateOneBook(Book book);
        void DeleteOneBook(Book book);
    }
}
