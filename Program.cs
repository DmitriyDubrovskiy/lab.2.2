class Program
{
    static void Main()
    {
        // Ініціалізація об'єкта Converter з курсами валют
        Converter converter = new Converter(usd: 27.50, eur: 32.10, pln: 7.20);

        // Конвертація гривні у валюти
        double uahAmount = 1000;
        Console.WriteLine($"{uahAmount} гривень у USD: {converter.ConvertToUSD(uahAmount)}");
        Console.WriteLine($"{uahAmount} гривень у EUR: {converter.ConvertToEUR(uahAmount)}");
        Console.WriteLine($"{uahAmount} гривень у PLN: {converter.ConvertToPLN(uahAmount)}");

        // Конвертація валют у гривню
        double usdAmount = 50;
        double eurAmount = 40;
        double plnAmount = 120;

        Console.WriteLine($"{usdAmount} USD у гривні: {converter.ConvertFromUSD(usdAmount)}");
        Console.WriteLine($"{eurAmount} EUR у гривні: {converter.ConvertFromEUR(eurAmount)}");
        Console.WriteLine($"{plnAmount} PLN у гривні: {converter.ConvertFromPLN(plnAmount)}");
    }
}