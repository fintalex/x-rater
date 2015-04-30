using BusinessLayer;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace x_rater.Services
{
	[System.Web.Script.Services.ScriptService]
	public class ValuteService : System.Web.Services.WebService
	{
		/// <summary>
		/// Получаетс список всех валют из ЦБ
		/// </summary>
		/// <returns></returns>
		[WebMethod]
		public List<Valute> GetValuteList()
		{
			ExChangeRatesController exRatesCtrl = new ExChangeRatesController();
			return exRatesCtrl.GetListValutes(); // пробуем метод который просто возвращает  список валют от ЦБ
		}

		/// <summary>
		/// Получаем массик по динамике изменения курса за период времени
		/// </summary>
		/// <returns></returns>
		[WebMethod]
		public dynamic GetDynamicOfCurs(DateTime? timeFrom, DateTime? timeTo, string valuteCode)
		{
			ExChangeRatesController exRatesCtrl = new ExChangeRatesController();
			List<ValuteCurs> listDynamic = exRatesCtrl.GetDynamicOfCurs(DateTime.Now.AddMonths(-5), DateTime.Now, valuteCode);

			return new { r = JsonConvert.SerializeObject(listDynamic) };
		}
	}
}
