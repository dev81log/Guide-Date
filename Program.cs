using System.Globalization;

var dataModel = new DateTime(2022, 05, 25, 12, 30, 10);

Console.WriteLine(dataModel);
Console.WriteLine(dataModel.Year);
Console.WriteLine(dataModel.Month);
Console.WriteLine(dataModel.Day);
Console.WriteLine((int)dataModel.DayOfWeek);

Console.WriteLine("=================");

var data = DateTime.Now;

var formatado = String.Format("{0:dd/MM/yyyy hh:mm:ss z}", data); // local
var formatadoSystem = String.Format("{0:R}", data); // system
var formatadoJson = String.Format("{0:s}", data); // json
var formatadoUniversal = String.Format("{0:u}", data); // universal


Console.Clear();
Console.WriteLine(formatado);
Console.WriteLine(formatadoSystem);
Console.WriteLine(formatadoJson);
Console.WriteLine(formatadoUniversal);

Console.WriteLine("=================");

var dia = data.AddDays(10);
var mes = data.AddMonths(1);
var ano = data.AddYears(1);

Console.WriteLine(dia);
Console.WriteLine(mes);
Console.WriteLine(ano);

if (data.Date == DateTime.Today)
    Console.WriteLine("igual");

Console.WriteLine(data);

Console.WriteLine("=================");

var pt = new CultureInfo("pt-BR");
var de = new CultureInfo("de-DE");

Console.WriteLine(DateTime.Now.ToString("D", pt));
Console.WriteLine(DateTime.Now.ToString("D", de));

var timeZoneAustralia =
    TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

Console.WriteLine(timeZoneAustralia);

Console.WriteLine("=================");

var timeSpan = new TimeSpan();
Console.WriteLine(timeSpan);