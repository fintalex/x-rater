using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace x_rater.Services
{
	/// <summary>
	/// Сводное описание для ValuteService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
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
