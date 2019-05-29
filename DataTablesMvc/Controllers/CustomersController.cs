using DataTablesMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DataTablesMvc.Controllers
{
    public class CustomersController : Controller
    {
        private DBConnection db = new DBConnection();

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customers         
        public ActionResult GetData()
        {
            List<Customers> lstCustomers = db.Customers.ToList<Customers>();

            return Json(new { data = lstCustomers }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Customers());
            else
            {
                return View(db.Customers.Where(x => x.CustomerID == id).FirstOrDefault<Customers>());
            }
        }
    }
}