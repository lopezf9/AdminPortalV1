using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminPortalV1.Models;

namespace AdminPortalV1.Controllers
{
    public class HotelsController : Controller
    {
        private GCAdminv23Entities db = new GCAdminv23Entities();

        // GET: Hotels
        public ActionResult Index()
        {
            var tblHotels = db.tblHotels.Include(t => t.tblHotelAddress).Include(t => t.tblPM).Include(t => t.tblTimezone);
            return View(tblHotels.ToList());
        }

        // GET: Hotels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblHotel tblHotel = db.tblHotels.Find(id);
            if (tblHotel == null)
            {
                return HttpNotFound();
            }
            return View(tblHotel);
        }

        // GET: Hotels/Create
        public ActionResult Create()
        {
            ViewBag.fkHotelAddressid = new SelectList(db.tblHotelAddresses, "id", "address1");
            ViewBag.fkpmsid = new SelectList(db.tblPMS, "id", "name");
            ViewBag.fkTimezoneid = new SelectList(db.tblTimezones, "id", "tzid");
            return View();
        }

        // POST: Hotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,hotelid,hotelname,email,website,enablevalet,pmsmessagepriority,fkHotelAddressid,fkpmsid,hotelflagshipid,status,managementcompanyid,hoteldescription,weathercode,jsonurl,fkTimezoneid,disableWakeup,createddatetime,updateddatetime,ecallowed,showWelcomeScreen,showLanguageScreen,notifySurveyPopup,allowFETutorial,enableCasting,applyMainMenuImgAsBackgroundImg,allowdefaultCheckout,defaultCheckoutTime,enableHotSOS")] tblHotel tblHotel)
        {
            if (ModelState.IsValid)
            {
                db.tblHotels.Add(tblHotel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fkHotelAddressid = new SelectList(db.tblHotelAddresses, "id", "address1", tblHotel.fkHotelAddressid);
            ViewBag.fkpmsid = new SelectList(db.tblPMS, "id", "name", tblHotel.fkpmsid);
            ViewBag.fkTimezoneid = new SelectList(db.tblTimezones, "id", "tzid", tblHotel.fkTimezoneid);
            return View(tblHotel);
        }

        // GET: Hotels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblHotel tblHotel = db.tblHotels.Find(id);
            if (tblHotel == null)
            {
                return HttpNotFound();
            }
            ViewBag.fkHotelAddressid = new SelectList(db.tblHotelAddresses, "id", "address1", tblHotel.fkHotelAddressid);
            ViewBag.fkpmsid = new SelectList(db.tblPMS, "id", "name", tblHotel.fkpmsid);
            ViewBag.fkTimezoneid = new SelectList(db.tblTimezones, "id", "tzid", tblHotel.fkTimezoneid);
            return View(tblHotel);
        }

        // POST: Hotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,hotelid,hotelname,email,website,enablevalet,pmsmessagepriority,fkHotelAddressid,fkpmsid,hotelflagshipid,status,managementcompanyid,hoteldescription,weathercode,jsonurl,fkTimezoneid,disableWakeup,createddatetime,updateddatetime,ecallowed,showWelcomeScreen,showLanguageScreen,notifySurveyPopup,allowFETutorial,enableCasting,applyMainMenuImgAsBackgroundImg,allowdefaultCheckout,defaultCheckoutTime,enableHotSOS")] tblHotel tblHotel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblHotel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fkHotelAddressid = new SelectList(db.tblHotelAddresses, "id", "address1", tblHotel.fkHotelAddressid);
            ViewBag.fkpmsid = new SelectList(db.tblPMS, "id", "name", tblHotel.fkpmsid);
            ViewBag.fkTimezoneid = new SelectList(db.tblTimezones, "id", "tzid", tblHotel.fkTimezoneid);
            return View(tblHotel);
        }

        // GET: Hotels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblHotel tblHotel = db.tblHotels.Find(id);
            if (tblHotel == null)
            {
                return HttpNotFound();
            }
            return View(tblHotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblHotel tblHotel = db.tblHotels.Find(id);
            db.tblHotels.Remove(tblHotel);
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
