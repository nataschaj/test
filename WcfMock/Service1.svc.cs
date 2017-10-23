using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace WcfMock
{
    //http://wcfsoapmock.azurewebsites.net/

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region CONNECTION STRING
        //Data Source=natascha.database.windows.net;Initial Catalog=School;Integrated Security=False;User ID=nataschajakobsen;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        private const string ConnectionString =
           "Server=tcp:natascha.database.windows.net,1433;Initial Catalog=School;Persist Security Info=False;User ID=nataschajakobsen;Password=Roskilde4000;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

       
        #endregion

        #region GET SIDE
        public double GetSide(double volume, double side1, double side2)
        {
            return volume + side1 + side1;
        }

        
        #endregion

        #region GET VOLUME
        public double GetVolume(double length, double width, double height)
        {
            return length + width + height;
        }
        #endregion

        #region INSERT DATA I DATABASE

        //Note: Min database gad ikke opdaterer anden gang hvor jeg havde tilføjet request,length,width og height. Så lige nu er der kun Volume i tabellen
        public int InsertData(String request, double volume, double length, double width, double height)
        {
            const string calcInsert = "insert into Calculator (Volume) values (@Volume)";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand insertCommand = new SqlCommand(calcInsert, conn))
                {
                    insertCommand.Parameters.AddWithValue("@Volume", volume);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }
        #endregion

        #region UDVIDET VOLUME
        public double GetTheVolume(double length, double width, double height)
        {
            double volume;
            volume = width + height + length;
            return volume;
        }
        #endregion

    }
}
