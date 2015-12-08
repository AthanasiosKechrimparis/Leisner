using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using LeisnerWebApplication.LeisnerRef;

namespace LeisnerWebApplication
{
    
    [Serializable]
    public class Costumer
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

          public Costumer(string Name)
          {
              this.Name = Name;
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