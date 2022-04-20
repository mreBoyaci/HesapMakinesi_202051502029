class HesapMakinesi
{
    public static double islemYap(double sayi1, double sayi2, string op)
    {
        // operatör değerine göre case işlemlerinden biri gerçekleştirilir.
        switch (op)
        {
            case "+": return sayi1 + sayi2;
            case "-": return sayi1 - sayi2;
            case "*": return sayi1 * sayi2;
            case "/":
                // 2. sayı 0 değilse işlemi yapar.
                if (sayi2 != 0)
                {
                    return sayi1 / sayi2;
                }
                else
                {
                    return double.NaN;
                }
            default: return double.NaN;
        }
    }
}
