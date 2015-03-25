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
    public class genresController : ApiController
    {
        private CRUD7Context db = new CRUD7Context();

        // GET api/genres
        public IQueryable<genres> Getgenres()
        {
            return db.genres;
        }

        // GET api/genres/5
        [ResponseType(typeof(genres))]
        public async Task<IHttpActionResult> Getgenres(int id)
        {
            genres genres = await db.genres.FindAsync(id);
            if (genres == null)
            {
                return NotFound();
            }

            return Ok(genres);
        }

        // PUT api/genres/5
        public async Task<IHttpActionResult> Putgenres(int id, genres genres)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != genres.Id)
            {
                return BadRequest();
            }

            db.Entry(genres).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!genresExists(id))
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

        // POST api/genres
        [ResponseType(typeof(genres))]
        public async Task<IHttpActionResult> Postgenres(genres genres)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.genres.Add(genres);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = genres.Id }, genres);
        }

        // DELETE api/genres/5
        [ResponseType(typeof(genres))]
        public async Task<IHttpActionResult> Deletegenres(int id)
        {
            genres genres = await db.genres.FindAsync(id);
            if (genres == null)
            {
                return NotFound();
            }

            db.genres.Remove(genres);
            await db.SaveChangesAsync();

            return Ok(genres);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool genresExists(int id)
        {
            return db.genres.Count(e => e.Id == id) > 0;
        }
    }
}