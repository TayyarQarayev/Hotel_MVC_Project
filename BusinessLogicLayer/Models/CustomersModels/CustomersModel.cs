using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models.CustomersModels;

public class CustomersModel
{
    public int? ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string DateOfBirth { get; set; } = string.Empty;
    public string ContactNO { get; set; } = string.Empty;
}
