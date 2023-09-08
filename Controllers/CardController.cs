using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly CardService _cardService;

        public CardController(CardService cardService) 
        {
            _cardService = cardService;
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return await _cardService.GetCardById(id);
        }

        // POST api/<CardController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Guid customerId)
        {
            return await _cardService.CreateCard(customerId);
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CardDto model)
        {
            return await _cardService.UpdateCard(id, model);
        }

        // PUT api/<CardController>/5
        [HttpPut("Block/{id}")]
        public async Task<IActionResult> Block(Guid id)
        {
            return await _cardService.BlockCard(id);
        }

        // PUT api/<CardController>/5
        [HttpPut("UnBlock/{id}")]
        public async Task<IActionResult> UnBlock(Guid id)
        {
            return await _cardService.UnBlockCard(id);
        }

        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return await _cardService.DeleteCard(id);
        }
    }
}
