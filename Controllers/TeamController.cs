using Microsoft.AspNetCore.Mvc;
using SoccerTeamTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerTeamTracker.Controllers
{
    public class TeamController : Controller
    {
        private DataContext _dataContext;

        public TeamController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var teams = _dataContext.Teams.ToList();

            return View(teams);
        }
    }
}
