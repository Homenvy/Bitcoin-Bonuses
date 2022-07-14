using Bitcoin_Bonuses.ModelView;
using Bitcoin_Bonuses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitcoin_Bonuses.Controllers
{
    public class HomeController : Controller
    {
        public BitcoinTradingDB _db = new BitcoinTradingDB();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _FeaturedDisplayPartial(Bitcoin dbId)
        {
            if (dbId == null)
            {
                return View("ID is missing!");
            }
            else
            {
                Bitcoin selection = new Bitcoin();
                selection = _db.Bitcoin.Find(dbId.Id);
                return View(selection);
            }
        }

        public ActionResult BitcoinForex()
        {
            BitcoinTradingDB vm = new BitcoinTradingDB();
            if (vm == null)
            {
                return View("ERROR: Database is Empty!");
            }
            else
            {
                vm.Bitcoin = _db.Bitcoin;
                return View(vm);
            }
        }

        public ActionResult BitcoinExchange()
        {
            BitcoinTradingDB vm = new BitcoinTradingDB();
            if (vm == null)
            {
                return View("ERROR: Database is Empty!");
            }
            else
            {
                vm.Bitcoin = _db.Bitcoin;
                return View(vm);
            }
        }

        public ActionResult BitcoinServices()
        {
            BitcoinTradingDB vm = new BitcoinTradingDB();
            if (vm == null)
            {
                return View("ERROR: Database is Empty!");
            }
            else
            {
                vm.Bitcoin = _db.Bitcoin;
                return View(vm);
            }
        }

        public ActionResult BitcoinGambling()
        {
            BitcoinTradingDB vm = new BitcoinTradingDB();
            if (vm == null)
            {
                return View("ERROR: Database is Empty!");
            }
            else
            {
                vm.Bitcoin = _db.Bitcoin;
                return View(vm);
            }
        }

        public ActionResult BitcoinMining()
        {
            BitcoinTradingDB vm = new BitcoinTradingDB();
            if (vm == null)
            {
                return View("ERROR: Database is Empty!");
            }
            else
            {
                vm.Bitcoin = _db.Bitcoin;
                return View(vm);
            }
        }

        public ActionResult BitcoinAll()
        {
            BitcoinTradingDB vm = new BitcoinTradingDB();
            if (vm == null)
            {
                return View("ERROR: Database is Empty!");
            }
            else
            {
                vm.Bitcoin = _db.Bitcoin;
                return View(vm);
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
