using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MainWebApp.Data;
using MainWebApp.Models;

namespace MainWebApp.Controllers
{
    public class RepairsController : Controller
    {
        private MainWebAppContext db = new MainWebAppContext();

        // GET: spRepairCrud_Result
        public ActionResult Index()
        {
            return View(db.spRepairCrud_Result.ToList());
        }


        // GET: spRepairCrud_Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            spRepairCrud_Result spRepairCrud_Result = db.spRepairCrud_Result.Find(id);
            if (spRepairCrud_Result == null)
            {
                return HttpNotFound();
            }
            return View(spRepairCrud_Result);
        }

        // GET: spRepairCrud_Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: spRepairCrud_Result/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "REPAIR_ID,EQUIPMENT_ID,REQUESTED_BY,RMA_NUM,SHIPPED_DATE,TRACKING_NUM,RECIPIENT,ADDRESS_1,ADDRESS_2,ADDRESS_3,CITY,STATE,ZIP,COUNTRY,CONTACT_PHONE,CONTACT_EMAIL,REPLACEMENT_SERIAL_NUM,RETURNED,RETURNED_DATE")] spRepairCrud_Result spRepairCrud_Result)
        {
            if (ModelState.IsValid)
            {
                db.spRepairCrud_Result.Add(spRepairCrud_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spRepairCrud_Result);
        }

        // GET: spRepairCrud_Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            spRepairCrud_Result spRepairCrud_Result = db.spRepairCrud_Result.Find(id);
            if (spRepairCrud_Result == null)
            {
                return HttpNotFound();
            }
            return View(spRepairCrud_Result);
        }

        // POST: spRepairCrud_Result/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "REPAIR_ID,EQUIPMENT_ID,REQUESTED_BY,RMA_NUM,SHIPPED_DATE,TRACKING_NUM,RECIPIENT,ADDRESS_1,ADDRESS_2,ADDRESS_3,CITY,STATE,ZIP,COUNTRY,CONTACT_PHONE,CONTACT_EMAIL,REPLACEMENT_SERIAL_NUM,RETURNED,RETURNED_DATE")] spRepairCrud_Result spRepairCrud_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spRepairCrud_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spRepairCrud_Result);
        }

        // GET: spRepairCrud_Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            spRepairCrud_Result spRepairCrud_Result = db.spRepairCrud_Result.Find(id);
            if (spRepairCrud_Result == null)
            {
                return HttpNotFound();
            }
            return View(spRepairCrud_Result);
        }

        // POST: spRepairCrud_Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            spRepairCrud_Result spRepairCrud_Result = db.spRepairCrud_Result.Find(id);
            db.spRepairCrud_Result.Remove(spRepairCrud_Result);
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
