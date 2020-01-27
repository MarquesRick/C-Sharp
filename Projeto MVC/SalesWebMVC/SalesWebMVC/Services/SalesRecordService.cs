using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMVC.Services
{
    public class SalesRecordService
    {
        //Dependencia da classe
        private readonly SalesWebMVCContext _context;
        public SalesRecordService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller) //faz o join entre tabela seller
                .Include(x => x.Seller.Department) //faz o join entre tabela department
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

    }
}
