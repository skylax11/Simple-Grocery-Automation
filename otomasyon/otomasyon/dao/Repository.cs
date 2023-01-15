using otomasyon.enumaration;
using otomasyon.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.dao
{
    internal class Repository
    {
        List<urun2> ürünler;
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> logintableList3;
        public Repository()
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-Q52NUQH\SQLEXPRESS;Initial Catalog=market;User ID=sa;password=1");
        }
        public loginStatus login(string kullanıcıadi, string sifre)
        {
            connect.Open();
            cmd = new SqlCommand("login_sp", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciadi", kullanıcıadi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = (int)cmd.ExecuteScalar();
            connect.Close();

            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }

        }
        public List<LoginTable> getLoginTable()
        {
            logintableList3 = new List<LoginTable>();
            connect.Open();
            cmd = new SqlCommand("select * from loginTable", connect);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoginTable logintable = new LoginTable();
                logintable.id = int.Parse(dr["id"].ToString());
                logintable.sifre = dr["sifre"].ToString();
                logintable.yetki = dr["yetki"].ToString();
                logintable.email = dr["email"].ToString();
                logintable.bolge = dr["bolge"].ToString();
                logintable.guvenliksoru = dr["guvenlikSorusu"].ToString();
                logintable.guvenliksoruCevabı = dr["guvenlikCevabi"].ToString();
                logintable.ka = dr["kullaniciAdi"].ToString();
                logintableList3.Add(logintable);
            }
            connect.Close();
            return logintableList3;
        }
        public loginStatus doAuthentication(string ka, string guvenliksoru, string guvenlikcevabi)
        {
            connect.Open();
            cmd = new SqlCommand("select count(*) from logintable where kullaniciAdi=@ka and guvenlikSorusu=@guvenliksoru and guvenlikCevabi=@guvenlikcevabi", connect);
            cmd.Parameters.AddWithValue("@ka", ka);
            cmd.Parameters.AddWithValue("@guvenliksoru", guvenliksoru);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", guvenlikcevabi);
            returnvalue = (int)cmd.ExecuteScalar();
            connect.Close();
            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public loginStatus sifreDegistir(string ka, string sifre)
        {
            connect.Open();
            cmd = new SqlCommand("sifreGuncelle_sp", connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", ka);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            int donendeger = cmd.ExecuteNonQuery();
            connect.Close();
            if (donendeger == 1)
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
            connect.Open();
            cmd = new SqlCommand("select email from loginTable where email = @email", connect);
            cmd.Parameters.AddWithValue("@email", email).Value = email;
            string gelendeger = (string)cmd.ExecuteScalar();
            connect.Close();
            if (gelendeger == email)
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
            connect.Open();
            cmd = new SqlCommand("select yetki from loginTable where kullaniciAdi = @ka", connect);
            cmd.Parameters.AddWithValue("@ka", ka);
            string yetki = cmd.ExecuteScalar().ToString();
            connect.Close();
            return yetki;

        }
        public urun getUrun(string barkod)
        {
            connect.Open();
            cmd = new SqlCommand("select fiyat,urunIsim from Urun where barkod = @barkod", connect);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            dr = cmd.ExecuteReader();
            urun urun1 = new urun();
            while (dr.Read())
            {
                urun1.urunAdi = dr["urunIsim"].ToString();
                urun1.urunFiyat = int.Parse(dr["fiyat"].ToString());
            }
            connect.Close();
            return urun1;
        }
        public loginStatus kullaniciEkle(string ka, string sifre, string yetki, string bolge, string email, string soru, string cevap)
        {
            connect.Open();
            cmd = new SqlCommand("insert into loginTable (kullaniciAdi,sifre,yetki,bolge,email,guvenlikSorusu,guvenlikCevabi) values (@ka,@sifre,@yetki,@bolge,@email,@soru,@cevap)", connect);
            cmd.Parameters.AddWithValue("@ka", ka);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.Parameters.AddWithValue("@yetki", yetki);
            cmd.Parameters.AddWithValue("@bolge", bolge);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.Parameters.AddWithValue("@soru", soru);
            cmd.Parameters.AddWithValue("@cevap", cevap);
            int gelendeger = cmd.ExecuteNonQuery();
            connect.Close();
            if (gelendeger == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public void kullaniciSil(string ka, string sifre)
        {
            connect.Open();
            cmd = new SqlCommand("delete from loginTable where kullaniciAdi = @ka and sifre = @sifre", connect);
            cmd.Parameters.AddWithValue("@ka", ka);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            int gelendeger = cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void guncelle(string ka, string sifre, string yetki, string bolge, string email, string soru, string cevap, int id)
        {
            connect.Open();
            cmd = new SqlCommand("update loginTable set kullaniciAdi = @ka, sifre=@sifre, yetki=@yetki,bolge=@bolge, email=@email, guvenlikSorusu=@soru,guvenlikCevabi=@cevap where id=@id", connect);
            cmd.Parameters.AddWithValue("@ka", ka);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.Parameters.AddWithValue("@yetki", yetki);
            cmd.Parameters.AddWithValue("@bolge", bolge);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@soru", soru);
            cmd.Parameters.AddWithValue("@cevap", cevap);
            cmd.Parameters.AddWithValue("@id", id);
            int a = cmd.ExecuteNonQuery();
            connect.Close();
        }
        public List<urun2> getUrun()
        {
            ürünler = new List<urun2>();
            connect.Open();
            cmd = new SqlCommand("select * from Urun", connect);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                urun2 ürün = new urun2();
                ürün.id = int.Parse(dr["id"].ToString());
                ürün.urunIsim = dr["urunIsim"].ToString();
                ürün.barkod = dr["barkod"].ToString();
                ürün.guncellenmeTarih = Convert.ToDateTime(dr["guncellenme_Tarih"].ToString());
                ürün.olusturmaTarih = Convert.ToDateTime(dr["olusturulma_Tarih"].ToString());
                ürün.kilo = Convert.ToDouble((dr["kilo"].ToString()));
                ürün.fiyat = int.Parse(dr["fiyat"].ToString());
                ürün.ciro = int.Parse(dr["ciro"].ToString());
                ürünler.Add(ürün);
            }
            connect.Close();
            return ürünler;
        }
        public void urunEkle(int id,string ad, string barkod, DateTime olusma, DateTime guncellenme, double kg, int fiyat, int ciro)
        {
            connect.Open();
            cmd = new SqlCommand("insert into Urun (id,urunIsim,barkod,olusturulma_Tarih,guncellenme_Tarih,kilo,fiyat,ciro) values (@id,@ad,@barkod,@olusma,@guncellenme,@kg,@fiyat,@ciro)", connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            cmd.Parameters.AddWithValue("@olusma", olusma);
            cmd.Parameters.AddWithValue("@guncellenme", guncellenme);
            cmd.Parameters.AddWithValue("@kg", kg);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            cmd.Parameters.AddWithValue("@ciro", ciro);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void guncelTarih(int id)
        {
            connect.Open();
            cmd = new SqlCommand("execute guncel_sp @id = @id", connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void urunGuncelle(int id, string ad, string barkod, DateTime olusma, DateTime guncellenme, double kg, int fiyat, int ciro)
        {
            connect.Open();
            cmd = new SqlCommand("update Urun set id = @id , urunIsim = @ad, barkod=@barkod, olusturulma_Tarih = @olusma, guncellenme_Tarih = @guncellenme, kilo = @kg , fiyat = @fiyat , ciro = @ciro where id=@id or urunIsim = @ad", connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@barkod", barkod);
            cmd.Parameters.AddWithValue("@olusma", olusma);
            cmd.Parameters.AddWithValue("@guncellenme", guncellenme);
            cmd.Parameters.AddWithValue("@kg", kg);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            cmd.Parameters.AddWithValue("@ciro", ciro);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void urunSil(string ad)
        {
            connect.Open();
            cmd = new SqlCommand("delete from Urun where urunIsim = @ad", connect);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

    }
}
