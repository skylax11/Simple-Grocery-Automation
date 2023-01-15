using otomasyon.dao;
using otomasyon.enumaration;
using System;
using otomasyon.model;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace otomasyon.controller
{
    internal class Controller
    {
        static string yetki;
        Repository repository;
        public Controller()
        {
            repository = new Repository();
        }
        public loginStatus login(string kullanıcıadi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullanıcıadi) && !string.IsNullOrEmpty(sifre))
            {
                loginStatus result = repository.login(kullanıcıadi, sifre);
                return result;
            }
            else
            {
                return loginStatus.eksikParametre;

            }

        }
        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> logintablelist = repository.getLoginTable();
            return logintablelist;
        }
        public loginStatus doAuthentication(string ka, string guvenliksoru, string guvenlikcevabi)
        {
            if (!string.IsNullOrEmpty(ka) && !string.IsNullOrEmpty(guvenliksoru) && !string.IsNullOrEmpty(guvenlikcevabi))
            {
                loginStatus result = repository.doAuthentication(ka, guvenliksoru, guvenlikcevabi);
                if (result == loginStatus.basarili)
                {
                    return result;

                }
                else
                {
                    return loginStatus.basarisiz;
                }
            }
            else
            {
                return loginStatus.eksikParametre;
            }

        }
        public loginStatus sifreDegistir(string ka, string sifre)
        {
            loginStatus gelendeger = repository.sifreDegistir(ka, sifre);
            if (gelendeger == loginStatus.basarili && !string.IsNullOrEmpty(ka) && !string.IsNullOrEmpty(sifre))
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public loginStatus checkEmailAddress(string email)
        {
            loginStatus gelendeger = repository.checkEmailAddress(email);
            if (gelendeger == loginStatus.basarili)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public string getAccess(string ka)
        {
            yetki = repository.getAccess(ka);

            return yetki;
        }
        public urun getUrun(string barkod)
        {
            urun gelenurun = repository.getUrun(barkod);
            return gelenurun;
        }
        public loginStatus kullaniciEkle(string ka, string sifre, string yetki, string bolge, string email, string soru, string cevap)
        {
            loginStatus gelendeger = repository.kullaniciEkle(ka, sifre, yetki, bolge, email, soru, cevap);
            return gelendeger;
        }

        public void kullaniciSil(string ka, string sifre)
        {
            repository.kullaniciSil(ka, sifre);
        }

        public void guncelle(string ka, string sifre, string yetki, string bolge, string email, string soru, string cevap, int id)
        {
            repository.guncelle(ka, sifre, yetki, bolge, email, soru, cevap, id);
        }
        public List<urun2> geturun()
        {
            List<urun2> gelenurun = repository.getUrun();
            return gelenurun;
        }
        public void urunekle(int id,string ad, string barkod, DateTime olusma, DateTime guncellenme, double kg, int fiyat, int ciro)
        {
            repository.urunEkle(id,ad, barkod, olusma, guncellenme, kg, fiyat, ciro);
        }
        public void guncel(int id)
        {
            repository.guncelTarih(id);
        }
        public void urunGuncelle(int id, string ad, string barkod, DateTime olusma, DateTime guncellenme, double kg, int fiyat, int ciro)
        {
            repository.urunGuncelle(id, ad, barkod, olusma, guncellenme, kg, fiyat, ciro);
        }
        public void urunSil(string ad)
        {
            repository.urunSil(ad);
        }
    }
}

