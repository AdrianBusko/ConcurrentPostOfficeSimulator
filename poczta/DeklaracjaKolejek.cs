namespace poczta
{
    class DeklaracjaKolejek
    {
        public PojedynczaPozycja[] KolejkaWejsciowa = new PojedynczaPozycja[6];
        public PojedynczaPozycja[] KolejkaNiebieska = new PojedynczaPozycja[12];
        public PojedynczaPozycja[] KolejkaZielona = new PojedynczaPozycja[12];
        public int LiczbaOsobWWejsciowej = 0;
        public int LiczbaOsobWNiebieskiej = 0;
        public int LiczbaOsobWZielonej = 0;

        public void UzupelnienieKolejkiWejsciowej()
        {
            KolejkaWejsciowa[0] = new PojedynczaPozycja();
            KolejkaWejsciowa[0].X = 31;
            KolejkaWejsciowa[0].Y = 56;
            KolejkaWejsciowa[0].KtoTuStoi = 100;
            KolejkaWejsciowa[1] = new PojedynczaPozycja();
            KolejkaWejsciowa[1].X = 31;
            KolejkaWejsciowa[1].Y = 51;
            KolejkaWejsciowa[1].KtoTuStoi = 100;
            KolejkaWejsciowa[2] = new PojedynczaPozycja();
            KolejkaWejsciowa[2].X = 31;
            KolejkaWejsciowa[2].Y = 46;
            KolejkaWejsciowa[2].KtoTuStoi = 100;
            KolejkaWejsciowa[3] = new PojedynczaPozycja();
            KolejkaWejsciowa[3].X = 31;
            KolejkaWejsciowa[3].Y = 41;
            KolejkaWejsciowa[3].KtoTuStoi = 100;
            KolejkaWejsciowa[4] = new PojedynczaPozycja();
            KolejkaWejsciowa[4].X = 31;
            KolejkaWejsciowa[4].Y = 36;
            KolejkaWejsciowa[4].KtoTuStoi = 100;
            KolejkaWejsciowa[5] = new PojedynczaPozycja();
            KolejkaWejsciowa[5].X = 31;
            KolejkaWejsciowa[5].Y = 31;
            KolejkaWejsciowa[5].KtoTuStoi = 100;
        }

        public void UzupelnienieKolejkiNiebieskiej()
        {
            KolejkaNiebieska[0] = new PojedynczaPozycja();
            KolejkaNiebieska[0].X = 27;
            KolejkaNiebieska[0].Y = 31;
            KolejkaNiebieska[0].KtoTuStoi = 100;
            KolejkaNiebieska[1] = new PojedynczaPozycja();
            KolejkaNiebieska[1].X = 23;
            KolejkaNiebieska[1].Y = 31;
            KolejkaNiebieska[1].KtoTuStoi = 100;
            KolejkaNiebieska[2] = new PojedynczaPozycja();
            KolejkaNiebieska[2].X = 19;
            KolejkaNiebieska[2].Y = 31;
            KolejkaNiebieska[2].KtoTuStoi = 100;
            KolejkaNiebieska[3] = new PojedynczaPozycja();
            KolejkaNiebieska[3].X = 15;
            KolejkaNiebieska[3].Y = 31;
            KolejkaNiebieska[3].KtoTuStoi = 100;
            KolejkaNiebieska[4] = new PojedynczaPozycja();
            KolejkaNiebieska[4].X = 15;
            KolejkaNiebieska[4].Y = 26;
            KolejkaNiebieska[4].KtoTuStoi = 100;
            KolejkaNiebieska[5] = new PojedynczaPozycja();
            KolejkaNiebieska[5].X = 15;
            KolejkaNiebieska[5].Y = 21;
            KolejkaNiebieska[5].KtoTuStoi = 100;
            KolejkaNiebieska[6] = new PojedynczaPozycja();
            KolejkaNiebieska[6].X = 15;
            KolejkaNiebieska[6].Y = 16;
            KolejkaNiebieska[6].KtoTuStoi = 100;
            KolejkaNiebieska[7] = new PojedynczaPozycja();
            KolejkaNiebieska[7].X = 15;
            KolejkaNiebieska[7].Y = 11;
            KolejkaNiebieska[7].KtoTuStoi = 100;
            KolejkaNiebieska[8] = new PojedynczaPozycja();
            KolejkaNiebieska[8].X = 15;
            KolejkaNiebieska[8].Y = 6;
            KolejkaNiebieska[8].KtoTuStoi = 100;
            KolejkaNiebieska[9] = new PojedynczaPozycja();
            KolejkaNiebieska[9].X = 15;
            KolejkaNiebieska[9].Y = 1;
            KolejkaNiebieska[9].KtoTuStoi = 100;
            KolejkaNiebieska[10] = new PojedynczaPozycja();
            KolejkaNiebieska[10].X = 9;
            KolejkaNiebieska[10].Y = 1;
            KolejkaNiebieska[10].KtoTuStoi = 100;
            KolejkaNiebieska[11] = new PojedynczaPozycja();
            KolejkaNiebieska[11].X = 5;
            KolejkaNiebieska[11].Y = 1;
            KolejkaNiebieska[11].KtoTuStoi = 100;
        }

        public void UzupelnienieKolejkiZielonej()
        {
            KolejkaZielona[0] = new PojedynczaPozycja();
            KolejkaZielona[0].X = 35;
            KolejkaZielona[0].Y = 31;
            KolejkaZielona[0].KtoTuStoi = 100;
            KolejkaZielona[1] = new PojedynczaPozycja();
            KolejkaZielona[1].X = 39;
            KolejkaZielona[1].Y = 31;
            KolejkaZielona[1].KtoTuStoi = 100;
            KolejkaZielona[2] = new PojedynczaPozycja();
            KolejkaZielona[2].X = 43;
            KolejkaZielona[2].Y = 31;
            KolejkaZielona[2].KtoTuStoi = 100;
            KolejkaZielona[3] = new PojedynczaPozycja();
            KolejkaZielona[3].X = 47;
            KolejkaZielona[3].Y = 31;
            KolejkaZielona[3].KtoTuStoi = 100;
            KolejkaZielona[4] = new PojedynczaPozycja();
            KolejkaZielona[4].X = 47;
            KolejkaZielona[4].Y = 26;
            KolejkaZielona[4].KtoTuStoi = 100;
            KolejkaZielona[5] = new PojedynczaPozycja();
            KolejkaZielona[5].X = 47;
            KolejkaZielona[5].Y = 21;
            KolejkaZielona[5].KtoTuStoi = 100;
            KolejkaZielona[6] = new PojedynczaPozycja();
            KolejkaZielona[6].X = 47;
            KolejkaZielona[6].Y = 16;
            KolejkaZielona[6].KtoTuStoi = 100;
            KolejkaZielona[7] = new PojedynczaPozycja();
            KolejkaZielona[7].X = 47;
            KolejkaZielona[7].Y = 11;
            KolejkaZielona[7].KtoTuStoi = 100;
            KolejkaZielona[8] = new PojedynczaPozycja();
            KolejkaZielona[8].X = 47;
            KolejkaZielona[8].Y = 6;
            KolejkaZielona[8].KtoTuStoi = 100;
            KolejkaZielona[9] = new PojedynczaPozycja();
            KolejkaZielona[9].X = 47;
            KolejkaZielona[9].Y = 1;
            KolejkaZielona[9].KtoTuStoi = 100;
            KolejkaZielona[10] = new PojedynczaPozycja();
            KolejkaZielona[10].X = 51;
            KolejkaZielona[10].Y = 1;
            KolejkaZielona[10].KtoTuStoi = 100;
            KolejkaZielona[11] = new PojedynczaPozycja();
            KolejkaZielona[11].X = 56;
            KolejkaZielona[11].Y = 1;
            KolejkaZielona[11].KtoTuStoi = 100;
        }
    
    }
}
