using BankWebAPI.AngularBank;
using BankWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private IRepository ip;
        public BankController(IRepository repository) 
        {
            ip = repository;
        }
        [HttpGet]
        [Produces(typeof(List<TblBank>))]
        public List<TblBank> Get()
        {
            return ip.GetAllBank();
        }
        [HttpGet("BankById/{id}")]
        public TblBank Get([FromRoute]int id) 
        {
            return ip.GetBankById(id);
        }
        [HttpGet("BankByCity/{city}")]
        public TblBank Get([FromRoute] string city) 
        {
            return ip.GetBankByCity(city);
        }
        [HttpGet("BankByState/{state}")]
        public TblBank GetByState([FromRoute] string state)
        {
            return ip.GetBankByCity(state);
        }
        [HttpPost("Bank")]
        public IActionResult Post(TblBank tblBank) 
        {
            try 
            {
                ip.AddBank(tblBank);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
        [HttpDelete("Bank/{id}")]
        public IActionResult Delete([FromRoute]int id) 
        {
            ip.DeleteBank(id);
            return Ok();
        }


    }
}
