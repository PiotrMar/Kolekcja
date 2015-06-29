﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kolekcja.Models;

namespace Kolekcja.Controllers
{
    public class ElementyController : Controller
    {
        private ElementyDBContext db = new ElementyDBContext();

        // GET: Elementy
        public ActionResult Index()
        {
            return View(db.Elementy.ToList());
        }

        // GET: Elementy/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Element element = db.Elementy.Find(id);
            if (element == null)
            {
                return HttpNotFound();
            }
            return View(element);
        }

        // GET: Elementy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Elementy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Tytul,RokWydania,Gatunek,Rodzaj")] Element element)
        {
            if (ModelState.IsValid)
            {
                db.Elementy.Add(element);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(element);
        }

        // GET: Elementy/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Element element = db.Elementy.Find(id);
            if (element == null)
            {
                return HttpNotFound();
            }
            return View(element);
        }

        // POST: Elementy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Tytul,RokWydania,Gatunek,Rodzaj")] Element element)
        {
            if (ModelState.IsValid)
            {
                db.Entry(element).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(element);
        }

        // GET: Elementy/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Element element = db.Elementy.Find(id);
            if (element == null)
            {
                return HttpNotFound();
            }
            return View(element);
        }

        // POST: Elementy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Element element = db.Elementy.Find(id);
            db.Elementy.Remove(element);
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
