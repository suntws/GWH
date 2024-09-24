using InventoryApplication.Models;
using InventoryDbAcess.Abstract;
using InventoryDbAcess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDbAcess.Repository
{
    public  class RInventoryDb:Iinventory

    {
        TtsdbContext _context=new TtsdbContext();
        OrderdbContext _contextorderdb = new OrderdbContext();

        public string login(PriceUserMaster PU)
        {
            string msg = "FAILURE";
            PriceUserMaster pus=new PriceUserMaster();
            if (PU != null)
            {
                pus = _context.PriceUserMasters.FirstOrDefault(U => U.PuserName == PU.PuserName &&
                U.Ppassword == PU.Ppassword && U.GHlogin ==true);
            }
            if (pus==null)
            {
                return msg;
              
            }
            else
            {
                msg = "SUCESSFULLY";
               
            }
            

            return msg;


        }
        //tell
        void ererer()
        {

        }
 

        public string  scanningPageee(RimProcessIdDetail RID)
        {
          string msg = "Faileddddddd";
            if(RID == null)
            {
                return msg;
            }

            else
            {
                msg = "Successfull";
            }

            return msg;

        }

    }
}
