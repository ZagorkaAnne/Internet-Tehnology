using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab2_B.Models;

namespace Lab2_B.Controllers
{
    public class EventController : Controller
    {
     private static List<EventModel> events = new List<EventModel>();    

        // GET: Event
        public ActionResult Index()
        {
            return View(events);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
          var eventDetails=events.Find(x=>x.Id == id);
            if (eventDetails == null)
            {
                return HttpNotFound();
            }
            return View(eventDetails);
            }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
       
        public ActionResult Create(EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                if (events.Count == 0)
                {
                    eventModel.Id = 1;
                }
                else
                {
                    eventModel.Id = events.Max(x => x.Id)+1;
                }
                events.Add(eventModel);
                return RedirectToAction("Index");   
            }

            return View(eventModel);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
         var editEvent = events.Find(x => x.Id == id);
            if (editEvent == null)
            {
                return HttpNotFound();
            }
            return View(editEvent);
        }

        
        [HttpPost]
        public ActionResult Edit( EventModel eventModel)
        {
            if (ModelState.IsValid)
            {
            var newEvent=events.Find(x=>x.Id==eventModel.Id);
                if (newEvent != null)
                {
                    newEvent.Ime = eventModel.Ime;
                    newEvent.Lokacija = eventModel.Lokacija;
                }
                return RedirectToAction("Index");
            }
            return View(eventModel);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            var eventToDelete=events.Find(x => x.Id == id);
            if (eventToDelete == null)
            {
                return HttpNotFound();
            }
            events.Remove(eventToDelete);
            return RedirectToAction("Index");
        }

        

        
    }
}
