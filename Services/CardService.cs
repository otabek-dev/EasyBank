using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class CardService : Controller
    {
        private readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetCardById(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return Ok("Card nut found!");

            return Ok(card);
        }

        public async Task<IActionResult> CreateCard(Guid customerId)
        {
            var faker = new Bogus.Faker();

            var card = new Card
            {
                Id = Guid.NewGuid(),
                CardNumber = faker.Finance.CreditCardNumber(),
                PinCode = faker.Finance.Bic(),
                CustomerId = customerId
            };

            await _context.AddAsync(card);
            await _context.SaveChangesAsync();
            return Ok("Card created!");
        }

        public async Task<IActionResult> UpdateCard(Guid id, CardDto model)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return NotFound("Card nut found!");

            var entry = _context.Entry(card);
            entry.CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
            return Ok("Card updated!");
        }

        public async Task<IActionResult> BlockCard(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return NotFound("Card nut found!");

            card.IsBlocked = true;
            await _context.SaveChangesAsync();
            return Ok("Card blocked!");
        }

        public async Task<IActionResult> UnBlockCard(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return NotFound("Card nut found!");

            card.IsBlocked = false;
            await _context.SaveChangesAsync();
            return Ok("Card unBlocked!");
        }

        public async Task<IActionResult> DeleteCard(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return NotFound("Card nut found!");

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
            return Ok("Card deleted!");
        }
    }
}