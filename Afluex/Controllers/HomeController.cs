using Afluex.Filter;
using Afluex.Models;
using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Afluex.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             return View();
        }
        [ActionName("advertising-agency")]
        public ActionResult Advertising()
        {

            return View("Advertising");
        }
        [ActionName("company-overview")]
        public ActionResult companyoverview()
        {
            return View("companyoverview");
        }
        [ActionName("vision-and-mission")]
        public ActionResult visionandmission()
        {
            return View("visionandmission");
        }
        [ActionName("our-team")]
        public ActionResult OurTeam()
        {
            return View("OurTeam");
        }
        [ActionName("outdoor-advertising")]
        public ActionResult outdooradvertising()
        {
           return View("outdooradvertising");
        }
        [ActionName("wall-wrap-ads")]
        public ActionResult wallwrapads()
        {
            return View("wallwrapads");
        }
        [ActionName("inshop-outdoor-branding")]
        public ActionResult inshopoutdoorbranding()
        {
            return View("inshopoutdoorbranding");
        }
        [ActionName("mobile-van-promotion")]
        public ActionResult mobilevanpromotion()
        {
            return View("mobilevanpromotion");
        }
        [ActionName("cinema-advertising")]
        public ActionResult cinemaadvertising()
        {
            return View("cinemaadvertising");
        }
        [ActionName("auto-branding")]
        public ActionResult autobranding()
        {
            return View("autobranding");
        }
        [ActionName("printing-services")]
        public ActionResult printingservices()
        {
            return View("printingservices");
        }
        [ActionName("tv-advertising")]
        public ActionResult tvadvertising()
        {
            return View("tvadvertising");

        }
        [ActionName("radio-advertising")]
        public ActionResult radioadvertising()
        {
            return View("radioadvertising");
        }
        [ActionName("fabrication-services")]
        public ActionResult fabricationservices()
        {
            return View("fabricationservices");
        }
        [ActionName("event-management")]
        public ActionResult eventmanagement()
        {
            return View("eventmanagement");
        }
        [ActionName("online-marketing")]
        public ActionResult onlinemarketing()
        {
            return View("onlinemarketing");
        }
        [ActionName("airport-media")]
        public ActionResult airportmedia()
        {
            return View("airportmedia");
        }

        public ActionResult portfolio()
        {
            return View();
        }
        public ActionResult thankyou2()
        {
            return View();
        }
        public ActionResult NewIndex()
        {
            return View();
        }
        public ActionResult gallery()
        {
            return View();
        }
        public ActionResult career()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Career")]
        [OnAction(ButtonName = "Save")]
        public ActionResult SaveCareer(HttpPostedFileBase postedFile, Ad model)
        {
            string FormName = "";
            string Controller = "";
            try
            {
                if (postedFile != null)
                {
                    model.FileUpload = "/CareerFileUpload/" + Guid.NewGuid() + Path.GetExtension(postedFile.FileName);
                    postedFile.SaveAs(Path.Combine(Server.MapPath(model.FileUpload)));

                }
                model.CareerType = "AD";

                DataSet dsRegistration = model.SaveCareer();
                if (dsRegistration.Tables[0].Rows[0][0].ToString() == "1")

                {
                    if (model.Email != null)
                    {
                        string mailbody = "";

                        try
                        {
                            #region SendEmailToAdmin
                            SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
                            mailServer.EnableSsl = true;
                            //mailServer.Credentials = new System.Net.NetworkCredential(model.SenderEmail, model.SenderPassword);
                            mailServer.Credentials = new System.Net.NetworkCredential("contact.afluex@gmail.com", "Krishna@412");

                            MailMessage myMail = new MailMessage();
                            myMail.IsBodyHtml = true;
                            myMail.Subject = "Career";
                            myMail.Body = "<b>Dear team</b>" + "<br/>" + "You got a career inquiry from" + "<br/>" + "Name : " + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + "<br/>" + "Mobile No : " + dsRegistration.Tables[0].Rows[0]["Mobile"].ToString() + "<br/>" + " Email : " + dsRegistration.Tables[0].Rows[0]["Email"].ToString() + "<br/>" + " Description : " + dsRegistration.Tables[0].Rows[0]["Description"].ToString();
                            myMail.From = new MailAddress("contact.afluex@gmail.com");
                            myMail.To.Add("contact.afluex@gmail.com");
                            HttpPostedFileBase file = Request.Files["postedfile"];
                            if (file != null && file.ContentLength > 0)
                            {
                                if (file.ContentLength < 12288000)
                                {
                                    string filename = Path.GetFileName(file.FileName);
                                    var attachment = new Attachment(file.InputStream, filename);
                                    myMail.Attachments.Add(attachment);
                                }
                            }
                            mailServer.Send(myMail);


                            #endregion SendEmailToAdmin

                            #region SendEmailToCandidate

                            SmtpClient mailServer1 = new SmtpClient("smtp.gmail.com", 587);
                            mailServer.EnableSsl = true;
                            //mailServer.Credentials = new System.Net.NetworkCredential(model.SenderEmail, model.SenderPassword);
                            mailServer.Credentials = new System.Net.NetworkCredential("contact.afluex@gmail.com", "Krishna@412");

                            MailMessage myMail1 = new MailMessage();
                            myMail1.IsBodyHtml = true;
                            myMail1.Subject = "Career";
                            myMail1.Subject = "Career";
                            mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                        + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                         + "Dear " + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + ",<br/> Thank you ! for showing your interest in Afluex.<br/>Our HR Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -"
                          + "<a href = 'mailto:supportnow@afluex.com' target= '_blank'>supportnow@afluex.com</a>.</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
+ "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
+ "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 414/05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
+ "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
+ "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";

                            myMail1.Body = mailbody;
                            myMail1.From = new MailAddress("contact.afluex@gmail.com", "Afluex Multiservices LLP");

                            myMail1.To.Add(dsRegistration.Tables[0].Rows[0]["Email"].ToString());

                            mailServer.Send(myMail1);

                            #endregion SendEmailToCandidate
                            string mob = "7310000413";
                            string str = "You got a career inquiry from- " + "Name-" + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + " , Mob-" + dsRegistration.Tables[0].Rows[0]["Mobile"].ToString() + " , Email-" + dsRegistration.Tables[0].Rows[0]["Email"].ToString() + " , Description-" + dsRegistration.Tables[0].Rows[0]["Description"].ToString();
                            try
                            {
                                BLSMS.SendSMS(mob, str);
                            }
                            catch { }
                            TempData["Career"] = "Data Submission Successfull !";
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                if (dsRegistration != null && dsRegistration.Tables.Count > 0)
                {
                    if (dsRegistration.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        Session["Name"] = dsRegistration.Tables[0].Rows[0]["Name"].ToString();
                        Session["Email"] = dsRegistration.Tables[0].Rows[0]["Email"].ToString();
                        Session["Mobile"] = dsRegistration.Tables[0].Rows[0]["Mobile"].ToString();
                        Session["Description"] = dsRegistration.Tables[0].Rows[0]["Description"].ToString();
                        TempData["Career"] = "Thank you ! for showing your interest in Afluex.Our HR Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -supportnow@afluex.com.";

                        string mob = dsRegistration.Tables[0].Rows[0]["Mobile"].ToString();
                        string str = "Dear " + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + " thank you for showing your interest in Afluex. Our HR Team will contact you soon. For Direct Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        try
                        {
                            //BLSMS.SendSMS(mob, str);
                        }
                        catch { }
                    }
                    else
                    {
                        TempData["Career"] = dsRegistration.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["Career"] = ex.Message;
            }
            FormName = "career";
            Controller = "Home";

            return RedirectToAction(FormName, Controller);
        }
        public ActionResult contactus()
        {
            return View();
        }
        #region contactus
      
        [HttpPost]
        [ActionName("contactus")]
        [OnAction(ButtonName = "btnSave")]
        [ValidateAntiForgeryToken]
        public ActionResult SaveContactus(Ad model)
        {
            if (!this.IsCaptchaValid(errorText: "Invalid Captcha"))
            {
                ViewBag.Message = "Captcha validation failed";
                TempData["ContactMsg"] = "Captcha validation failed";
                return RedirectToAction("contactus", "Home");
            }
            string FormName = "";
            string Controller = "";
            try
            {
                model.ContactusType = "AD";
                DataSet ds = model.SaveContactus();
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        string mailbody = "";
                        try
                        {
                            mailbody = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on -supportnow@afluex.com";
                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress(model.Email);
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contact us",
                                Body = mailbody
                            })
                                smtp.Send(message);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string mob = model.Mobile;
                        string str = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        try
                        {
                            //BLSMS.SendSMS(mob, str);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string messagelbody = "";
                        try
                        {
                            messagelbody = "<b>Dear team</b>" + "<br/>" + "You got a contact whose " + "<br/>" + " Name : " + model.Name + "<br/>" + " Mobile : " + model.Mobile + "<br/>" + " Message : " + model.Message;

                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress("contact.afluex@gmail.com");
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")

                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contactus",
                                Body = messagelbody
                            })
                                smtp.Send(message);
                            //TempData["ContactMsg"] = "message has been sent. ";
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string mobs = "7310000413";
                        string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message;
                        try
                        {
                            //BLSMS.SendSMS(mobs, str2);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        TempData["ContactMsg"] = "message has been sent.";
                        FormName = "thankyou";
                        Controller = "Home";
                    }
                    else
                    {
                        TempData["ContactMsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "Contactus";
                        Controller = "Home";
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ContactMsg"] = ex.Message;
                FormName = "Contactus";
                Controller = "Home";
            }
            return RedirectToAction(FormName, Controller);
        }
   
        public ActionResult ValidateData(string MemberName, string Contact, string Email, string CustMessage)
        {
            Home model = new Home();
            model.Mobile = Contact;
            model.Name = MemberName;
            try
            {
                Random rnd = new Random();
                string ctrOTP = rnd.Next(111111, 999999).ToString();
                string strotp = "Dear " + model.Name + ", Your OTP for Demo request is :" + ctrOTP;
                string mobotp = model.Mobile;
                string mailbody = "";
                try
                {
                    mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                 + "Dear " + MemberName + ",<br/> Your OTP(One Time Password is) " + ctrOTP + ".<br/>"
                  + "</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
+ "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
+ "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 414/05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
+ "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
+ "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";
                    var fromAddress = new MailAddress("contact.afluex@gmail.com", "Afluex Mutiserices LLP");
                    var toAddress = new MailAddress(Email);
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address,"Krishna@412" )// "Krishna@412")

                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        IsBodyHtml = true,
                        Subject = "OTP(One Time Password)",
                        Body = mailbody
                    })
                        smtp.Send(message);
                }
                catch (Exception ex)
                {
                }
                try
                {
                    //BLSMS.SendSMS(mobotp, strotp);
                }
                catch { }
                model.Otppin = ctrOTP;
                model.Result = "1";
            }
            catch (Exception ex)
            {

            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        public ActionResult thankyou()
        {
            return View();
        }

        #endregion contactus

        #region Blog
        public ActionResult blog(string id)
        {
            Blog obj = new Blog();
            if (id != null && id != "")
            {
                obj.Fk_CategoryId = id;
            }

            List<Blog> lst = new List<Blog>();
            List<Blog> lst1 = new List<Blog>();
            List<Blog> lst2 = new List<Blog>();
            List<Blog> lst3 = new List<Blog>();
            DataSet ds = obj.GetBlogAdvertisement();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Blog obj1 = new Blog();
                    obj1.Pk_BlogId = r["Pk_BlogId"].ToString();
                    obj1.Title = r["Title"].ToString();
                    obj1.ShortDecription = r["ShortDecription"].ToString();
                    obj1.Decription = r["Description"].ToString();
                    obj1.FileUpload = r["AddedOn"].ToString();
                    obj1.FileName = r["Images"].ToString();
                    obj1.AddedBy = r["Name"].ToString();
                    lst.Add(obj1);
                }

                obj.List = lst;


                foreach (DataRow r in ds.Tables[2].Rows)
                {
                    Blog obj1 = new Blog();
                    obj1.Fk_CategoryId = r["CategoryName"].ToString();
                    obj1.Pk_BlogId = r["Fk_BlogId"].ToString();


                    lst2.Add(obj1);
                }

                obj.lstcategory = lst2;

            }
            if (ds != null && ds.Tables[3].Rows.Count > 0)
            {

                foreach (DataRow r in ds.Tables[3].Rows)
                {
                    Blog obj1 = new Blog();
                    obj1.Fk_CategoryId = r["PK_CategoryID"].ToString();
                    obj1.CategoryName = r["CategoryName"].ToString();
                    lst3.Add(obj1);
                }

                obj.lstcategoryfull = lst3;
            }
            return View(obj);
        }
        public ActionResult blogDetails(string id)
        {
            Blog obj = new Blog();
            if (id != null && id != "")
            {

                List<Blog> lst = new List<Blog>();
                List<Blog> lst1 = new List<Blog>();
                List<Blog> lst2 = new List<Blog>();

                obj.Pk_BlogId = id;
                DataSet ds = obj.GetBlog();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        Blog obj1 = new Blog();
                        obj1.Pk_BlogId = r["Pk_BlogId"].ToString();
                        obj1.Title = r["Title"].ToString();
                        obj1.ShortDecription = r["ShortDecription"].ToString();
                        obj1.Decription = r["Description"].ToString();
                        obj1.FileUpload = r["AddedOn"].ToString();

                        obj1.AddedBy = r["Name"].ToString();
                        lst.Add(obj1);
                    }

                    obj.List = lst;
                    foreach (DataRow r in ds.Tables[1].Rows)
                    {
                        Blog obj1 = new Blog();
                        obj1.FileName = r["Images"].ToString();
                        obj1.Pk_BlogId = r["Fk_BlogId"].ToString();


                        lst1.Add(obj1);
                    }

                    obj.lstimages = lst1;

                    foreach (DataRow r in ds.Tables[2].Rows)
                    {
                        Blog obj1 = new Blog();
                        obj1.Fk_CategoryId = r["CategoryName"].ToString();
                        obj1.Pk_BlogId = r["Fk_BlogId"].ToString();


                        lst2.Add(obj1);
                    }

                    obj.lstcategory = lst2;


                }

            }
            return View(obj);
        }
        #endregion Blog

        #region Quotation
        public ActionResult SaveInquiryDetails(string Name, string Email, string Mobile, string ProjectType, string YourBudget, string Message, string InquiryType)
        {
            Home obj = new Home();
            try
            {
                obj.Name = Name;
                obj.Email = Email;
                obj.Mobile = Mobile;
                obj.ProjectType = ProjectType;
                obj.YourBudget = YourBudget;
                obj.Message = Message;
                obj.InquiryType = InquiryType;
                DataSet ds = obj.SaveInquiry();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    if ((ds.Tables[0].Rows[0][0].ToString() == "1"))
                    {
                        string mailbody = "";
                        try
                        {
                            mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://www.afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                        + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                         + "Dear " + Name + ",<br/> Thank you for showing your interest.<br/>Our Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -"
                          + "<a href = 'mailto:supportnow@afluex.com' target= '_blank'>supportnow@afluex.com</a>.</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
        + "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
        + "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 414</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
        + "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
        + "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";

                            var fromAddress = new MailAddress("contact.afluex@gmail.com", "Afluex Mutiserices LLP");
                            var toAddress = new MailAddress(obj.Email = Email);

                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")//"Krishna@412")

                            };

                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Thank you " + Name + " for showing interest with us",
                                Body = mailbody
                            })
                                smtp.Send(message);
                        }

                        catch (Exception ex)
                        {

                        }


                        //string mobs = Mobile;
                        //string str2 = "Dear " + Name + " thank you for showing your interest in our IT Field. Our Team will contact you soon For Enquiry call us on 7310000413,412 or Mail us on supportnow@afluex.com";

                        //try
                        //{
                        //   //BLSMS.SendSMS(mobs, str2);
                        //}
                        //catch { }

                        string Name1 = ds.Tables[0].Rows[0]["Name"].ToString();
                        string mob = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str = "Dear " + Name1 + ", Thank You For Showing Your Interest In Afluex. Our HR Team Will Contact You Soon. For Direct Enquiry Call On 7310000413,412 Or Mail Us On Supportnow@Afluex.Com, Team Afluex";
                        string TempId = "1707166203837277816";
                        try
                        {
                            BLSMS.SendSMSS(mob, str, TempId);
                        }
                        catch { }

                        
                        string messagelbody = "";
                        try
                        {
                            messagelbody = "<b>Dear team</b>" + "<br/>" + "You got a quote Rquest from" + "<br/>" + "Name : " + Name + "<br/>" + "Mobile : " + Mobile + "<br/>" + " ProjectType : " + ProjectType + "<br/>" + " YourBudget : " + YourBudget + " <br/>" + " Message : " + Message;
                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress("contact.afluex@gmail.com");
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412") //"Krishna@412")
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Inquiry",
                                Body = messagelbody
                            })
                                smtp.Send(message);
                            //TempData["ContactMsg"] = "message has been sent. ";
                        }
                        catch (Exception ex)
                        {

                        }


                        //string mobval = "7310000413";
                        //string strval = "You got a quote Rquest from " + Name + " , Mob-" + Mobile + ", Project-" + ProjectType + " ,Budget-" + YourBudget + ", Msg-" + Message;
                        //try
                        //{
                        //     //BLSMS.SendSMS(mobval, strval);
                        //}
                        //catch { }


                        string mobs = "7310000413";
                        string Name2 = ds.Tables[0].Rows[0]["Name"].ToString();
                        string Messages = ds.Tables[0].Rows[0]["Message"].ToString();
                        string Mobile1 = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str2 = "Dear team You got a contact whose Name : " + Name2 + ", Mobile : " + Mobile1 + ", Message : " + Messages + ", Team Afluex";
                        string TempId2 = "1707166203848904315";

                        try
                        {
                            BLSMS.SendSMSS(mobs, str2, TempId2);
                        }
                        catch { }
                        
                        obj.Result = "Yes";
                    }
                    else
                    {
                        obj.Result = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                obj.Result = ex.Message;
            }
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        #endregion Quotation
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LoginAction(Home obj)
        {
            string FormName = "";
            string Controller = "";
            try
            {
                Home Modal = new Home();

                DataSet ds = obj.Login();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    Session["LoginId"] = ds.Tables[0].Rows[0]["LoginId"].ToString();
                    Session["Pk_AdminId"] = ds.Tables[0].Rows[0]["Pk_adminId"].ToString();
                    Session["UsertypeName"] = ds.Tables[0].Rows[0]["UserType"].ToString();


                    Session["Name"] = ds.Tables[0].Rows[0]["Name"].ToString();

                    FormName = "DashBoard";
                    Controller = "Admin";

                }
                else
                {
                    TempData["Login"] = "Incorrect LoginId Or Password";
                    FormName = "Login";
                    Controller = "Home";

                }
            }
            catch (Exception ex)
            {
                TempData["Login"] = ex.Message;
                FormName = "Login";
                Controller = "Home";
            }

            return RedirectToAction(FormName, Controller);

        }

        public ActionResult crmsoftware()
        {
            return View();
        }

        
   
        public ActionResult SaveLandingPage(string Name, string Mobile, string Email)
        {
            Home model = new Home();
            model.Name = Name;
            model.Mobile = Mobile;
            model.Email = Email;
            //if (!this.IsCaptchaValid(errorText: "Invalid Captcha"))
            //{
            //    ViewBag.Message = "Captcha validation failed";
            //    TempData["ContactMsg"] = "Captcha validation failed";
            //    return RedirectToAction("crmsoftware", "Home");
            //}
            string FormName = "";
            string Controller = "";
            try
            {
                model.ContactusType = "Google Ad";
                DataSet ds = model.SaveLandingPageDetails();
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        string mailbody = "";
                        try
                        {
                            mailbody = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on -supportnow@afluex.com";
                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress(model.Email);
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contact us",
                                Body = mailbody
                            })
                                smtp.Send(message);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }


                        //string mob = model.Mobile;
                        //string str = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        //try
                        //{
                        //    //BLSMS.SendSMS(mob, str);
                        //}
                        //catch (Exception ex)
                        //{
                        //    //throw ex;
                        //}

                        string Name1 = ds.Tables[0].Rows[0]["Name"].ToString();
                        string mob = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str = "Dear " + Name1 + ", Thank You For Showing Your Interest In Afluex. Our HR Team Will Contact You Soon. For Direct Enquiry Call On 7310000413,412 Or Mail Us On Supportnow@Afluex.Com, Team Afluex";
                        string TempId = "1707166203837277816";
                        try
                        {
                            BLSMS.SendSMSS(mob, str, TempId);
                        }
                        catch { }

                        
                        string messagelbody = "";
                        try
                        {
                            messagelbody = "<b>Dear team</b>" + "<br/>" + "You got a contact whose " + "<br/>" + " Name : " + model.Name + "<br/>" + " Mobile : " + model.Mobile + "<br/>" + " Message : " + model.Message;

                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress("contact.afluex@gmail.com");
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")

                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contactus",
                                Body = messagelbody
                            })
                                smtp.Send(message);
                            //TempData["ContactMsg"] = "message has been sent. ";
                            model.Result = "true";
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }

                        //string mobs = "7310000413";
                        //string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message;
                        //try
                        //{
                        //    //BLSMS.SendSMS(mobs, str2);
                        //}
                        //catch (Exception ex)
                        //{
                        //    //throw ex;
                        //}


                        string mobs = "7310000413";
                        string Name2 = ds.Tables[0].Rows[0]["Name"].ToString();
                        string Message = ds.Tables[0].Rows[0]["Message"].ToString();
                        string Mobile1 = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str2 = "Dear team You got a contact whose Name : " + Name2 + ", Mobile : " + Mobile1 + ", Message : " + Message + ", Team Afluex";
                        string TempId2 = "1707166203848904315";
                        try
                        {
                            BLSMS.SendSMSS(mobs, str2, TempId2);
                        }
                        catch { }
                        
                        TempData["ContactMsg"] = "message has been sent.";
                        model.Result = "true";
                        FormName = "thankyou";
                        Controller = "Home";
                    }
                    else
                    {
                        TempData["ContactMsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        model.Result = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "crmsoftware";
                        Controller = "Home";
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ContactMsg"] = ex.Message;
                model.Result= ex.Message;
                FormName = "crmsoftware";
                Controller = "Home";
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveLandingPageAction(string Name, string Mobile, string Email)
        {
            Home model = new Home();
            model.Name = Name;
            model.Mobile = Mobile;
            model.Email = Email;
            //if (!this.IsCaptchaValid(errorText: "Invalid Captcha"))
            //{
            //    ViewBag.Message = "Captcha validation failed";
            //    TempData["ContactMsg"] = "Captcha validation failed";
            //    return RedirectToAction("contactus", "Home");
            //}
            string FormName = "";
            string Controller = "";
            try
            {
                model.ContactusType = "Google Ad";
                DataSet ds = model.SaveLandingPageDetails();
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        string mailbody = "";
                        try
                        {
                            mailbody = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on -supportnow@afluex.com";
                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress(model.Email);
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contact us",
                                Body = mailbody
                            })
                                smtp.Send(message);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string mob = model.Mobile;
                        string str = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        try
                        {
                            //BLSMS.SendSMS(mob, str);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string messagelbody = "";
                        try
                        {
                            messagelbody = "<b>Dear team</b>" + "<br/>" + "You got a contact whose " + "<br/>" + " Name : " + model.Name + "<br/>" + " Mobile : " + model.Mobile + "<br/>" + " Message : " + model.Message;

                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress("contact.afluex@gmail.com");
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")

                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contactus",
                                Body = messagelbody
                            })
                                smtp.Send(message);
                            //TempData["ContactMsg"] = "message has been sent. ";
                            model.Result = "true";
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string mobs = "7310000413";
                        string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message;
                        try
                        {
                            //BLSMS.SendSMS(mobs, str2);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        TempData["ContactMsg"] = "message has been sent.";
                        model.Result = "true";
                        FormName = "thankyou";
                        Controller = "Home";
                    }
                    else
                    {
                        TempData["ContactMsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "crmsoftware";
                        Controller = "Home";
                        model.Result= ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ContactMsg"] = ex.Message;
                FormName = "crmsoftware";
                Controller = "Home";
                model.Result = ex.Message;
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }

      
        public ActionResult SaveContactusFooter(Ad model)
        {
            if (!this.IsCaptchaValid(errorText: "Invalid Captcha"))
            {
                ViewBag.Message = "Captcha validation failed";
                TempData["ContactMsg"] = "Captcha validation failed";
                return RedirectToAction("contactus", "Home");
            }
            string FormName = "";
            string Controller = "";
            try
            {
                model.ContactusType = "AD";
                DataSet ds = model.SaveContactus();
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        string mailbody = "";
                        try
                        {
                            mailbody = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on -supportnow@afluex.com";
                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress(model.Email);
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contact us",
                                Body = mailbody
                            })
                                smtp.Send(message);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string mob = model.Mobile;
                        string str = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        try
                        {
                            //BLSMS.SendSMS(mob, str);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string messagelbody = "";
                        try
                        {
                            messagelbody = "<b>Dear team</b>" + "<br/>" + "You got a contact whose " + "<br/>" + " Name : " + model.Name + "<br/>" + " Mobile : " + model.Mobile + "<br/>" + " Message : " + model.Message;

                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress("contact.afluex@gmail.com");
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Krishna@412")

                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = "Contactus",
                                Body = messagelbody
                            })
                                smtp.Send(message);
                            //TempData["ContactMsg"] = "message has been sent. ";
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        string mobs = "7310000413";
                        string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message;
                        try
                        {
                            //BLSMS.SendSMS(mobs, str2);
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                        TempData["ContactMsg"] = "message has been sent.";
                        FormName = "thankyou";
                        Controller = "Home";
                    }
                    else
                    {
                        TempData["ContactMsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "Contactus";
                        Controller = "Home";
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ContactMsg"] = ex.Message;
                FormName = "Contactus";
                Controller = "Home";
            }
            return RedirectToAction(FormName, Controller);
        }
    }
}
