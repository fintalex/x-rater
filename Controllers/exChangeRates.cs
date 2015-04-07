using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using x_rater.Models;
using x_rater.Infrastructure;

namespace x_rater.Controllers
{
    public class ExChangeRatesController
    {
        public List<ExChangeRates> GetRates()
        {
            CBService.DailyInfoSoapClient cbservice = new CBService.DailyInfoSoapClient(); //.GetCursOnDate(new DateTime());
            DataSet curDataSet = cbservice.GetCursOnDate(DateTime.Now.AddDays(1));

            DataTable dt = curDataSet.Tables[0];
            List<ExChangeRates> list = dt.DataTableToList<ExChangeRates>();

            return list;
        }
    }

    
}