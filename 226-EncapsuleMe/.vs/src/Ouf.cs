using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsuleMe
{
    public class Ouf
    {
        #region private attributs
        private int laf;
        private float oursk;
        private string mixtesas;
        #endregion private attributs

        #region constructors
        public Ouf(int aslk, float vlugrp, string akalk)
        {
            this.laf = aslk;
            this.oursk = vlugrp;
            this.mixtesas = akalk;
        }

        #endregion constructors

        public int Laf
        {
            get { return this.laf;  }
            set { this.laf = value; }
        }

        public float Oursk
        {
            get { return this.oursk; }
        }

        public string Mixtesas
        {
            get { return this.mixtesas; }
        }
    }
}
