using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBuisness
{
    public interface IBarcodeRepository
    {
        Task<List<RimProcessIdDetail>> GetBarcodeforIDAsync(string departmentName);
    }

    public class BarcodeRepository : IBarcodeRepository
    {
        private readonly OrderdbContext _context;

        public BarcodeRepository(OrderdbContext context)
        {
            _context = context;
        }

        public async Task<List<RimProcessIdDetail>> GetBarcodeforIDAsync(string barcodeNo)
        {
            return await _context.GetBarcodeFromStoredProcedureAsync(barcodeNo);
        }
    }

}
