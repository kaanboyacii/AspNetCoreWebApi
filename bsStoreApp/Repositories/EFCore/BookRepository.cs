using Entities.Models;
using Entities.RequestFeature;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {
            
        }

        public void CreateOneBook(Book book) => Create(book);
        public void DeleteOneBook(Book book) => Delete(book);

        public async Task<Book> GetOneBookByIdAsync(int id, bool trankChanges) =>
            await FindByCondition(b => b.Id.Equals(id), trankChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<Book>> GetAllBooksAsync(BookParameters bookParameters ,bool trankChanges) =>
            await FindAll(trankChanges)
            .OrderBy(b => b.Id)
            .Skip((bookParameters.PageNumber-1)*bookParameters.PageSize)
            .Take(bookParameters.PageSize)
            .ToListAsync();

        public void UpdateOneBook(Book book) => Update(book);
}
}
