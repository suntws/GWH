using System;
using System.Collections.Generic;

namespace InventoryDbAcess.Models;

public partial class PriceUserMaster
{
    public int PuserId { get; set; }

    public string? PuserName { get; set; }

    public string? Ppassword { get; set; }

    public string? PemailId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? UserName { get; set; }

    public string? UserType { get; set; }

    public DateTime? LastLogin { get; set; }

    public bool? LoginStatus { get; set; }

    public bool? ChatLogin { get; set; }

    public string? UserChannel { get; set; }

    public string? UserDepartment { get; set; }
    public bool? GHlogin { get; set; }   
}
