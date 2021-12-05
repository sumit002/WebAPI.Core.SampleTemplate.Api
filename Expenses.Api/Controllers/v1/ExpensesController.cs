using Expenses.Api.Common.Utils;
using Expenses.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Expenses.Api.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ExpensesControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<ExpensesController> _logger;

        public ExpensesController(ILogger<ExpensesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            _logger.LogInformation("Get Expenses called.");
            return Enumerable.Range(1, 3).Select(index => new Expense
            {
                Id = Guid.NewGuid(),
                ExpenseDate = DateTime.Now.AddDays(-index),
                Description = RandomGenerator.RandomString(),
                Amount = RandomGenerator.RandomNumber(),
                Comment = RandomGenerator.RandomString(),
                CreatedOn = DateTime.Now.AddDays(-index),
                CreatedById = Guid.NewGuid()
            })
            .ToArray();
        }
    }
}
