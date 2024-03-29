﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domari
{
    public class Student : Korisnik
    {
        #region Atributi

        static int trenutniBroj = 0;
        int identifikacioniBroj;
        LicniPodaci podaci;
        List<string> prebivaliste;
        Skolovanje skolovanje;
        double stanjeRacuna;

        #endregion

        #region Properties

        public int IdentifikacioniBroj
        {
            get => identifikacioniBroj;
        }
        public LicniPodaci Podaci
        {
            get => podaci;
            set => podaci = value;
        }
        public List<string> Prebivaliste
        {
            get => prebivaliste;
            set => prebivaliste = value;
        }
        public Skolovanje Skolovanje
        {
            get => skolovanje;
            set => skolovanje = value;
        }
        public double StanjeRacuna
        {
            get => stanjeRacuna;
        }

        #endregion

        #region Konstruktor

        public Student(string user, string pass, LicniPodaci data, List<string> address, Skolovanje school)
            : base(user, pass)
        {
            Podaci = data;
            Skolovanje = school;

            if (address == null)
                Prebivaliste = new List<string>();
            else
                Prebivaliste = address;

            trenutniBroj += 1;
            identifikacioniBroj = trenutniBroj;

            stanjeRacuna = 1000.00;
        }

        public Student()
        {

        }

        #endregion

        #region Metode

        public void AzurirajStanjeRacuna(double iznos)
        {
            stanjeRacuna += iznos;
        }

        /// <summary>
        /// Metoda u kojoj se vrši promjena fakulteta ili upis na sljedeću godinu studija.
        /// Ukoliko student mijenja fakultet ili ciklus studija, potrebno je da mu se generiše
        /// novi broj indeksa prema postojećoj logici.
        /// </summary>
        /// <param name="iznos"></param>
        public void PromjenaInformacijaOSkolovanju(string fakultet, int godina, int ciklus)
        {
            //implementacija - Faris Colakovic
            if (Skolovanje.MaticniFakultet != fakultet || Skolovanje.CiklusStudija != ciklus)
            {
                Skolovanje s = new Skolovanje();//ovim ce se generisati novi broj indeksa
                s.MaticniFakultet = fakultet;
                s.GodinaStudija = godina;
                s.CiklusStudija = ciklus;
                //novo skolovanje stavljamo umjesto postojeceg
                Skolovanje = s;
            }
            else
            {
                //ovdje samo godinu postavljamo jer ako se promijenio faks ili ciklus u prvom ce if-u biti handlan
                Skolovanje.GodinaStudija = godina;
            }
            //throw new NotImplementedException();
        }

        #endregion
    }
}
