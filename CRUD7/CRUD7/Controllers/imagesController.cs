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
    public class imagesController : ApiController
    {
        private CRUD7Context db = new CRUD7Context();

        // GET api/images
        public IQueryable<images> Getimages()
        {
            return db.images;
        }

        // GET api/images/5
        [ResponseType(typeof(images))]
        public async Task<IHttpActionResult> Getimages(int id)
        {
            images images = await db.images.FindAsync(id);
            if (images == null)
            {
                return NotFound();
            }

            return Ok(images);
        }

        // PUT api/images/5
        public async Task<IHttpActionResult> Putimages(int id, images images)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != images.Id)
            {
                return BadRequest();
            }

            db.Entry(images).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!imagesExists(id))
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

        // POST api/images
        [ResponseType(typeof(images))]
        public async Task<IHttpActionResult> Postimages(images images)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.images.Add(images);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = images.Id }, images);
        }

        // DELETE api/images/5
        [ResponseType(typeof(images))]
        public async Task<IHttpActionResult> Deleteimages(int id)
        {
            images images = await db.images.FindAsync(id);
            if (images == null)
            {
                return NotFound();
            }

            db.images.Remove(images);
            await db.SaveChangesAsync();

            return Ok(images);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool imagesExists(int id)
        {
            return db.images.Count(e => e.Id == id) > 0;
        }
    }
}