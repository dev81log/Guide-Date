

//var data = new DateTime(2022, 05, 25, 12, 30, 10);
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



// Console.WriteLine(data);
// Console.WriteLine(data.Year);
// Console.WriteLine(data.Month);
// Console.WriteLine(data.Day);
// Console.WriteLine((int)data.DayOfWeek);

