using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAmaz.Controllers
{
    public class SampleDataController : Controller
    {
        public class SampleData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        public static class SampleDataRepository
        {
            public static SampleData Get(int id)
            {
                return GetAll().SingleOrDefault(x => x.Id.Equals(id));
            }
        }
        public static List<SampleData> GetAll()
        {
            return new List<SampleData>
            {
                new SampleData { Id = 1, Name = "CHUDE", Description = "Chu de mon hoc" },
                new SampleData { Id = 2, Name = "KHOAHOC", Description = "Khoa hoc" },
            };
        }
        //    public ActionResult Index()
        //{
        //    return View();
        //}

    }
}