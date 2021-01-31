
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RotaryWebsite.CommonServices;

namespace RotaryWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly IOptions<MyConfig> _myconfigs;

        public ContactController(IOptions<MyConfig> myConfigs)
        {
            _myconfigs = myConfigs;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactUsModel model)
        {
            if (ModelState.IsValid)
            {
                SmtpClient smtpClient = new SmtpClient(_myconfigs.Value.SmtpClientHost);

                smtpClient.Credentials = new System.Net.NetworkCredential(_myconfigs.Value.UserName, _myconfigs.Value.Password);

                String message = "Name:" + model.Name + "\r\n";
                message += "Email:" + model.Email + "\r\n";
                message += "Phone:" + model.Phone + "\r\n";
                message += "Subject:" + model.Subject + "\r\n";
                message += "Message:" + model.Comment + "\r\n";
                smtpClient.EnableSsl = false;
                smtpClient.Port = Convert.ToInt32(_myconfigs.Value.Port);
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.Subject = "Contact Form from - Rotary";
                mail.Body = message;
                mail.From = new MailAddress(_myconfigs.Value.UserName, "Rotary Club");
                if (_myconfigs.Value.ToEmail.Contains(";"))
                {
                    foreach (var item in _myconfigs.Value.ToEmail.Split(';'))
                    {
                        mail.To.Add(new MailAddress(item.Trim()));
                    }
                }
                else
                {
                    mail.To.Add(new MailAddress(_myconfigs.Value.ToEmail));
                }

                try
                {
                    //sc.Send(msg);
                    smtpClient.Send(mail);
                    ViewBag.sucess = "Email Sent";
                    return View();
                }
                catch (Exception ex)
                {
                    ViewBag.sucess = "Some Error while sending Email. please try after some time" + ex.InnerException.Message;
                    return View(model);
                }
            }
            else
                return View(model);
        }
    }

    public class ContactUsModel
    {
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Email id")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Phone")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter Comment")]
        public string Comment { get; set; }
    }
}