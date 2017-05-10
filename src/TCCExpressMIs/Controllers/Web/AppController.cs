using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCExpressMIs.Models;

namespace TCCExpressMIs.Controllers.Web
{
    public class AppController : Controller
    {
        private IConfigurationRoot _config;
        private IEMIRepository _repository;
        public AppController(IConfigurationRoot config, IEMIRepository repository)
        {
            _config = config;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}
