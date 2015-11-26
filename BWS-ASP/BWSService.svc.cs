using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BWS_ASP
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BWSService : IBWSService
    {
        
        private List<Accident> listofAccidents;
        private object _lock;
        LogIn Log;
        Admin admin;
        Device dev;
        Statistics stat;

        public BWSService()
        {
            listofAccidents = new List<Accident>();
            _lock = new object();
        }
        public void Dowork()
        {
            throw new NotImplementedException();
        }
        public List<AccidentDTO> GetAccidents(List<Accident> tmpListOfAccidents)
        {
            AccidentDTO accidentDTO;
            List<AccidentDTO> listOfAccidentDTO;

            listOfAccidentDTO = new List<AccidentDTO>();

            lock (this._lock)
            {
                foreach (Accident accident in tmpListOfAccidents)
                {
                    accidentDTO = new AccidentDTO();

                    accidentDTO.AccidentID = accident.AccidentID;
                    accidentDTO.Amount = accident.Amount;
                    accidentDTO.Date = accident.TimeOfAccident;
                    accidentDTO.DeviceID = accident.dev.DeviceNumber;
                    accidentDTO.ST = accident.ST;

                    listOfAccidentDTO.Add(accidentDTO);
                }

            }

            return listOfAccidentDTO;
        }
        public List<Day> GetDayAccidents(DateTime selectStart, DateTime selectEnd, int DeviceNr)
        {


            stat = new Statistics();
            return stat.getAccidentDaysFromDB(selectStart, selectEnd, DeviceNr);


        }

     
        public int logIn(string username, string password)
        {
            int returner;
            Log = new LogIn();
            returner = Log.login(username, password);
            return returner;
        }


        public List<AccidentDTO> GetSatisticBasedOnUser(int ID, DateTime startdate, DateTime enddate)
        {
            Statistics ST = new Statistics();
            DateTime D1 = new DateTime();
            D1 = startdate;

            DateTime D2 = new DateTime();
            D2 = enddate;

                List<Accident> listofAccidents = ST.getFromDB(ID, D1, D2);
                return GetAccidents(listofAccidents);
        }

        public void RegisterDevice(int userID)
        {
            admin = new Admin();
            admin.RegisterDevice(userID);
        }

        public void UpdateAccident(int AccidentID, int newAmount, DateTime newDate, int NewDeviceID)
        {
            admin = new Admin();
            admin.UpdateAccident(AccidentID, newDate, newAmount, NewDeviceID);
        }
        public void DeleteAccidents(int AccidentID)
        {
            admin = new Admin();
            admin.DeleteAccidents(AccidentID);
        }

        public void SignUp(string type, string birthday, string UserName, string PassWord, string Name, int deviceID)
        {
            Log = new LogIn();
            Log.SignUp(type, birthday, UserName, PassWord, Name, deviceID);
        }

        public List<AccidentDTO> ReadAccidents(int UserID)
        {
            Admin adm = new Admin();
            List<Accident> listOfAcc = adm.GetStatisticsFromDB(UserID);
            return GetAccidents(listOfAcc);

           
        }



        public void RegisterAccident(int deviceNR, int amount, DateTime timeOfAccident, int Drinks, DateTime TimeSleep, DateTime TimeToilet, int ToiletVisit)
        {
            dev = new Device(deviceNR);
            dev.RegisterAccident(amount, timeOfAccident, Drinks, TimeSleep, TimeToilet, ToiletVisit);
        }

        public int getIDFromUsername(string username)
        {
            LogIn log = new LogIn();

            return log.getUserIDFromUsername(username);
        }

        


    }
}



