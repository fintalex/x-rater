using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using BL;

namespace x_rater.Services
{
	[ScriptService()]
	public class ValuteService
	{
		[WebMethod(EnableSession = true)]
		[ScriptMethod]
		public List<Valute> GetValuteList()
		{
			ExChangeRatesController exRatesCtrl = new ExChangeRatesController();
			return exRatesCtrl.GetListValutes(); // пробуем метод который просто возвращает  список валют от ЦБ
		}
	}
}