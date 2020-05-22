using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADAM.Models
{
    public class adamMod
    {

        public List<IDictionary<string, string>> get_daily_data(string areaID, string shiftID)
        {

           List<IDictionary<string, string>> results = new List<IDictionary<string, string>>();

           string query = "SELECT * FROM adam WHERE area = '" + areaID + "'";

            results = Connection.GetDataAssociateArray(query, "Get Data ", Connection.expert_connstring);

            return results;
        }


    }
}
