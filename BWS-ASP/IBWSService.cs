﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BWS_ASP
{
    [Serializable]
    public class AccidentDTO
    {
        public int AccidentID { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public int DeviceID { get; set; }
        public int ST { get; set; }
   
       

    }

    [ServiceContract]
    public interface IBWSService
    {
        [OperationContract]
        void Dowork();
        [OperationContract]
        void RegisterAccident(int deviceNR, int amount, DateTime timeOfAccident);

        [OperationContract]
        List<AccidentDTO> GetSatisticBasedOnUser(int ID, DateTime startdate, DateTime enddate);

        [OperationContract]
        int logIn(String username, string password);

        [OperationContract]
        void RegisterDevice(int userID);

        [OperationContract]
        void UpdateAccident(int AccidentID, int Amount, DateTime date, int DeviceID);
        [OperationContract]
        void DeleteAccidents(int AccidentID);

        [OperationContract]
        void SignUp(string UserName, string PassWord, int Permision, string Name, int Age);

        [OperationContract]
        List<AccidentDTO> ReadAccidents(int UserID);

    }
}