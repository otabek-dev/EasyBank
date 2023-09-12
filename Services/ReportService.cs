﻿using EasyBank.DB;
using EasyBank.DTOs;
using EasyBank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyBank.Services
{
    public class ReportService
    {
        private readonly AppDbContext _context;

        public ReportService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Report> CreateReport(ReportDto reportDto)
        {
            var operations = _context.History
                .Where(x => x.EmployeeId == reportDto.EmployeeId
                    && x.Timestamp >= reportDto.StartDate
                    && x.Timestamp <= reportDto.EndDate);

            var groupedOperations = await operations
                .GroupBy(x => new { x.OperationType, x.Timestamp.Date })
                .Select(group => new
                {
                    OperationType = group.Key.OperationType,
                    Date = group.Key.Date,
                    Count = group.Count()
                })
                .ToListAsync();

            var info = groupedOperations.Select(item =>
                $"{item.OperationType.ToString()}: {item.Count} операций ({item.Date:yyyy-MM-dd})");

            var report = new Report()
            {
                Id = Guid.NewGuid(),
                EmployeeId = reportDto.EmployeeId,
                StartDate = reportDto.StartDate,
                EndDate = reportDto.EndDate,
                OperationInfo = string.Join("\n", info)
            };

            return report;
        }
    }
}
