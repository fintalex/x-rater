using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Models;
using WebInfrastructure;

namespace x_rater.Controllers
{
    public class ExChangeRatesController
    {
        public List<ExChangeRates> GetRates()
        {
			BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient(); //.GetCursOnDate(new DateTime());
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
			BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient();

			DataSet dsEnumValue = cbservice.EnumValutes(false);

			DataTable dtValutes = dsEnumValue.Tables[0];

			List<Valute> listValutes = dtValutes.DataTableToList<Valute>();

			return listValutes;
		}

		public void GetDynamicOfCurs(DateTime timeFrom, DateTime timeTo, string valuteCode)
		{
			BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient();

			DataSet dsDynamicCurs = cbservice.GetCursDynamic(timeFrom, timeTo, valuteCode);

			DataTable dtDynamicCurs = dsDynamicCurs.Tables[0];

			List<Valute> listValutes = dtDynamicCurs.DataTableToList<Valute>();
		}
    }

    
}