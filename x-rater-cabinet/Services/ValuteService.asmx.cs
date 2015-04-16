using BusinessLayer;
using Models;
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

		[WebMethod]
		public List<Valute> GetValuteList()
		{
			ExChangeRatesController exRatesCtrl = new ExChangeRatesController();
			return exRatesCtrl.GetListValutes(); // пробуем метод который просто возвращает  список валют от ЦБ
		}
	}
}
