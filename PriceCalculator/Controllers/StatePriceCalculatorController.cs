using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceCalculator.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PriceCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatePriceCalculatorController : ControllerBase
    {
        // convert get by parameter to send number and calculate price (hard coded state code and price)  

        // GET: api/<StatePriceCalculatorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StatePriceCalculatorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("Calculate/{number}", Name = "CalculatePrice")]
        public double CalculatePrice(int number)
        {
            StatePriceCalculator.StateCode = "NV";
            return StatePriceCalculator.Calulate(number, 10000);
        }

        // POST api/<StatePriceCalculatorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StatePriceCalculatorController>/5
        [HttpPut("Calculate/{stateCode}")]
        public double Put(string stateCode, [FromBody] Item value)
        {
            StatePriceCalculator.StateCode = stateCode;
            return StatePriceCalculator.Calulate(value.Number, value.Price);
        }

        // DELETE api/<StatePriceCalculatorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
