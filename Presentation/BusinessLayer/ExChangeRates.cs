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
		/// <summary>
		/// получаем список курса валют всех на текущий день
		/// </summary>
		/// <returns></returns>
        public List<ExChangeRates> GetRates()
        {
			BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient(); /
			DataSet curDataSet = cbservice.GetCursOnDate(DateTime.Now.AddDays(1));

			DataTable dt = curDataSet.Tables[0];
			List<ExChangeRates> list = dt.DataTableToList<ExChangeRates>();
						
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

		/// <summary>
		/// Получаем массик по динамике изменения курса за период времени
		/// </summary>
		/// <param name="timeFrom"></param>
		/// <param name="timeTo"></param>
		/// <param name="valuteCode"></param>
		/// <returns></returns>
		public List<ValuteCurs> GetDynamicOfCurs(DateTime timeFrom, DateTime timeTo, string valuteCode)
		{
			BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient();

			DataSet dsDynamicCurs = cbservice.GetCursDynamic(timeFrom, timeTo, valuteCode);

			DataTable dtDynamicCurs = dsDynamicCurs.Tables[0];

			List<ValuteCurs> listValutes = dtDynamicCurs.DataTableToList<ValuteCurs>();

			return listValutes;
		}
    }

    
}