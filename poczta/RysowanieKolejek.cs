using System.Threading;
using System;

namespace poczta
{
    class RysowanieKolejek
    {
        Semaphore Sem = new Semaphore(1, 1);
        DeklaracjaKolejek Kolejki = new DeklaracjaKolejek();
        Random Losowanie = new Random();
        Klient[] Klienci = new Klient[50];
        Thread[] Watki = new Thread[50];

        public void Rysowanie()
        {
            Kolejki.UzupelnienieKolejkiWejsciowej();
            Kolejki.UzupelnienieKolejkiNiebieskiej();
            Kolejki.UzupelnienieKolejkiZielonej();

            for (int i = 0; i < 50; i++)    //tworzenie nowych obiektów klientów
            {
                Klienci[i] = new Klient(i);
                Thread.Sleep(100);
            }

            for (int i = 0; i < 50; i++)    //tworzenie nowych wątków klientów
            {
                Watki[i] = new Thread(RochOsoby);
                //Thread.Sleep(100);
            }

            for (int i = 0; i < 50; i++)
            {
                Watki[i].Start(Convert.ToInt32(i));
                Thread.Sleep(Losowanie.Next(500, 2000));
            }


        }

        private void RochOsoby(object Index)
        {
            while (Klienci[Convert.ToInt32(Index)].MiejsceWKolejceDrugiej < 10)
            {
                Sem.WaitOne();
                Klienci[Convert.ToInt32(Index)].RuchKlienta(Kolejki);
                Sem.Release();
                Thread.Sleep(300);
            }

            if (Klienci[Convert.ToInt32(Index)].MiejsceWKolejceDrugiej == 10) Thread.Sleep(1000);

            while (Klienci[Convert.ToInt32(Index)].MiejsceWKolejceDrugiej <= 12)
            {
                Sem.WaitOne();
                Klienci[Convert.ToInt32(Index)].WyjscieZKolejki(Kolejki);
                Sem.Release();
                Thread.Sleep(300);
            }
        }
    }
}
