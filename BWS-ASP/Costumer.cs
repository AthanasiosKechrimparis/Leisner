using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BWS_ASP
{
    [Serializable]
    public class Costumer : IUser
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
          [DataMember]
        public string Type { get; set; }

          [DataMember]
        public DateTime Birthday
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Statistic(int ID, DateTime startTime, DateTime EndTime)
        {
            throw new NotImplementedException();
        }

        public Accident ViewAccident(Costumer costumer, DateTime theDate)
        {
            throw new NotImplementedException();
        }

        
       
    }
}