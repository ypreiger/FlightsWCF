using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FlightsWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public flights GeFlights(string user_key)
        {
            flights f = new flights();

            flight flight1 = new flight();
            flight1.id = 1;
            flight1.from = "EWR";
            flight1.number = 910;
            flight1.to = "HKG";
            flight1.departureDateAndTime = new DateTime(2017, 01, 01, 20, 40, 0);
            flight1.airline = "CX";
            f.Add(flight1);

            flight flight2 = new flight();
            flight2.id = 2;
            flight2.from = "SFO";
            flight2.number = 870;
            flight2.to = "PVG";
            flight2.departureDateAndTime = new DateTime(2017, 01, 11, 22, 10, 0);
            flight2.airline = "CX";
            f.Add(flight2);

            flight flight3 = new flight();
            flight3.id = 3;
            flight3.from = "LAX";
            flight3.number = 489;
            flight3.to = "PEK";
            flight3.departureDateAndTime = new DateTime(2017, 01, 01, 12, 25, 0);
            flight3.airline = "CX";
            f.Add(flight3);

            return f;

        }
    }
}
