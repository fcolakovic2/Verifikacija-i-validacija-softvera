﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domari
{
    public class Skolovanje
    {
        #region Atributi

        string maticniFakultet, brojIndeksa;
        int godinaStudija, ciklusStudija;

        #endregion

        #region Properties

        public string MaticniFakultet
        {
            get => maticniFakultet;
            set => maticniFakultet = value;
        }
        public string BrojIndeksa
        {
            get => brojIndeksa;
            set => brojIndeksa = value;
        }
        public int GodinaStudija
        {
            get => godinaStudija;
            set => godinaStudija = value;
        }
        public int CiklusStudija
        {
            get => ciklusStudija;
            set => ciklusStudija = value;
        }

        #endregion

        #region Konstruktor

        public Skolovanje()
        {
            maticniFakultet = "Elektrotehnički fakultet";
            brojIndeksa = StudentskiDom.GenerišiSljedećiBroj();
            GodinaStudija = 1;
            CiklusStudija = 1;
        }

        #endregion

        #region Metode

        public double PromjenaGodineStudija(int godina, int ciklus)
        {
            this.GodinaStudija = godina;
            this.CiklusStudija = ciklus;
            if (ciklus == 1) return 1800;
            else if (ciklus == 2) return 2000;
            else
            {
                throw new System.ArgumentException("Parametri nisu validni.");
            }
        }

        #endregion
    }
}
