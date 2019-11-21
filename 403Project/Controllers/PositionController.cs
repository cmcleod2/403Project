using _403Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project.Controllers
{
    public class PositionController : Controller
    {
        //List for the positions
        public List<Position> lstPosition = new List<Position>()
        {
            new Position { PositionKey = 1, PositionDesc = "Engineer"},
            new Position { PositionKey = 2, PositionDesc = "Draftsman"},
            new Position { PositionKey = 3, PositionDesc = "Office Manager"}
        };
        
        // GET: Position
        public ActionResult Index()
        {
            return View(lstPosition);
        }

        //Return the edit position view
        [HttpGet]
        public ActionResult EditPosition(int id)
        {
            //Find the position of the position in the list and assign it to the myPosition Variable
            Position myPosition = lstPosition.Find(x => x.PositionKey == id);

            //Pass that variable to the view
            return View(myPosition);
        }

        //Post the edits
        [HttpPost]
        public ActionResult EditPosition(Position myPosition)
        {
            //Find the item in the lstPosition
            var obj = lstPosition.FirstOrDefault(x => x.PositionKey == myPosition.PositionKey);

            if(obj != null)
            {
                //Edit lstPosition items
                obj.PositionDesc = myPosition.PositionDesc;
            }

            //Return to the list of positions
            return View("Index", lstPosition);
        }
    }
}