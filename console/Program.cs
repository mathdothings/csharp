using System.Globalization;

DateOnly thisDate = new DateOnly(2008, 3, 15);
CultureInfo culture = new CultureInfo("pt-BR");
Console.WriteLine(thisDate.ToString(CultureInfo.CurrentCulture));
Console.WriteLine(thisDate.ToString(culture));

System.Console.WriteLine(CultureInfo.CurrentCulture);