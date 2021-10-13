/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:proje
**				ÖĞRENCİ ADI............:
**				ÖĞRENCİ NUMARASI.......:
**              DERSİN ALINDIĞI GRUP...:
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP
{
    class Greyfurt : MeyveSivi
    {
        private string _MeyveAdi;
        private int _PureAgirlik;
        private int _AgirlikGR;
        private int _Avit;
        private int _Cvit;
        public string MeyveAdi
        {
            get
            {
                return _MeyveAdi;
            }
        }
        public int PureAgirlik
        {
            get
            {
                return _PureAgirlik;
            }
        }
        public int AgirlikGR
        {
            get
            {
                return _AgirlikGR;
            }
        }
        public int Avit
        {
            get
            {
                return _Avit;
            }
        }
        public int Cvit
        {
            get
            {
                return _Cvit;
            }
        }
        public override void AHesapla()
        {
            _Avit = (_PureAgirlik * 3) / 100;
        }

        public override void CHesapla()
        {
            _Cvit = (_PureAgirlik * 44) / 100;
        }
        public void Sivi()
        {
            _MeyveAdi = "Greyfurt";
            _AgirlikGR = Agirlik();
            _PureAgirlik = (Agirlik() * Verim()) / 100;
            AHesapla();
            CHesapla();
        }
    }
}
