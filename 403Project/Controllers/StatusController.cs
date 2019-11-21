using _403Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project.Controllers
{
    public class StatusController : Controller
    {
        //List to store the statuses
        public List<Status> lstStatus = new List<Status>()
        {
            new Status{StatusKey = 1, StatusDesc = "Unassigned, Not Started"},
            new Status{StatusKey = 2, StatusDesc = "Assigned, Not Started"},
            new Status{StatusKey = 3, StatusDesc = "In Progress"},
            new Status{StatusKey = 4, StatusDesc = "Completed"},
            new Status{StatusKey = 5, StatusDesc = "Delivered"}
        };
        
        // GET: Status
        public ActionResult Index()
        {
            return View(lstStatus);
        }

        //Method to return edit view for statuses
        [HttpGet]
        public ActionResult EditStatus(int id)
        {
            //Find the item in the list
            Status myStatus = lstStatus.Find(x => x.StatusKey == id);

            //Pass to the edit view
            return View(myStatus);
        }

        //Post edits to the lst
        [HttpPost]
        public ActionResult EditStatus(Status myStatus)
        {
            //Find the item in lstStatus
            var obj = lstStatus.FirstOrDefault(x => x.StatusKey == myStatus.StatusKey);

            if (obj != null)
            {
                //Change attributes
                obj.StatusDesc = myStatus.StatusDesc;
            }

            //Return view of the lists
            return View("Index", lstStatus);
        }
    }
}