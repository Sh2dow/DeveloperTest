using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DeveloperTest.Controllers
{
    public class ParticipantController : Code.BaseController
    {
        // GET: /Participant/Add
        [HttpGet]
        public ActionResult Add()
        {
            DeveloperTest.Models.Participant.Add add = new Models.Participant.Add();

            AddCommon(add);

            return View(add);
        }

        private void AddCommon(Models.Participant.Add add)
        {
            // Add our state list to the passed in add model.
            SelectList stateList = new SelectList(M2.DeveloperTest.Constants.Constant.StateList);
            add.StateList = stateList;
        }

        // POST: /Participant/Add
        [HttpPost]
        public ActionResult Add(Models.Participant.Add add)
        {
            // If we have valid model state then create a new participant entity and persist it to the repository.
            // IF the model state is not valid return to our add view and display the appropriate validation messages.
            if (ModelState.IsValid)
            {
                M2.DeveloperTest.Entities.Participant participant = DeveloperTestContext.Participants.Create();

                participant.FirstName = add.FirstName;
                participant.LastName = add.LastName;
                participant.Gender = add.Gender.Value;
                participant.AddressLine1 = add.AddressLine1;
                participant.AddressLine2 = add.AddressLine2;
                participant.City = add.City;
                participant.State = add.State;
                participant.Zip = add.Zip;

                ParticipantFacade.Add(participant);

                DeveloperTestContext.SaveChanges();

                return RedirectToAction(nameof(ParticipantController.Index));
            }

            AddCommon(add);

            return View(add);
        }

        // GET: /Participant/Index
        public ActionResult Index()
        {
            // Get all our participants from the repository and convert them
            // to a list of our index view model.
            List<Models.Participant.Index> indexes = ParticipantFacade.GetAll()
                                                        .Select(p => new Models.Participant.Index
                                                        {
                                                            FirstName = p.FirstName,
                                                            LastName = p.LastName,
                                                            City = p.City,
                                                            State = p.State,
                                                            Zip = p.Zip
                                                        })
                                                        .ToList();
            
            return View(indexes);
        }
    }
}