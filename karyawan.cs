﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class karyawan
    {
        //constructor 
        public karyawan()
        {

        }
        // overload constructor 
        public Karyawan (string nama, string nik, int gajibulanan)
        {
            NAMA = nama;
            NIK = nik;
            GajiBulanan = gajibulanan;
        }
        // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }


    }




}
