using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using healthcare_timeline.DataAccess;
using healthcare_timeline.Models;
using Microsoft.AspNet.Identity;

namespace healthcare_timeline.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            ViewBag.ArrayData = GetFitnessData();
            return View();
        }

        // GET: Update
        public ActionResult Update()
        {
            ViewBag.Success = false;
            ViewBag.ArrayData = GetFitnessData();
            return View();
        }

        [HttpPost]
        public ActionResult Update(FitnessDataViewModel fitnessModel)
        {
            FitnessInfoDal dal = new FitnessInfoDal();
            dal.AddFitnessData(fitnessModel,User.Identity.GetUserId());
            ViewBag.Success = true;
            ViewBag.ArrayData = GetFitnessData();
            return View();
        }

        public List<float> GetFitnessData()
        {
            FitnessInfoDal dal = new FitnessInfoDal();
            return dal.GetFitnessData(User.Identity.GetUserId());
        }
    }
}