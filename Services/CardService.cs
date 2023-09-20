using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using EasyBank.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class CardService
    {
        private readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> GetCardByIdAsync(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return new Result(false, "Card nut found!");

            return new DataResult<Card>(card);
        }

        public async Task<Result> CreateCardAsync(Guid customerId)
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
            return new Result(true, "Card created!");
        }

        public async Task<Result> UpdateCardAsync(Guid id, CardDto model)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return new Result(false, "Card nut found!");

            var entry = _context.Entry(card);
            entry.CurrentValues.SetValues(model);
            await _context.SaveChangesAsync();
            return new Result(true, "Card updated!");
        }

        public async Task<Result> BlockCardAsync(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return new Result(false, "Card nut found!");

            card.IsBlocked = true;
            await _context.SaveChangesAsync();
            return new Result(true, "Card blocked!");
        }

        public async Task<Result> UnBlockCardAsync(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return new Result(false, "Card nut found!");

            card.IsBlocked = false;
            await _context.SaveChangesAsync();
            return new Result(true, "Card unBlocked!");
        }

        public async Task<Result> DeleteCardAsync(Guid id)
        {
            var card = await _context.Cards.FirstOrDefaultAsync(e => e.Id == id);
            if (card is null)
                return new Result(false, "Card nut found!");

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
            return new Result(true, "Card deleted!");
        }
    }
}