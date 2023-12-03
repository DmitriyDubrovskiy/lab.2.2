using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usdRate;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eurRate;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / plnRate;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * usdRate;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * eurRate;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * plnRate;
    }
}
