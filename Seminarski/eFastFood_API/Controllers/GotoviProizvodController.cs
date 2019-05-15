﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eFastFood_API.Models;

namespace eFastFood_API.Controllers
{
    public class GotoviProizvodController : ApiController
    {
        private eFastFoodEntitie _db = new eFastFoodEntitie();

        // GET: api/GotoviProizvod
        public IEnumerable<GotoviProizvod> GetGotoviProizvod()
        {
            return _db.GotoviProizvod.ToList();
        }

        // GET: api/GotoviProizvod/5
        [ResponseType(typeof(GotoviProizvod))]
        public IHttpActionResult GetGotoviProizvod(int id)
        {
            GotoviProizvod gotoviProizvod = _db.GotoviProizvod.Find(id);
            if (gotoviProizvod == null)
            {
                return NotFound();
            }

            return Ok(gotoviProizvod);
        }

        // PUT: api/GotoviProizvod/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGotoviProizvod(int id, GotoviProizvod gotoviProizvod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gotoviProizvod.GotoviProizvodID)
            {
                return BadRequest();
            }

            GotoviProizvod gp = _db.GotoviProizvod.Find(id);

            gp.KategorijaID = gotoviProizvod.KategorijaID;
            gp.GotoviProizvodID = gotoviProizvod.GotoviProizvodID;
            gp.VrijemePripreme = gotoviProizvod.VrijemePripreme;
            gp.Slika = gotoviProizvod.Slika;
            gp.SlikaUmanjeno = gotoviProizvod.SlikaUmanjeno;
            gp.Opis = gotoviProizvod.Opis;
            gp.Naziv = gotoviProizvod.Naziv;

            try
            {
                _db.SaveChanges();
            }
            catch (Exception)
            {
                BadRequest();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GotoviProizvod
        [ResponseType(typeof(GotoviProizvod))]
        public IHttpActionResult PostGotoviProizvod(GotoviProizvod gotoviProizvod)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.GotoviProizvod.Add(gotoviProizvod);
            _db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = gotoviProizvod.GotoviProizvodID }, gotoviProizvod);
        }

        // DELETE: api/GotoviProizvod/5
        [ResponseType(typeof(GotoviProizvod))]
        public IHttpActionResult DeleteGotoviProizvod(int id)
        {
            GotoviProizvod gotoviProizvod = _db.GotoviProizvod.Find(id);
            if (gotoviProizvod == null)
            {
                return NotFound();
            }

            _db.GotoviProizvod.Remove(gotoviProizvod);
            _db.SaveChanges();

            return Ok(gotoviProizvod);
        }


        #region Helpers
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GotoviProizvodExists(int id)
        {
            return _db.GotoviProizvod.Count(e => e.GotoviProizvodID == id) > 0;
        }
        #endregion
    }
}