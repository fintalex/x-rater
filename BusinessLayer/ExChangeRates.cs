using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Models;
using WebInfrastructure;

namespace BusinessLayer
{
    public class ExChangeRatesController
    {
        /// <summary>
        /// получаем список курса валют всех на текущий день
        /// </summary>
        /// <returns></returns>
        public List<ExChangeRates> GetRates()
        {
            BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient();
            DataSet curDataSet = cbservice.GetCursOnDate(DateTime.Now.AddDays(1));

            DataTable dt = curDataSet.Tables[0];
            List<ExChangeRates> list = dt.DataTableToList<ExChangeRates>();

            return list;
        }

        /// <summary>
        /// Получаем список всех валют с которыми работает ЦБ
        /// </summary>
        public List<Valute> GetListValutes()
        {
            //BusinessLayer.CBService.DailyInfoSoapClient cbservice = new BusinessLayer.CBService.DailyInfoSoapClient();

            //DataSet dsEnumValue = cbservice.EnumValutes(false);

            //DataTable dtValutes = dsEnumValue.Tables[0];

            //List<Valute> listValutes = dtValutes.DataTableToList<Valute>();

            List<Valute> listValutes = new List<Valute>();
            listValutes.Add(new Valute() { Vcode ="R01010", Vname ="Австралийский доллар", VEngname ="Australian Dollar", Vnom = 1, VcommonCode ="R01010", VnumCode = 36, VcharCode ="AUD" });
            listValutes.Add(new Valute() { Vcode ="R01015", Vname ="Австрийский шиллинг", VEngname ="Austrian Shilling", Vnom = 1000, VcommonCode ="R01015", VnumCode = 40, VcharCode ="ATS" });
            listValutes.Add(new Valute() { Vcode ="R01020A", Vname ="Азербайджанский манат", VEngname ="Azerbaijan Manat", Vnom = 1, VcommonCode ="R01020", VnumCode = 944, VcharCode ="AZN" });
            listValutes.Add(new Valute() { Vcode ="R01035", Vname ="Фунт стерлингов Соединенного королевства", VEngname ="British Pound Sterling", Vnom = 1, VcommonCode ="R01035", VnumCode = 826, VcharCode ="GBP" });
            listValutes.Add(new Valute() { Vcode ="R01040F", Vname ="Ангольская новая кванза", VEngname ="Angolan new Kwanza", Vnom = 100000, VcommonCode ="R01040", VnumCode = 24, VcharCode ="AON" });
            listValutes.Add(new Valute() { Vcode ="R01060", Vname ="Армянский драм", VEngname ="Armenia Dram", Vnom = 1000, VcommonCode ="R01060", VnumCode = 51, VcharCode ="AMD" });
            listValutes.Add(new Valute() { Vcode ="R01090", Vname ="Белорусский рубль", VEngname ="Belarussian Ruble", Vnom = 1000, VcommonCode ="R01090", VnumCode = 974, VcharCode ="BYR" });
            listValutes.Add(new Valute() { Vcode ="R01095", Vname ="Бельгийский франк", VEngname ="Belgium Franc", Vnom = 1000, VcommonCode ="R01095", VnumCode = 56, VcharCode ="BEF" });
            listValutes.Add(new Valute() { Vcode ="R01100", Vname ="Болгарский лев", VEngname ="Bulgarian lev", Vnom = 1, VcommonCode ="R01100", VnumCode = 975, VcharCode ="BGN" });
            listValutes.Add(new Valute() { Vcode ="R01115", Vname ="Бразильский реал", VEngname ="Brazil Real", Vnom = 1, VcommonCode ="R01115", VnumCode = 986, VcharCode ="BRL" });
            listValutes.Add(new Valute() { Vcode ="R01135", Vname ="Венгерский форинт", VEngname ="Hungarian Forint", Vnom = 100, VcommonCode ="R01135", VnumCode = 348, VcharCode ="HUF" });
            listValutes.Add(new Valute() { Vcode ="R01205", Vname ="Греческая драхма", VEngname ="Greek Drachma", Vnom = 10000, VcommonCode ="R01205", VnumCode = 300, VcharCode ="GRD" });
            listValutes.Add(new Valute() { Vcode ="R01215", Vname ="Датская крона", VEngname ="Danish Krone", Vnom = 10, VcommonCode ="R01215", VnumCode = 208, VcharCode ="DKK" });
            listValutes.Add(new Valute() { Vcode ="R01235", Vname ="Доллар США", VEngname ="US Dollar", Vnom = 1, VcommonCode ="R01235", VnumCode = 840, VcharCode ="USD" });
            listValutes.Add(new Valute() { Vcode ="R01239", Vname ="Евро", VEngname ="Euro", Vnom = 1, VcommonCode ="R01239", VnumCode = 978, VcharCode ="EUR" });
            listValutes.Add(new Valute() { Vcode ="R01270", Vname ="Индийская рупия", VEngname ="Indian Rupee", Vnom = 100, VcommonCode ="R01270", VnumCode = 356, VcharCode ="INR" });
            listValutes.Add(new Valute() { Vcode ="R01305", Vname ="Ирландский фунт", VEngname ="Irish Pound", Vnom = 100, VcommonCode ="R01305", VnumCode = 372, VcharCode ="IEP" });
            listValutes.Add(new Valute() { Vcode ="R01310", Vname ="Исландская крона", VEngname ="Iceland Krona", Vnom = 10000, VcommonCode ="R01310", VnumCode = 352, VcharCode ="ISK" });
            listValutes.Add(new Valute() { Vcode ="R01315", Vname ="Испанская песета", VEngname ="Spanish Peseta", Vnom = 10000, VcommonCode ="R01315", VnumCode = 724, VcharCode ="ESP" });
            listValutes.Add(new Valute() { Vcode ="R01325", Vname ="Итальянская лира", VEngname ="Italian Lira", Vnom = 100000, VcommonCode ="R01325", VnumCode = 380, VcharCode ="ITL" });
            listValutes.Add(new Valute() { Vcode ="R01335", Vname ="Казахстанский тенге", VEngname ="Kazakhstan Tenge", Vnom = 100, VcommonCode ="R01335", VnumCode = 398, VcharCode ="KZT" });
            listValutes.Add(new Valute() { Vcode ="R01350", Vname ="Канадский доллар", VEngname ="Canadian Dollar", Vnom = 1, VcommonCode ="R01350", VnumCode = 124, VcharCode ="CAD" });
            listValutes.Add(new Valute() { Vcode ="R01370", Vname ="Киргизский сом", VEngname ="Kyrgyzstan Som", Vnom = 100, VcommonCode ="R01370", VnumCode = 417, VcharCode ="KGS" });
            listValutes.Add(new Valute() { Vcode ="R01375", Vname ="Китайский юань", VEngname ="China Yuan", Vnom = 10, VcommonCode ="R01375", VnumCode = 156, VcharCode ="CNY" });
            listValutes.Add(new Valute() { Vcode ="R01390", Vname ="Кувейтский динар", VEngname ="Kuwaiti Dinar", Vnom = 10, VcommonCode ="R01390", VnumCode = 414, VcharCode ="KWD" });
            listValutes.Add(new Valute() { Vcode ="R01405", Vname ="Латвийский лат", VEngname ="Latvian Lat", Vnom = 1, VcommonCode ="R01405", VnumCode = 428, VcharCode ="LVL" });
            listValutes.Add(new Valute() { Vcode ="R01420", Vname ="Ливанский фунт", VEngname ="Lebanese Pound", Vnom = 100000, VcommonCode ="R01420", VnumCode = 422, VcharCode ="LBP" });
            listValutes.Add(new Valute() { Vcode ="R01435", Vname ="Литовский лит", VEngname ="Lithuanian Lita", Vnom = 1, VcommonCode ="R01435", VnumCode = 440, VcharCode ="LTL" });
            listValutes.Add(new Valute() { Vcode ="R01436", Vname ="Литовский талон", VEngname ="Lithuanian talon", Vnom = 1, VcommonCode ="R01435", VnumCode = 0, VcharCode ="" });
            listValutes.Add(new Valute() { Vcode ="R01500", Vname ="Молдавский лей", VEngname ="Moldova Lei", Vnom = 10, VcommonCode ="R01500", VnumCode = 498, VcharCode ="MDL" });
            listValutes.Add(new Valute() { Vcode ="R01510", Vname ="Немецкая марка", VEngname ="Deutsche Mark", Vnom = 1, VcommonCode ="R01510", VnumCode = 276, VcharCode ="DEM" });
            listValutes.Add(new Valute() { Vcode ="R01510A", Vname ="Немецкая марка", VEngname ="Deutsche Mark", Vnom = 100, VcommonCode ="R01510", VnumCode = 280, VcharCode ="DEM" });
            listValutes.Add(new Valute() { Vcode ="R01523", Vname ="Нидерландский гульден", VEngname ="Netherlands Gulden", Vnom = 100, VcommonCode ="R01523", VnumCode = 528, VcharCode ="NLG" });
            listValutes.Add(new Valute() { Vcode ="R01535", Vname ="Норвежская крона", VEngname ="Norwegian Krone", Vnom = 10, VcommonCode ="R01535", VnumCode = 578, VcharCode ="NOK" });
            listValutes.Add(new Valute() { Vcode ="R01565", Vname ="Польский злотый", VEngname ="Polish Zloty", Vnom = 1, VcommonCode ="R01565", VnumCode = 985, VcharCode ="PLN" });
            listValutes.Add(new Valute() { Vcode ="R01570", Vname ="Португальский эскудо", VEngname ="Portuguese Escudo", Vnom = 10000, VcommonCode ="R01570", VnumCode = 620, VcharCode ="PTE" });
            listValutes.Add(new Valute() { Vcode ="R01585", Vname ="Румынский лей", VEngname ="Romanian Leu", Vnom = 10000, VcommonCode ="R01585", VnumCode = 642, VcharCode ="ROL" });
            listValutes.Add(new Valute() { Vcode ="R01585F", Vname ="Новый румынский лей", VEngname ="Romanian Leu", Vnom = 10, VcommonCode ="R01585", VnumCode = 946, VcharCode ="RON" });
            listValutes.Add(new Valute() { Vcode ="R01589", Vname ="СДР (специальные права заимствования)", VEngname ="SDR", Vnom = 1, VcommonCode ="R01589", VnumCode = 960, VcharCode ="XDR" });
            listValutes.Add(new Valute() { Vcode ="R01625", Vname ="Сингапурский доллар", VEngname ="Singapore Dollar", Vnom = 1, VcommonCode ="R01625", VnumCode = 702, VcharCode ="SGD" });
            listValutes.Add(new Valute() { Vcode ="R01665A", Vname ="Суринамский доллар", VEngname ="Surinam Dollar", Vnom = 1, VcommonCode ="R01665", VnumCode = 968, VcharCode ="SRD" });
            listValutes.Add(new Valute() { Vcode ="R01670", Vname ="Таджикский сомони", VEngname ="Tajikistan Ruble", Vnom = 10, VcommonCode ="R01670", VnumCode = 972, VcharCode ="TJS" });
            listValutes.Add(new Valute() { Vcode ="R01670B", Vname ="Таджикский рубл", VEngname ="Tajikistan Ruble", Vnom = 10, VcommonCode ="R01670", VnumCode = 762, VcharCode ="TJR" });
            listValutes.Add(new Valute() { Vcode ="R01700J", Vname ="Турецкая лира", VEngname ="Turkish Lira", Vnom = 1, VcommonCode ="R01700", VnumCode = 949, VcharCode ="TRY" });
            listValutes.Add(new Valute() { Vcode ="R01710", Vname ="Туркменский манат", VEngname ="Turkmenistan Manat", Vnom = 10000, VcommonCode ="R01710", VnumCode = 795, VcharCode ="TMM" });
            listValutes.Add(new Valute() { Vcode ="R01710A", Vname ="Новый туркменский манат", VEngname ="New Turkmenistan Manat", Vnom = 1, VcommonCode ="R01710", VnumCode = 934, VcharCode ="TMT" });
            listValutes.Add(new Valute() { Vcode ="R01717", Vname ="Узбекский сум", VEngname ="Uzbekistan Sum", Vnom = 1000, VcommonCode ="R01717", VnumCode = 860, VcharCode ="UZS" });
            listValutes.Add(new Valute() { Vcode ="R01720", Vname ="Украинская гривна", VEngname ="Ukrainian Hryvnia", Vnom = 10, VcommonCode ="R01720", VnumCode = 980, VcharCode ="UAH" });
            listValutes.Add(new Valute() { Vcode ="R01720A", Vname ="Украинский карбованец", VEngname ="Ukrainian Hryvnia", Vnom = 1, VcommonCode ="R01720", VnumCode = 0, VcharCode ="" });
            listValutes.Add(new Valute() { Vcode ="R01740", Vname ="Финляндская марка", VEngname ="Finnish Marka", Vnom = 100, VcommonCode ="R01740", VnumCode = 246, VcharCode ="FIM" });
            listValutes.Add(new Valute() { Vcode ="R01750", Vname ="Французский франк", VEngname ="French Franc", Vnom = 1000, VcommonCode ="R01750", VnumCode = 250, VcharCode ="FRF" });
            listValutes.Add(new Valute() { Vcode ="R01760", Vname ="Чешская крона", VEngname ="Czech Koruna", Vnom = 10, VcommonCode ="R01760", VnumCode = 203, VcharCode ="CZK" });
            listValutes.Add(new Valute() { Vcode ="R01770", Vname ="Шведская крона", VEngname ="Swedish Krona", Vnom = 10, VcommonCode ="R01770", VnumCode = 752, VcharCode ="SEK" });
            listValutes.Add(new Valute() { Vcode ="R01775", Vname ="Швейцарский франк", VEngname ="Swiss Franc", Vnom = 1, VcommonCode ="R01775", VnumCode = 756, VcharCode ="CHF" });
            listValutes.Add(new Valute() { Vcode ="R01790", Vname ="ЭКЮ", VEngname ="ECU", Vnom = 1, VcommonCode ="R01790", VnumCode = 954, VcharCode ="XEU" });
            listValutes.Add(new Valute() { Vcode ="R01795", Vname ="Эстонская крона", VEngname ="Estonian Kroon", Vnom = 10, VcommonCode ="R01795", VnumCode = 233, VcharCode ="EEK" });
            listValutes.Add(new Valute() { Vcode ="R01805", Vname ="Югославский новый динар", VEngname ="Yugoslavian Dinar", Vnom = 1, VcommonCode ="R01804", VnumCode = 890, VcharCode ="YUN" });
            listValutes.Add(new Valute() { Vcode ="R01810", Vname ="Южноафриканский рэнд", VEngname ="S.African Rand", Vnom = 10, VcommonCode ="R01810", VnumCode = 710, VcharCode ="ZAR" });
            listValutes.Add(new Valute() { Vcode ="R01815", Vname ="Вон Республики Корея", VEngname ="South Korean Won", Vnom = 1000, VcommonCode ="R01815", VnumCode = 410, VcharCode ="KRW" });
            listValutes.Add(new Valute() { Vcode ="R01820", Vname ="Японская иена", VEngname ="Japanese Yen", Vnom = 100, VcommonCode ="R01820", VnumCode = 392, VcharCode ="JPY" });


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