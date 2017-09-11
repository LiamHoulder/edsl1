using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EDSL_API.Models;

namespace EDSL_API.Controllers
{
    public class leaguesController : ApiController
    {
        private EDSL1DatabaseEntities db = new EDSL1DatabaseEntities();

        // GET: api/leagues
        public IQueryable<league> Getleagues()
        {
            return db.leagues;
        }

        // GET: api/leagues/5
        [ResponseType(typeof(league))]
        public IHttpActionResult Getleague(string id)
        {
            league league = db.leagues.Find(id);
            if (league == null)
            {
                return NotFound();
            }

            return Ok(league);
        }

        // PUT: api/leagues/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putleague(string id, league league)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != league.leagueName)
            {
                return BadRequest();
            }

            db.Entry(league).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!leagueExists(id))
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

        // POST: api/leagues
        [ResponseType(typeof(league))]
        public IHttpActionResult Postleague(league league)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.leagues.Add(league);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (leagueExists(league.leagueName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = league.leagueName }, league);
        }

        // DELETE: api/leagues/5
        [ResponseType(typeof(league))]
        public IHttpActionResult Deleteleague(string id)
        {
            league league = db.leagues.Find(id);
            if (league == null)
            {
                return NotFound();
            }

            db.leagues.Remove(league);
            db.SaveChanges();

            return Ok(league);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool leagueExists(string id)
        {
            return db.leagues.Count(e => e.leagueName == id) > 0;
        }
    }
}