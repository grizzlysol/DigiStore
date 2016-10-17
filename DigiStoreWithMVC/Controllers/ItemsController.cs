﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using DigiStoreWithMVC.Models;

namespace DigiStoreWithMVC.Controllers
{
    public class ItemsController : Controller
    {
        private DigiStoreDBModelContainer db = new DigiStoreDBModelContainer();

        // GET: Items
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var items = (from u in db.Users
                             where u.Email == User.Identity.Name
                             select u).FirstOrDefault().Items;
                return View(items.ToList());
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Price,Weight,Quantity")] Item item)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    (from u in db.Users where u.Email == User.Identity.Name select u).FirstOrDefault().Items.Add(item);
                    //db.Items.Add(item);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                //ViewBag.OrderId = new SelectList(db.Orders, "Id", "Id", item.OrderId);
                //ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", item.UserId);
                return View(item);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Item item = db.Items.Find(id);
                if (item == null)
                {
                    return HttpNotFound();
                }
                //ViewBag.OrderId = new SelectList(db.Orders, "Id", "Id", item.OrderId);
                //ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", item.UserId);
                return View(item);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Price,Weight,Quantity")] Item item)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(item).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                //ViewBag.OrderId = new SelectList(db.Orders, "Id", "Id", item.OrderId);
                //ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", item.UserId);
                return View(item);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Item item = db.Items.Find(id);
                if (item == null)
                {
                    return HttpNotFound();
                }
                return View(item);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = (from u in db.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                Item item = (from i in db.Items where i.Id == id select i).FirstOrDefault();
                db.Items.Attach(item);
                //db.Items.Remove(item);
                user.Items.Remove(item);
                //db.Users.Where(u => u.Email == user.Email).FirstOrDefault().Items.Remove(item);
                //db.Items.Remove(item);
                db.ChangeTracker.DetectChanges();
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index", "Home");
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