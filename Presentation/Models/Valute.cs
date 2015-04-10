using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace x_rater.Models
{
	public class Valute
	{
		/// <summary>
		/// Внутренний код валюты  - код для идентификации валют, является локальным и уникальным идентификатором валюты в данной базе, необходим для использования в качестве параметра для методов GetCursDynamic
		/// </summary>
		public int Vcode;

		/// <summary>
		/// Название валюты на русском
		/// </summary>
		public string Vname;

		/// <summary>
		/// Название валюты на английском
		/// </summary>
		public string VEngname;

		/// <summary>
		/// Номинал
		/// </summary>
		public int Vnom;

		/// <summary>
		/// Внутренний код валюты, являющейся 'базовой' - этот код используется для связи, при изменениях кодов или названий фактически одной и той же валюты.
		/// </summary>
		public double VcommonCode;

		/// <summary>
		/// цифровой код ISO (840 - USD ; 978 - EUR ; 643 - RUB)
		/// </summary>
		public int VnumCode;

		/// <summary>
		/// 3х буквенный код ISO (USD; EUR; RUB; CNY)
		/// </summary>
		public string VcharCode;

	}
}