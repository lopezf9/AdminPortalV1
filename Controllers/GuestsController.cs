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
    public class GuestsController : Controller
    {
        private GCAdminv23Entities db = new GCAdminv23Entities();

        // GET: Guests
        public ActionResult Index()
        {
           // ViewResult viw = 
            return View(db.tblGuests.ToList());
        }

        // GET: Guests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGuest tblGuest = db.tblGuests.Find(id);
            if (tblGuest == null)
            {
                return HttpNotFound();
            }
            return View(tblGuest);
        }

        // GET: Guests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,firstname,lastname,checkindate,expectedcheckoutdate,checkoutdate,checkoutstatus,checkouttype,billamount,roomnumber,folionumber,ecallowed,vip,primaryguest,guestcount,eventcode,groupcode,loyaltynumber,emailid,language,phonenumber,age,gender,dob,companyname,companyaddress1,companyaddress2,companycode,createddatetime,updateddatetime,wstatus,tvright,checkinRequestFrom")] tblGuest tblGuest)
        {
            if (ModelState.IsValid)
            {
                db.tblGuests.Add(tblGuest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblGuest);
        }

        // GET: Guests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGuest tblGuest = db.tblGuests.Find(id);
            if (tblGuest == null)
            {
                return HttpNotFound();
            }
            return View(tblGuest);
        }

        // POST: Guests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,firstname,lastname,checkindate,expectedcheckoutdate,checkoutdate,checkoutstatus,checkouttype,billamount,roomnumber,folionumber,ecallowed,vip,primaryguest,guestcount,eventcode,groupcode,loyaltynumber,emailid,language,phonenumber,age,gender,dob,companyname,companyaddress1,companyaddress2,companycode,createddatetime,updateddatetime,wstatus,tvright,checkinRequestFrom")] tblGuest tblGuest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblGuest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblGuest);
        }

        // GET: Guests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGuest tblGuest = db.tblGuests.Find(id);
            if (tblGuest == null)
            {
                return HttpNotFound();
            }
            return View(tblGuest);
        }

        // POST: Guests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblGuest tblGuest = db.tblGuests.Find(id);
            db.tblGuests.Remove(tblGuest);
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
