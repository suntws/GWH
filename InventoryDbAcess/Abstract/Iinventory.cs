using InventoryApplication.Models;
using InventoryDbAcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDbAcess.Abstract
{
    public interface Iinventory
    {
        string login(PriceUserMaster PU);
        string scanningPageee(RimProcessIdDetail RID);
    }
}
