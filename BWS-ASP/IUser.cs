using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWS_ASP
{
    interface IUser
    {
        string Name { get; set; }
        string Type { get; set; }
        DateTime Birthday { get; set; }
        string Statistic(int ID, DateTime startTime, DateTime EndTime);
        Accident ViewAccident(Costumer costumer, DateTime theDate);
    }
}
