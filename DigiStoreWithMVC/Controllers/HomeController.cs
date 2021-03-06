﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigiStoreWithMVC.Models;
using System.Data.Entity;
using System.Net;

namespace DigiStoreWithMVC.Controllers
{
    public class HomeController : Controller
    {
        private DigiStoreDBModelContainer db = new DigiStoreDBModelContainer();

        public ActionResult Index()
        {
            StoreListingViewModel slvm = new StoreListingViewModel();
            slvm.curUser = ModelHelpers.GetCurrentUser(db);
            slvm.Stores = ModelHelpers.GetStores(db);

            if (slvm.curUser == null)
            {
                return View("Index", slvm);
            }

            return View("Index", slvm);
        }

        public ActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Contact(HomeViewModels model)
        {
            if (ModelState.IsValid)
            {
                using (DigiStoreDBModelContainer db = new DigiStoreDBModelContainer())
                {
                    //messing with this for the time being
                    Review newReview = db.Reviews.Create();
                    newReview.Id = db.Reviews.Count();
                    if(model.ReviewText != null)
                        newReview.ReviewText = model.ReviewText;
                    newReview.Rating = 0;
                    newReview.Date = DateTime.Now;
                    newReview.ReviewerName = "digistore@gmail.com";
                    db.Reviews.Add(newReview);
                    db.SaveChanges();
                    ViewBag.Message = "Review Submitted! Thanks!";
                    return View();
                }
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Map(string inputSearch)
        {
            List<User> users = (from u in db.Users
                                where u.UserName.ToLower().Contains(inputSearch.ToLower())
                                select u).ToList();
            if (users != null)
            {
                ViewData["users"] = users;
            }

            return PartialView("_MapResults");
        }

        [HttpPost]
        public ActionResult GoogleSearch(string inputSearch, string searchOptions)
        {
            if (searchOptions != null)
            {
                if (searchOptions.ToLower().Equals("store"))
                {
                    List<Store> stores = (from s in db.Stores
                                          where s.Name.ToLower().Contains(inputSearch.ToLower())
                                          select s).ToList();

                    return PartialView("_GoogleResultsStores", stores);
                }
                else
                {
                    List<Item> items = (from i in db.Items
                                        where i.Name.ToLower().Contains(inputSearch.ToLower())
                                        && i.Deleted.Value != true
                                        orderby i.Price ascending
                                        select i).ToList();
                    return PartialView("_GoogleResultsItems", items);
                }
            }
            else
                return new EmptyResult();
        }

        public PartialViewResult _StoreImagesWithLinks(IEnumerable<Store> store)
        {
            return PartialView("_StoreImagesWithLinks");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();

            base.Dispose(disposing);
        }
    }
}