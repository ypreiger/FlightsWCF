using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FlightsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "https://stage-ancoria-gw.apps.master2.zebrac.net")]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        [WebGet(ResponseFormat = System.ServiceModel.Web.WebMessageFormat.Xml, UriTemplate = "intl/flights?user_key={user_key}")]
        flights GeFlights(string user_key);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class flight
    {
        [DataMember]
        public Int32 id;
        [DataMember]
        public string from;
        [DataMember]
        public Int32 number;
        [DataMember]
        public string to;
        [DataMember]
        public DateTime departureDateAndTime;
        [DataMember]
        public string airline;

    }

    [CollectionDataContract]
    public class flights : List<flight>
    { 
    }
}
