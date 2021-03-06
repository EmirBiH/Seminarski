﻿using eFastFood_API.Models;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace eFastFood_API.Controllers
{
    public class KategorijaController : ApiController
    {
        private readonly eFastFoodEntitie _db = new eFastFoodEntitie();

        // GET: api/Kategorija
        public IHttpActionResult GetKategorija()
        {
            return Ok(_db.Kategorija.ToList());
        }

        // GET: api/Kategorija/5
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult GetKategorija(int id)
        {
            Kategorija kategorija = _db.Kategorija.Find(id);
            if (kategorija == null)
                return NotFound();

            return Ok(kategorija);
        }

        // PUT: api/Kategorija/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKategorija(int id, Kategorija kategorija)
        {
            if (id != kategorija.KategorijaID)
                return BadRequest();

            Kategorija k = _db.Kategorija.Find(id);

            if (k == null)
                return NotFound();

            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Kategorija
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult PostKategorija(Kategorija kategorija)
        {
            try
            {
                _db.Kategorija.Add(kategorija);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return CreatedAtRoute("DefaultApi", new { id = kategorija.KategorijaID }, kategorija);
        }

        // DELETE: api/Kategorija/5
        [HttpDelete]
        [ResponseType(typeof(Kategorija))]
        public IHttpActionResult DeleteKategorija(int id)
        {
            var kategorija = _db.Kategorija.Find(id);
            if (kategorija == null)
                return NotFound();
            int count = _db.GotoviProizvod.Where(x => x.KategorijaID == kategorija.KategorijaID).ToList().Count;
            if (count > 0)
                return BadRequest("Postoje proizvodi u ovoj kategoriji.");
            else
            {
                _db.Kategorija.Remove(kategorija);
                _db.SaveChanges();
            }
            return Ok(kategorija);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
