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
			List<ExChangeRates> list = new List<ExChangeRates>(); // dt.DataTableToList<ExChangeRates>();

			
			var c = cbservice.GetCursDynamic(DateTime.Now.AddYears(-1), DateTime.Now, "R01235");

			var r = cbservice.GetCursDynamic(DateTime.Now.AddYears(-1), DateTime.Now, "R01235");

			var r2 = cbservice.GetCursDynamicXML(DateTime.Now.AddDays(-100), DateTime.Now, "R01235");

			DataSet r3 = cbservice.GetCursDynamic(DateTime.Now.AddDays(-100), DateTime.Now, "R01235");

            return list;
        }

		/// <summary>
		/// Получаем список всех валют с которыми работает ЦБ
		/// </summary>
		/// <returns></returns>
		public List<Valute> GetListValutes()
		{
			CBService.DailyInfoSoapClient cbservice = new CBService.DailyInfoSoapClient();

			DataSet dsEnumValue = cbservice.EnumValutes(false);

			DataTable dtValutes = dsEnumValue.Tables[0];

			List<Valute> listValutes = dtValutes.DataTableToList<Valute>();

			return listValutes;
		}

		public void GetDynamicOfCurs(DateTime timeFrom, DateTime timeTo, string valuteCode)
		{
			CBService.DailyInfoSoapClient cbservice = new CBService.DailyInfoSoapClient();

			DataSet dsDynamicCurs = cbservice.GetCursDynamic(timeFrom, timeTo, valuteCode);

			DataTable dtDynamicCurs = dsDynamicCurs.Tables[0];

			List<Valute> listValutes = dtDynamicCurs.DataTableToList<Valute>();
		}
    }

    
}