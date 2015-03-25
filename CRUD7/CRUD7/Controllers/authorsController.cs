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
    public class authorsController : ApiController
    {
        private CRUD7Context db = new CRUD7Context();

        // GET api/authors
        public IQueryable<authors> Getauthors()
        {
            return db.authors;
        }

        // GET api/authors/5
        [ResponseType(typeof(authors))]
        public async Task<IHttpActionResult> Getauthors(int id)
        {
            authors authors = await db.authors.FindAsync(id);
            if (authors == null)
            {
                return NotFound();
            }

            return Ok(authors);
        }

        // PUT api/authors/5
        public async Task<IHttpActionResult> Putauthors(int id, authors authors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != authors.Id)
            {
                return BadRequest();
            }

            db.Entry(authors).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!authorsExists(id))
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

        // POST api/authors
        [ResponseType(typeof(authors))]
        public async Task<IHttpActionResult> Postauthors(authors authors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.authors.Add(authors);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = authors.Id }, authors);
        }

        // DELETE api/authors/5
        [ResponseType(typeof(authors))]
        public async Task<IHttpActionResult> Deleteauthors(int id)
        {
            authors authors = await db.authors.FindAsync(id);
            if (authors == null)
            {
                return NotFound();
            }

            db.authors.Remove(authors);
            await db.SaveChangesAsync();

            return Ok(authors);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool authorsExists(int id)
        {
            return db.authors.Count(e => e.Id == id) > 0;
        }
    }
}