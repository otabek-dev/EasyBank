using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,Director,Employee")]
    public class CardController : ControllerBase
    {
        private readonly CardService _cardService;
        private readonly HistoryService _historyService;

        public CardController(CardService cardService, HistoryService historyService)
        {
            _cardService = cardService;
            _historyService = historyService;
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            await _historyService.CreateHistoyr(User,
               OperationType.Card, OperationDescription.ReadCard);

            return await _cardService.GetCardById(id);
        }

        // POST api/<CardController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Guid customerId)
        {
            await _historyService.CreateHistoyr(User,
               OperationType.Card, OperationDescription.CreateCard);

            return await _cardService.CreateCard(customerId);
        }

        // PUT api/<CardController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CardDto model)
        {
            await _historyService.CreateHistoyr(User,
               OperationType.Card, OperationDescription.UpdateCard);

            return await _cardService.UpdateCard(id, model);
        }

        // PUT api/<CardController>/5
        [HttpPut("Block/{id}")]
        public async Task<IActionResult> Block(Guid id)
        {
            await _historyService.CreateHistoyr(User,
               OperationType.Card, OperationDescription.BlockCard);

            return await _cardService.BlockCard(id);
        }

        // PUT api/<CardController>/5
        [HttpPut("UnBlock/{id}")]
        public async Task<IActionResult> UnBlock(Guid id)
        {
            await _historyService.CreateHistoyr(User,
               OperationType.Card, OperationDescription.UnBlockCard);

            return await _cardService.UnBlockCard(id);
        }

        // DELETE api/<CardController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _historyService.CreateHistoyr(User,
               OperationType.Card, OperationDescription.DeleteCard);

            return await _cardService.DeleteCard(id);
        }
    }
}
