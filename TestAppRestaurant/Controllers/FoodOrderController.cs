using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAppRestaurant.Repository;
using TestAppRestaurant.ViewModel;

namespace TestAppRestaurant.Controllers
{
    public class FoodOrderController : Controller
    {
        FoodOrderRepository frepo = new FoodOrderRepository();

        public JsonResult getFoodOrderList()
        {
            var list = frepo.List();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int id)
        {
            ViewBag.listofFood = frepo.getFoodList();
            var data = frepo.getbyId(id);
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Create()
        {
            var foodList = frepo.getFoodList();
            ViewBag.listofFood = foodList;
            return View();
        }


        [HttpPost]
        public ActionResult Create(FoodOrderViewModel obj)
        {
            frepo.Add(obj);
            return Json(1, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Edit(FoodOrderViewModel obj)
        {
            if (obj.FoodOrderID != 0)
            {
                frepo.Edit(obj);
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(0, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(int id)
        {

            frepo.Delete(id);
            return Json(1, JsonRequestBehavior.AllowGet);
        }


    }
}
