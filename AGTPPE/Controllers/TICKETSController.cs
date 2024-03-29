﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AGTPPE.Models;

namespace AGTPPE.Controllers
{
    public class TICKETSController : Controller
    {
        private KNInfoEntities db = new KNInfoEntities();

        // GET: TICKETS
        public ActionResult Index()
        {
            var tICKETS = db.TICKETS.Include(t => t.MATERIEL).Include(t => t.UTILISATEUR);
            return View(tICKETS.ToList());
        }

        

        // GET: TICKETS/Create
        public ActionResult Create()
        {
            ViewBag.numeroSerieMateriel = new SelectList(db.MATERIEL, "numeroSerieMateriel", "emplacementMateriel");
            ViewBag.idUtilisateur = new SelectList(db.UTILISATEUR, "idUtilisateur", "nomUtilisateur");
            
            return View();
        }

        // POST: TICKETS/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTickets,emplacementMaterielTicket,typeMaterielTicket,niveauUrgenceTicket,descriptionIncident,dateCreationTicket,dateClotureTicket,idUtilisateur,numeroSerieMateriel")] TICKETS tICKETS)
        {
            if (ModelState.IsValid)
            {
                tICKETS.dateCreationTicket = DateTime.Now; //enregistrement dans la base de données sous forme de date et heure
                db.TICKETS.Add(tICKETS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.numeroSerieMateriel = new SelectList(db.MATERIEL, "numeroSerieMateriel", "emplacementMateriel", tICKETS.numeroSerieMateriel);
            ViewBag.idUtilisateur = new SelectList(db.UTILISATEUR, "idUtilisateur", "nomUtilisateur", tICKETS.idUtilisateur);
            return View(tICKETS);
        }

       

       

        // GET: TICKETS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TICKETS tICKETS = db.TICKETS.Find(id);
            if (tICKETS == null)
            {
                return HttpNotFound();
            }
            return View(tICKETS);
        }

        // POST: TICKETS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TICKETS tICKETS = db.TICKETS.Find(id);
            db.TICKETS.Remove(tICKETS);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
