using System;
using System.Diagnostics;
using System.Threading;

namespace poczta
{
    class Klient
    {
        Random R = new Random();
        private ConsoleColor[] TypKlienta = new ConsoleColor[3];
        public int ID;
        public int TypK;
        public int MiejsceWKolejcePierwszej;
        public int MiejsceWKolejceDrugiej;
        public bool FlagaWyboruKolejki;

        public Klient(int id)
        {
            TypKlienta[0] = ConsoleColor.DarkBlue;
            TypKlienta[1] = ConsoleColor.DarkGreen;
            TypKlienta[2] = ConsoleColor.DarkRed;

            ID = id;
            MiejsceWKolejcePierwszej = 0;
            MiejsceWKolejceDrugiej = 0;
            //TypK = R.Next(0, 1) + R.Next(0, 1) + R.Next(0, 1);
            TypK = (R.Next(300) + R.Next(300) + R.Next(300)) % 3;
            Debug.WriteLine("Wylosowano " + TypK);

            FlagaWyboruKolejki = false;
        }

        public void RuchKlienta(DeklaracjaKolejek Kolejki)
        {
            switch (TypK)
            {
                case 0: //klienci niebiescy
                    #region Case 0
                    if (MiejsceWKolejcePierwszej < 6)    //jeżeli jesteśmy w kolejce wstępnej
                    {
                        if (Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].KtoTuStoi == 100)    //jeżeli miejsce na które chcemy wejść jest puste to wchodzimy
                        {
                            if (MiejsceWKolejcePierwszej != 0)  //jeżeli jesteśmy na miejscu drugim to możemy zamazać naszą postać na starym miejscu
                            {
                                Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].KtoTuStoi = 100;
                                ZamazanieKlienta(Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].X, Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].Y);
                            }   
                            Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].KtoTuStoi = ID;  //nadpisujemy miejsce naszym ID klienta
                            RysowanieKlienta(Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].X, Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].Y);
                            MiejsceWKolejcePierwszej++;
                        }
                    }
                    else    //jeżeli przeszliśmy kolejkę wstępną to wchodzimy to kolejki niebieskiej
                    {
                        if (MiejsceWKolejceDrugiej < 10)    //jeżeli weszliśmy do kolejki niebieskiej
                        {
                            if (Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].KtoTuStoi == 100)  //jeżli na naszym planowanym miejscu nikt nie stoi to tam sie przemieszczamy
                            {
                                if (MiejsceWKolejceDrugiej == 0)    //zamazanie miejsca z kolejki wstępnej gdy już jesteśmy w niebieskiej
                                {
                                    Kolejki.KolejkaWejsciowa[5].KtoTuStoi = 100;
                                    ZamazanieKlienta(Kolejki.KolejkaWejsciowa[5].X, Kolejki.KolejkaWejsciowa[5].Y);
                                    Kolejki.LiczbaOsobWNiebieskiej++;
                                }
                                if (MiejsceWKolejceDrugiej != 0)    //zamazanie klienta z kolejki niebieskiej gdy możemy zrobić krok
                                {
                                    Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej - 1].KtoTuStoi = 100;
                                    ZamazanieKlienta(Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej - 1].X, Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej - 1].Y);
                                }

                                Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].KtoTuStoi = ID;
                                RysowanieKlienta(Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].X, Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].Y);
                                MiejsceWKolejceDrugiej++;
                            }
                        }
                    }
                    //Thread.Sleep(300);
                    break;
                    #endregion   
                case 1: //klienci zieloni
                    #region Case 1
                    if (MiejsceWKolejcePierwszej < 6)    //jeżeli jesteśmy w kolejce wstępnej
                    {
                        if (Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].KtoTuStoi == 100)    //jeżeli miejsce na które chcemy wejść jest puste to wchodzimy
                        {
                            if (MiejsceWKolejcePierwszej != 0)  //jeżeli jesteśmy na miejscu drugim to możemy zamazać naszą postać na starym miejscu
                            {
                                Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].KtoTuStoi = 100;
                                ZamazanieKlienta(Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].X, Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].Y);
                            }
                            Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].KtoTuStoi = ID;    //nadpisujemy miejsce naszym ID klienta
                            RysowanieKlienta(Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].X, Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].Y);
                            MiejsceWKolejcePierwszej++;
                        }
                    }
                    else
                    {
                        if (MiejsceWKolejceDrugiej < 10)    //jeżeli weszliśmy do kolejki zielonej
                        {
                            if (Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].KtoTuStoi == 100)  //jeżli na naszym planowanym miejscu nikt nie stoi to tam sie przemieszczamy
                            {
                                if (MiejsceWKolejceDrugiej == 0)    //zamazanie miejsca z kolejki wstępnej gdy już jesteśmy w zielonej
                                {
                                    Kolejki.KolejkaWejsciowa[5].KtoTuStoi = 100;
                                    ZamazanieKlienta(Kolejki.KolejkaWejsciowa[5].X, Kolejki.KolejkaWejsciowa[5].Y);
                                    Kolejki.LiczbaOsobWZielonej++;
                                }
                                if (MiejsceWKolejceDrugiej != 0)    //zamazanie klienta z kolejki zielonej gdy możemy zrobić krok
                                {
                                    Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej - 1].KtoTuStoi = 100;
                                    ZamazanieKlienta(Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej - 1].X, Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej - 1].Y);
                                }

                                Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].KtoTuStoi = ID;
                                RysowanieKlienta(Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].X, Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].Y);
                                MiejsceWKolejceDrugiej++;
                            }

                        }
                    }
                   // Thread.Sleep(600);
                    break;
                    #endregion
                case 2: //klienci czerwoni
                    #region Case2
                    if (MiejsceWKolejcePierwszej < 6)    //jeżeli jesteśmy w kolejce wstępnej
                    {
                        if (Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].KtoTuStoi == 100)    //jeżeli miejsce na które chcemy wejść jest puste to wchodzimy
                        {
                            if (MiejsceWKolejcePierwszej != 0)  //jeżeli jesteśmy na miejscu drugim to możemy zamazać naszą postać na starym miejscu
                            {
                                ZamazanieKlienta(Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].X, Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej - 1].Y);
                            }
                            RysowanieKlienta(Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].X, Kolejki.KolejkaWejsciowa[MiejsceWKolejcePierwszej].Y);
                            MiejsceWKolejcePierwszej++;

                            if (MiejsceWKolejcePierwszej == 6)  //wybór kolejki w zależności od liczby osób w każdej z nich
                            {
                                if (Kolejki.LiczbaOsobWNiebieskiej <= Kolejki.LiczbaOsobWZielonej) FlagaWyboruKolejki = true;   //true oznacza kolejkę niebieską, false natomiast zieloną
                            }
                        }
                    }
                    else
                    {
                        if (FlagaWyboruKolejki)  //idziemy do niebieskiej
                        {
                            if (MiejsceWKolejceDrugiej < 10)
                            {
                                if (Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].KtoTuStoi == 100)  //jeżli na naszym planowanym miejscu nikt nie stoi to tam sie przemieszczamy
                                {
                                    if (MiejsceWKolejceDrugiej == 0)    //zamazanie miejsca z kolejki wstępnej gdy już jesteśmy w niebieskiej
                                    {
                                        Kolejki.KolejkaWejsciowa[5].KtoTuStoi = 100;
                                        ZamazanieKlienta(Kolejki.KolejkaWejsciowa[5].X, Kolejki.KolejkaWejsciowa[5].Y);
                                        Kolejki.LiczbaOsobWNiebieskiej++;
                                    }
                                    if (MiejsceWKolejceDrugiej != 0)
                                    {
                                        Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej - 1].KtoTuStoi = 100;
                                        ZamazanieKlienta(Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej - 1].X, Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej - 1].Y);
                                    }

                                    Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].KtoTuStoi = ID;
                                    RysowanieKlienta(Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].X, Kolejki.KolejkaNiebieska[MiejsceWKolejceDrugiej].Y);
                                    MiejsceWKolejceDrugiej++;
                                }
                            }
                        }
                        else
                        {
                            if (MiejsceWKolejceDrugiej < 10)
                            {
                                if (Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].KtoTuStoi == 100)  //jeżli na naszym planowanym miejscu nikt nie stoi to tam sie przemieszczamy
                                {
                                    if (MiejsceWKolejceDrugiej == 0)    //zamazanie miejsca z kolejki wstępnej gdy już jesteśmy w zielonej
                                    {
                                        Kolejki.KolejkaWejsciowa[5].KtoTuStoi = 100;
                                        ZamazanieKlienta(Kolejki.KolejkaWejsciowa[5].X, Kolejki.KolejkaWejsciowa[5].Y);
                                        Kolejki.LiczbaOsobWZielonej++;
                                    }
                                    if (MiejsceWKolejceDrugiej != 0)
                                    {
                                        Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej - 1].KtoTuStoi = 100;
                                        ZamazanieKlienta(Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej - 1].X, Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej - 1].Y);
                                    }

                                    Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].KtoTuStoi = ID;
                                    RysowanieKlienta(Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].X, Kolejki.KolejkaZielona[MiejsceWKolejceDrugiej].Y);
                                    MiejsceWKolejceDrugiej++;

                                }
                            }
                        }
                    }
                    //Thread.Sleep(300);
                    break;
                    #endregion
                default:
                    break;
            }
        }

        public void WyjscieZKolejki(DeklaracjaKolejek Kolejki)
        {
            switch (TypK)
            {
                case 0:
                    if (MiejsceWKolejceDrugiej == 12)
                    {
                        ZamazanieKlienta(Kolejki.KolejkaNiebieska[11].X, Kolejki.KolejkaNiebieska[11].Y);
                        Kolejki.KolejkaNiebieska[11].KtoTuStoi = 100;
                    }
                    if (MiejsceWKolejceDrugiej == 11)
                    {
                        ZamazanieKlienta(Kolejki.KolejkaNiebieska[10].X, Kolejki.KolejkaNiebieska[10].Y);
                        RysowanieKlienta(Kolejki.KolejkaNiebieska[11].X, Kolejki.KolejkaNiebieska[11].Y);
                        Kolejki.KolejkaNiebieska[10].KtoTuStoi = 100;
                        Kolejki.KolejkaNiebieska[11].KtoTuStoi = ID;
                        MiejsceWKolejceDrugiej++;
                    }
                    if (MiejsceWKolejceDrugiej == 10)
                    {
                        ZamazanieKlienta(Kolejki.KolejkaNiebieska[9].X, Kolejki.KolejkaNiebieska[9].Y);
                        RysowanieKlienta(Kolejki.KolejkaNiebieska[10].X, Kolejki.KolejkaNiebieska[10].Y);
                        Kolejki.KolejkaNiebieska[9].KtoTuStoi = 100;
                        Kolejki.KolejkaNiebieska[10].KtoTuStoi = ID;
                        MiejsceWKolejceDrugiej++;
                        Kolejki.LiczbaOsobWNiebieskiej--;
                    }
                    break;

                case 1:
                    if (MiejsceWKolejceDrugiej == 12)
                    {
                        ZamazanieKlienta(Kolejki.KolejkaZielona[11].X, Kolejki.KolejkaZielona[11].Y);
                        Kolejki.KolejkaZielona[11].KtoTuStoi = 100;
                    }
                    if (MiejsceWKolejceDrugiej == 11)
                    {
                        ZamazanieKlienta(Kolejki.KolejkaZielona[10].X, Kolejki.KolejkaZielona[10].Y);
                        RysowanieKlienta(Kolejki.KolejkaZielona[11].X, Kolejki.KolejkaZielona[11].Y);
                        Kolejki.KolejkaZielona[10].KtoTuStoi = 100;
                        Kolejki.KolejkaZielona[11].KtoTuStoi = ID;
                        MiejsceWKolejceDrugiej++;
                    }
                    if (MiejsceWKolejceDrugiej == 10)
                    {
                        ZamazanieKlienta(Kolejki.KolejkaZielona[9].X, Kolejki.KolejkaZielona[9].Y);
                        RysowanieKlienta(Kolejki.KolejkaZielona[10].X, Kolejki.KolejkaZielona[10].Y);
                        Kolejki.KolejkaZielona[9].KtoTuStoi = 100;
                        Kolejki.KolejkaZielona[10].KtoTuStoi = ID;
                        MiejsceWKolejceDrugiej++;
                        Kolejki.LiczbaOsobWZielonej--;
                    }
                    break;

                case 2:
                    if (FlagaWyboruKolejki)
                    {
                        if (MiejsceWKolejceDrugiej == 12)
                        {
                            ZamazanieKlienta(Kolejki.KolejkaNiebieska[11].X, Kolejki.KolejkaNiebieska[11].Y);
                            Kolejki.KolejkaNiebieska[11].KtoTuStoi = 100;
                        }
                        if (MiejsceWKolejceDrugiej == 11)
                        {
                            ZamazanieKlienta(Kolejki.KolejkaNiebieska[10].X, Kolejki.KolejkaNiebieska[10].Y);
                            RysowanieKlienta(Kolejki.KolejkaNiebieska[11].X, Kolejki.KolejkaNiebieska[11].Y);
                            Kolejki.KolejkaNiebieska[10].KtoTuStoi = 100;
                            Kolejki.KolejkaNiebieska[11].KtoTuStoi = ID;
                            MiejsceWKolejceDrugiej++;
                        }
                        if (MiejsceWKolejceDrugiej == 10)
                        {
                            ZamazanieKlienta(Kolejki.KolejkaNiebieska[9].X, Kolejki.KolejkaNiebieska[9].Y);
                            RysowanieKlienta(Kolejki.KolejkaNiebieska[10].X, Kolejki.KolejkaNiebieska[10].Y);
                            Kolejki.KolejkaNiebieska[9].KtoTuStoi = 100;
                            Kolejki.KolejkaNiebieska[10].KtoTuStoi = ID;
                            MiejsceWKolejceDrugiej++;
                            Kolejki.LiczbaOsobWNiebieskiej--;
                        }
                    }
                    else
                    {
                        if (MiejsceWKolejceDrugiej == 12)
                        {
                            ZamazanieKlienta(Kolejki.KolejkaZielona[11].X, Kolejki.KolejkaZielona[11].Y);
                            Kolejki.KolejkaZielona[11].KtoTuStoi = 100;
                        }
                        if (MiejsceWKolejceDrugiej == 11)
                        {
                            ZamazanieKlienta(Kolejki.KolejkaZielona[10].X, Kolejki.KolejkaZielona[10].Y);
                            RysowanieKlienta(Kolejki.KolejkaZielona[11].X, Kolejki.KolejkaZielona[11].Y);
                            Kolejki.KolejkaZielona[10].KtoTuStoi = 100;
                            Kolejki.KolejkaZielona[11].KtoTuStoi = ID;
                            MiejsceWKolejceDrugiej++;
                        }
                        if (MiejsceWKolejceDrugiej == 10)
                        {
                            ZamazanieKlienta(Kolejki.KolejkaZielona[9].X, Kolejki.KolejkaZielona[9].Y);
                            RysowanieKlienta(Kolejki.KolejkaZielona[10].X, Kolejki.KolejkaZielona[10].Y);
                            Kolejki.KolejkaZielona[9].KtoTuStoi = 100;
                            Kolejki.KolejkaZielona[10].KtoTuStoi = ID;
                            MiejsceWKolejceDrugiej++;
                            Kolejki.LiczbaOsobWZielonej--;
                        }
                    }
                    break;
            }
        }

        public void RysowanieKlienta(int X, int Y)
        {
            Console.ForegroundColor = TypKlienta[TypK];
            Console.SetCursorPosition(X, Y);
            Console.Write("X");
            Console.SetCursorPosition(X - 1, Y + 1);
            Console.Write("X");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write("X");
            Console.SetCursorPosition(X + 1, Y + 1);
            Console.Write("X");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write("X");
            Console.SetCursorPosition(X - 1, Y + 3);
            Console.Write("X");
            Console.SetCursorPosition(X + 1, Y + 3);
            Console.Write("X");
        }

        public void ZamazanieKlienta(int X, int Y)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
            Console.SetCursorPosition(X - 1, Y + 1);
            Console.Write(" ");
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(" ");
            Console.SetCursorPosition(X + 1, Y + 1);
            Console.Write(" ");
            Console.SetCursorPosition(X, Y + 2);
            Console.Write(" ");
            Console.SetCursorPosition(X - 1, Y + 3);
            Console.Write(" ");
            Console.SetCursorPosition(X + 1, Y + 3);
            Console.Write(" ");
        }
    }
}
