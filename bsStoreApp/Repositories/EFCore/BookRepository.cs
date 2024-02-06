using Entities.Models;
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

        public Book GetOneBookById(int id, bool trankChanges) =>
            FindByCondition(b => b.Id.Equals(id), trankChanges)
            .SingleOrDefault();

        public IQueryable<Book> GetAllBooks(bool trankChanges) =>
            FindAll(trankChanges)
            .OrderBy(b=>b.Id);

        public void UpdateOneBook(Book book) => Update(book);
}
}
