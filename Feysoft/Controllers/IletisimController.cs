using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Feysoft.Data.Models;
using System.Net.Mail;
using System.Net;

namespace Feysoft.Controllers
{
    public class IletisimController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
     
        public IActionResult Index(Email model)
        {




            //MailMessage mailim = new MailMessage();
            //mailim.To.Add("info@feysoft.com.tr");
            //mailim.From = new MailAddress("oruchankural@gmail.com");
            //mailim.Subject = "Konu : " + model.Subject;
            //mailim.Body = "Sayın yetkili, mesaj gönderen kişinin <b>adı ve soyadı</b> : <br>" + model.NameSurname + "<br>" + "<b>Konu</b> : <br>" + model.Subject;
            //mailim.IsBodyHtml = true;

            //SmtpClient smtp = new SmtpClient("mail.feysoft.com.tr", 587);
            //smtp.Credentials = new NetworkCredential("info@feysoft.com.tr", "1.FeYs.1");
            ////smtp.Port = 587;
            //smtp.UseDefaultCredentials = false;
            //smtp.EnableSsl = false;
            //smtp.Host = "smtp.gmail.com";


            //MailMessage mailim = new MailMessage();
            //mailim.To.Add("info@ozenlegal.com");
            //mailim.From = new MailAddress(model.EmailAdd);
            //mailim.Subject = "Gelen Mesaj : " + model.Subject;
            //mailim.Body = " Mail <b>İçeriği</b> : <br>" + model.Message;
            //mailim.IsBodyHtml = true;

            //SmtpClient smtp = new SmtpClient();
            //smtp.Credentials = new NetworkCredential("info@ozenlegal.com", "OzenLegal21**");
            //smtp.Port = 587;
            //smtp.Host = "mail.ozenlegal.com";


            //smtp.Send(mailim);

         
                try
                {
                  
                        string strKime = "info@feysoft.com.tr";
                     
                        string strMailSunucu = "mail.feysoft.com.tr";
                        string strKonu = "feysoft.com.tr İletişim";
                        string strKullaniciAdi = "info@feysoft.com.tr";
                        string strParola = "1.FeYs.1";
                        MailMessage mesaj = new MailMessage(model.EmailAdd, strKime, model.Subject, model.Message);
                        mesaj.IsBodyHtml = true;
                        SmtpClient emailClient = new SmtpClient(strMailSunucu);
                        System.Net.NetworkCredential SMTPUserInfo = new System.Net.NetworkCredential(strKullaniciAdi, strParola);
                        emailClient.Port = 587;
                       
                       
                        emailClient.Credentials = SMTPUserInfo;
                        emailClient.Send(mesaj);
                 
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
     

              return RedirectToAction("Index");

            //try
            //{
            //    smtp.Send(mailim);
            //    TempData["Neesage"] = "Mesajınız iletilmiştir";
            //}

            //catch (Exception ex)
            //{
            //    TempData["Neesage"] = "Mesaj Gönderilemedi.Hata nedeni:" + ex.Message;

            //}

          
        }

    }
}