﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariumScrum
{
    public class GeenOrganisme: IOrganisme
    {
        public GeenOrganisme(int rij, int kolom)
        {
            this.Rij = rij;
            this.Kolom = kolom;
        }
        public GeenOrganisme()
        {

        }
        public int Rij{get; set;}

        public int Kolom{get; set;}

        public string Tostring()
        {
            return ".";
        }
    }
}
