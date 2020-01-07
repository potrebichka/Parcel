using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelController : Controller
    {
        [HttpGet("/parcel")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/parcel/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/parcel")]
        public ActionResult Create(int length, int height, int width, int weight)
        {
            Parcel newParcel = new Parcel(length,height,width,weight);
            return View("Index", newParcel);
        }
    }
}