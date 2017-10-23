using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfMock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double GetTheVolume(double width, double height, double length);

        /// <summary>
        /// Indsæt data til databasen
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="side"></param>
        /// <returns></returns>
        [OperationContract]
        int InsertData(String request, double volume, double length, double width, double height);
        
        /// <summary>
        /// Returnerer volumen af de tre parametrer
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [OperationContract]
        double GetVolume(double length, double width, double height);

        /// <summary>
        /// Returnerer størrelsen af den manglende side ved at bruge volumen og de to parametrer
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns></returns>
        [OperationContract]
        double GetSide(double volume, double side1, double side2);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
