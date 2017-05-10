using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using TCCExpressMIs.Models;
using TCCExpressMIs.ViewModels;

namespace TCCExpressMIs.Controllers.Api
{
    public class MoveInsController : Controller
    {
        private IEMIRepository _repository;

        public MoveInsController(IEMIRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("api/moveins")]
        public IActionResult Get()
        {
            return Ok(_repository.GetAllProperties());
        }

        [HttpPost("api/loginCheck")]
        public JsonResult Post(string cName)
        {
            var prop = _repository.CheckIfPropertyExists(cName);

            

            return new JsonResult(prop);
        }

        [HttpPost("api/login")]
        public IActionResult Post([FromBody]ResidentLoginModel theMoveIn)
        {
            if (ModelState.IsValid)
            {
                var newMoveIn = Mapper.Map<MoveIn>(theMoveIn);

                return Created($"api/login/{theMoveIn.CID}", Mapper.Map<ResidentLoginModel>(newMoveIn));
            }

            return Ok(true);
        }
    }
}
