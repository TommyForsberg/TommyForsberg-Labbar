using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AutoMapper;
using System.Linq;

namespace BooksProjekt.Models.Entities
{
    public partial class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public void AddBookToDB(CreateBookVM model)
        {
            var newBook = Mapper.Map<Book>(model);
            Book.Add(newBook);
            SaveChanges();
        }
        internal ListBooksVM[] GetAllBooksVM()
        {
            return Book.Select(o => Mapper.Map<ListBooksVM>(o)).ToArray();

            //return Book.Select(o => new ListBooksVM
            //{
            //    IsAClassic = o.Pages > 200,
            //    Author = o.Author,
            //    Title = o.Title
            //}).ToArray();
        }

        internal CreateBookVM FetchSelectedBookVM(int id)
        {
            return Mapper.Map<CreateBookVM>(Book.Single(o => o.Id.Equals(id)));
        }

        internal void AddUpdatedBookToDB(int id, CreateBookVM model)
        {
            var selectedBook = Book.Single(o => o.Id == id);
            selectedBook.Author = model.Author;
            selectedBook.Pages = model.Pages;
            selectedBook.Title = model.Title;
            SaveChanges();
        }
    }
}