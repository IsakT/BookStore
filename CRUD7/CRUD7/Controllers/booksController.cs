using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CRUD7.Models;

namespace CRUD7.Controllers
{
    public class booksController : ApiController
    {
        private CRUD7Context db = new CRUD7Context();

        // GET api/books
        public IQueryable<books> Getbooks()
        {
            return db.books;
        }

        // GET api/books/5
        [ResponseType(typeof(books))]
        public async Task<IHttpActionResult> Getbooks(int id)
        {
            books books = await db.books.FindAsync(id);
            if (books == null)
            {
                return NotFound();
            }

            return Ok(books);
        }

        // PUT api/books/5
        public async Task<IHttpActionResult> Putbooks(int id, books books)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != books.Id)
            {
                return BadRequest();
            }

            db.Entry(books).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!booksExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/books
        [ResponseType(typeof(books))]
        public async Task<IHttpActionResult> Postbooks(books books)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.books.Add(books);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = books.Id }, books);
        }

        // DELETE api/books/5
        [ResponseType(typeof(books))]
        public async Task<IHttpActionResult> Deletebooks(int id)
        {
            books books = await db.books.FindAsync(id);
            if (books == null)
            {
                return NotFound();
            }

            db.books.Remove(books);
            await db.SaveChangesAsync();

            return Ok(books);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool booksExists(int id)
        {
            return db.books.Count(e => e.Id == id) > 0;
        }
    }
}