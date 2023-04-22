using EntertainmentAgencyolsenj8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace EntertainmentAgencyolsenj8.Controllers
{
    public class HomeController : Controller
    {

        //Using the repository pattern rather than direct access to context
        private IAgencyRepository repo { get; set; }

       
        public HomeController(IAgencyRepository temp)
        {
            repo = temp;
     
        }

        //classic index action
        public IActionResult Index()
        {
            return View();
        }

        //packages the repo into a list and sends it to the entertainers page
        public IActionResult Entertainers()
        {
            var none = repo.Entertainers
                .ToList();
            return View(none);
        }

        //Sends the user to the details page with the correct record by taking in id
        public IActionResult Details(long id)
        {
            Entertainer entertainer = repo.Entertainers.FirstOrDefault(x => x.EntertainerId == id);

            return View("Details", entertainer);
        }


        //Edit get method which takes the entertainerid and sends the user to the add page (to edit)
        [HttpGet]
        public IActionResult Edit(long id)
        {
            Entertainer entertainer = repo.Entertainers.FirstOrDefault(x => x.EntertainerId == id);
            return View("Edit", entertainer);
        }


        //Edit page. Updates a record
        [HttpPost]
        public IActionResult Edit(Entertainer model)
        {
            if (ModelState.IsValid)
            {
                repo.Update(model);
                return RedirectToAction("Entertainers");
            } // if invalid input
            else { return RedirectToAction("Edit", model.EntertainerId); }
        }

        //The get record retrieves the id and sends user to delete confirmation page

        [HttpGet]
        public IActionResult Delete(long id)
        {
            var record = repo.Entertainers.Single(x => x.EntertainerId == id);

            return View("Delete", record);
        }

        //This action should delete the record
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var record = repo.Entertainers.Single(x => x.EntertainerId == id);
            repo.Remove(record);
            return RedirectToAction("Entertainers");

        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Entertainer model)
        {
            if (ModelState.IsValid)
            {
                repo.Add(model);
                return RedirectToAction("Entertainers");
            } // if invalid input
            else return RedirectToAction("Entertainers");
        }


    }
}