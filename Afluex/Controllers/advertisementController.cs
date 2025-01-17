﻿using Afluex.Filter;
using Afluex.Models;
using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Afluex.Controllers
{
    public class advertisementController : Controller
    {
        [ActionName("advertising-agency")]
        public ActionResult Index()
        {
            return View("Index");
        }
        
        [ActionName("company-overview")]
        public ActionResult Overview()
        {
            return View("Overview");
        }
        [ActionName("vision-and-mission")]
        public ActionResult VisionMission()
        {
            return View("VisionMission");
        }
        [ActionName("our-team")]
        public ActionResult Team()
        {
            return View("Team");
        }

        public ActionResult portfolio()
        {
            return View();
        }
        #region career
        public ActionResult career(Ad obj)
        {
            List<Ad> lst = new List<Ad>();
            DataSet ds = obj.GetOpenVacancyList();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Ad Obj = new Ad();
                    Obj.PK_VacancyID = r["PK_VacancyID"].ToString();
                    Obj.Designation = r["Designation"].ToString();
                    Obj.MinExperience = r["MinExperience"].ToString();
                    Obj.SalaryRange = r["SalaryRange"].ToString();
                    Obj.UploadFile = r["UploadFile"].ToString();
                    Obj.TotalVacancy = r["TotalVacancy"].ToString();
                    lst.Add(Obj);
                }
                obj.lstvacancy = lst;
            }
            return View(obj);
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
                            //                            #region SendEmailToAdmin
                            //                            SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
                            //                            mailServer.EnableSsl = true;
                            //                            //mailServer.Credentials = new System.Net.NetworkCredential(model.SenderEmail, model.SenderPassword);
                            //                            mailServer.Credentials = new System.Net.NetworkCredential("contact.afluex@gmail.com", "Multiservices@437");

                            //                            MailMessage myMail = new MailMessage();
                            //                            myMail.IsBodyHtml = true;
                            //                            myMail.Subject = "Career";
                            //                            myMail.Body = "<b>Dear team</b>" + "<br/>" + "You got a career inquiry from" + "<br/>" + "Name : " + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + "<br/>" + "Mobile No : " + dsRegistration.Tables[0].Rows[0]["Mobile"].ToString() + "<br/>" + " Email : " + dsRegistration.Tables[0].Rows[0]["Email"].ToString() + "<br/>" + " Description : " + dsRegistration.Tables[0].Rows[0]["Description"].ToString();
                            //                            myMail.From = new MailAddress("contact.afluex@gmail.com");
                            //                            myMail.To.Add("contact.afluex@gmail.com");
                            //                            HttpPostedFileBase file = Request.Files["postedfile"];
                            //                            if (file != null && file.ContentLength > 0)
                            //                            {
                            //                                if (file.ContentLength < 12288000)
                            //                                {
                            //                                    string filename = Path.GetFileName(file.FileName);
                            //                                    var attachment = new Attachment(file.InputStream, filename);
                            //                                    myMail.Attachments.Add(attachment);
                            //                                }
                            //                            }
                            //                            mailServer.Send(myMail);


                            //                            #endregion SendEmailToAdmin

                            //                            #region SendEmailToCandidate

                            //                            SmtpClient mailServer1 = new SmtpClient("smtp.gmail.com", 587);
                            //                            mailServer.EnableSsl = true;
                            //                            //mailServer.Credentials = new System.Net.NetworkCredential(model.SenderEmail, model.SenderPassword);
                            //                            mailServer.Credentials = new System.Net.NetworkCredential("contact.afluex@gmail.com", "Multiservices@437");

                            //                            MailMessage myMail1 = new MailMessage();
                            //                            myMail1.IsBodyHtml = true;
                            //                            myMail1.Subject = "Career";
                            //                            myMail1.Subject = "Career";
                            //                            mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                            //                        + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                            //                         + "Dear " + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + ",<br/> Thank you ! for shwoing your interest in Afluex.<br/>Our HR Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -"
                            //                          + "<a href = 'mailto:supportnow@afluex.com' target= '_blank'>supportnow@afluex.com</a>.</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
                            //+ "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Mutiservices LLP</h1>"
                            //+ "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
                            //+ "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
                            //+ "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";

                            //                            myMail1.Body = mailbody;
                            //                            myMail1.From = new MailAddress("contact.afluex@gmail.com", "Afluex Multiservices LLP");

                            //                            myMail1.To.Add(dsRegistration.Tables[0].Rows[0]["Email"].ToString());

                            //                            mailServer.Send(myMail1);

                            //                            #endregion SendEmailToCandidate


                            //string mob = "7310000413";
                            //string str = "You got a career inquiry from- " + "Name-" + dsRegistration.Tables[0].Rows[0]["Name"].ToString() + " , Mob-" + dsRegistration.Tables[0].Rows[0]["Mobile"].ToString() + " , Email-" + dsRegistration.Tables[0].Rows[0]["Email"].ToString() + " , Description-" + dsRegistration.Tables[0].Rows[0]["Description"].ToString();
                            //try
                            //{
                            //    //BLSMS.SendSMS(mob, str);
                            //}


                            //string mobs = "7310000413";
                            string mobs = "7310000413";
                            string Name2 = dsRegistration.Tables[0].Rows[0]["Name"].ToString();
                            string Message = dsRegistration.Tables[0].Rows[0]["Description"].ToString();
                            string Mobile = dsRegistration.Tables[0].Rows[0]["Mobile"].ToString();
                            string str2 = "Dear team You got a contact whose Name : " + Name2 + ", Mobile : " + Mobile + ", Message : " + Message + ", Team Afluex";
                            string TempId2 = "1707166203848904315";
                            try
                            {
                                BLSMS.SendSMSS(mobs, str2, TempId2);
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
                        //TempData["Career"] = "Thank you ! for shwoing your interest in Afluex.Our HR Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -supportnow@afluex.com.";
                        TempData["Career"] = "Data Submission Successfull !";

                        //string mob = dsRegistration.Tables[0].Rows[0]["Mobile"].ToString();
                        //string str =  dsRegistration.Tables[0].Rows[0]["Name"].ToString() + " thank you for shwoing your interest in Afluex. Our HR Team will contact you soon. For Direct Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        //try
                        //{
                        //    //BLSMS.SendSMS(mob, str);
                        //}
                        //catch { }


                        string Name = dsRegistration.Tables[0].Rows[0]["Name"].ToString();
                        string mob = dsRegistration.Tables[0].Rows[0]["Mobile"].ToString();
                        string str = "Dear " + Name + ", Thank You For Showing Your Interest In Afluex. Our HR Team Will Contact You Soon. For Direct Enquiry Call On 7310000413,412 Or Mail Us On Supportnow@Afluex.Com, Team Afluex";
                        string TempId = "1707166203837277816";
                        try
                        {
                            BLSMS.SendSMSS(mob, str, TempId);
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
            Controller = "advertisement";

            return RedirectToAction(FormName, Controller);
        }
        #endregion career
        public ActionResult client()
        {
            return View();
        }
        public ActionResult gallery()
        {
            return View();
        }
        //---our services
        [ActionName("tv-advertising")]
        public ActionResult tv_advertising()
        {
            return View("tv_advertising");
        }
        [ActionName("radio-advertising")]
        public ActionResult radio_advertising()
        {
            return View("radio_advertising");
        }
        [ActionName("news-advertising")]
        public ActionResult news_advertising()
        {
            return View("news_advertising");
        }
        [ActionName("outdoor-advertising")]
        public ActionResult outdoor_advertising()
        {
            return View("outdoor_advertising");
        }
        [ActionName("mobile-van-promotion")]
        public ActionResult mobile_van_promotion()
        {
            return View("mobile_van_promotion");
        }
        [ActionName("wall-wrap")]
        public ActionResult wall_wrap_ads()
        {
            return View("wall_wrap_ads");
        }
        [ActionName("auto-rickshaw-advertising")]
        public ActionResult auto_branding()
        {
            return View("auto_branding");
        }
        [ActionName("cinema-advertising")]
        public ActionResult cinema_advertising()
        {
            return View("cinema_advertising");
        }
        [ActionName("printing-services")]
        public ActionResult printing_services()
        {
            return View("printing_services");

        }
        [ActionName("inshop-outdoor-branding")]
        public ActionResult inshop_outdoor_branding()
        {
            return View("inshop_outdoor_branding");
        }
        [ActionName("fabrication-services")]
        public ActionResult fabrication_services()
        {
            return View("fabrication_services");
        }
        #region contactus
        public ActionResult contactus()
        {
            return View();
        }
        [HttpPost]
        [ActionName("contactus")]
        [OnAction(ButtonName = "btnSave")]
        public ActionResult SaveContactus(Ad model)
        {
            if (!this.IsCaptchaValid(errorText: "Invalid Captcha"))
            {
                ViewBag.Message = "Captcha validation failed";
                TempData["ContactMsg"] = "Captcha validation failed";
                return RedirectToAction("contactus", "advertisement");
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
                            mailbody = "Dear " + model.Name + " thank you for shwoing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on -supportnow@afluex.com";

                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress(model.Email);

                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437")
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
                        //string str =  model.Name + " thank you for shwoing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";

                        //try
                        //{
                        //    //BLSMS.SendSMS(mob, str);
                        //}
                        //catch (Exception ex)
                        //{
                        //    //throw ex;
                        //}


                        string Name = ds.Tables[0].Rows[0]["Name"].ToString();
                        string mob = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str = "Dear " + Name + ", thank you for showing your interest in Afluex. Our HR Team will contact you soon. For Direct Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com, Team Afluex";
                        string TempId = "1707166203818524452";
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
                                Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437")

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
                        
                        //string mobs = "7310000413";
                        //string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message;
                        //try
                        //{
                        //    BLSMS.SendSMS(mobs, str2);
                        //}
                        //catch (Exception ex)
                        //{
                        //    //throw ex;
                        //}
                        
                        string mobs = "7310000413";
                        string Name2 = ds.Tables[0].Rows[0]["Name"].ToString();
                        string Message = ds.Tables[0].Rows[0]["Message"].ToString();
                        string Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str2 = "Dear team You got a contact whose Name : " + Name2 + ", Mobile : " + Mobile + ", Message : " + Message + ", Team Afluex";
                        string TempId2 = "1707166203848904315";

                        try
                        {
                            BLSMS.SendSMSS(mobs, str2, TempId2);
                        }
                        catch { }
                        
                        TempData["ContactMsg"] = "message has been sent.";
                        FormName = "thankyou";
                        Controller = "advertisement";
                    }
                    else
                    {
                        TempData["ContactMsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        FormName = "contactus";
                        Controller = "advertisement";
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["ContactMsg"] = ex.Message;
                FormName = "contactus";
                Controller = "advertisement";
            }
            return RedirectToAction(FormName, Controller);
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
            List<Blog> lst4 = new List<Blog>();
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
                    obj1.AddedOn = r["AddedOn"].ToString();
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


                foreach (DataRow r in ds.Tables[4].Rows)
                {
                    Blog obj1 = new Blog();
                    obj1.Pk_BlogId = r["Pk_BlogId"].ToString();
                    obj1.Title = r["Title"].ToString();
                    obj1.ShortDecription = r["ShortDecription"].ToString();
                    obj1.Decription = r["Description"].ToString();
                    obj1.AddedOn = r["AddedOn"].ToString();
                    obj1.UploadFile = r["Images"].ToString();
                    obj1.AddedBy = r["Name"].ToString();
                    lst4.Add(obj1);
                }
                obj.lsttop4blog = lst4;
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
                List<Blog> lst3 = new List<Blog>();
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
                        obj1.AddedOn = r["AddedOn"].ToString();
                        obj1.UploadFile = r["Images"].ToString();
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

                    foreach (DataRow r in ds.Tables[4].Rows)
                    {
                        Blog obj1 = new Blog();
                        obj1.Pk_BlogId = r["Pk_BlogId"].ToString();
                        obj1.Title = r["Title"].ToString();
                        obj1.ShortDecription = r["ShortDecription"].ToString();
                        obj1.Decription = r["Description"].ToString();
                        obj1.AddedOn = r["AddedOn"].ToString();
                        obj1.UploadFile = r["Images"].ToString();
                        obj1.AddedBy = r["Name"].ToString();
                        lst3.Add(obj1);
                    }
                    obj.lsttop4blog = lst3;
                }

            }
            return View(obj);
        }
        #endregion Blog

        [ActionName("all-services")]
        public ActionResult allservices()
        {
            return View("allservices");
        }
        [ActionName("online-marketing")]
        public ActionResult onlinemarketting()
        {
            return View("onlinemarketting");
        }
        [ActionName("event-management")]
        public ActionResult eventmanagement()
        {
            return View("eventmanagement");
        }
        [ActionName("airport-media")]
        public ActionResult airportmedia()
        {
            return View("airportmedia");
        }

        [ActionName("privacy-policy")]
        public ActionResult privacy_policy()
        {
            return View("privacy_policy");
        }

        public ActionResult term_conditions()
        {
            return View("term_conditions");
        }

        public virtual PartialViewResult DemoContact()
        {
            return PartialView("DemoContact");
        }
        [HttpPost]
        [ActionName("DemoContact")]
        [OnAction(ButtonName = "btnSave")]
        public ActionResult saveDemoinquiry(Home model)
        {
            Session["Type"] = null;
            string FormName = "";
            string Controller = "";
            string subject = "";
            try
          {
                string currenturl = Request.UrlReferrer.OriginalString;
                string[] strTemp = currenturl.Split('/');
                model.ContactusType = strTemp[4].ToString();
                Random rnd = new Random();
                string password = Common.GenerateRandom();
                model.Password = (password);
                model.EncryptPassword = Crypto.Encrypt(password);

                DataSet ds = model.SaveDemoDetails();
                if (model.ContactusType == "Online Marketing" || model.ContactusType == "Advertising" || model.ContactusType == "nidhi-software" || model.ContactusType == "Promotion")
                {
                    Session["Name"] = ds.Tables[0].Rows[0]["Name"].ToString();
                    Session["ContactusType"] = ds.Tables[0].Rows[0]["Type"].ToString();
                    Session["Url"] = ds.Tables[0].Rows[0]["Url"].ToString();
                    Session["Type"] = ds.Tables[0].Rows[0]["Type"].ToString();
                    Session["UserName"] = ds.Tables[0].Rows[0]["AssotId"].ToString();
                    Session["Password"] = Crypto.Decrypt(ds.Tables[0].Rows[0]["AssotPwd"].ToString());
                    Session["AdminID"] = ds.Tables[0].Rows[0]["AdminLogin"].ToString();
                    Session["AdminPass"] = ds.Tables[0].Rows[0]["AdminPass"].ToString();
                }
                else if (model.ContactusType == "Outdoor Advertising" || model.ContactusType == "Wall Wrap Ads" || model.ContactusType == "Inshop & Outdoor Branding" ||
                         model.ContactusType == "Mobile Van Promotion" || model.ContactusType == "Cinema Or Multiplex Advertising" || model.ContactusType == "Auto Branding"
                         || model.ContactusType == "Printing Services" || model.ContactusType == "Printing Services" || model.ContactusType == "TV Advertising")
                {
                    Session["Name"] = ds.Tables[0].Rows[0]["Name"].ToString();
                    Session["ContactusType"] = ds.Tables[0].Rows[0]["Type"].ToString();
                    Session["Url"] = ds.Tables[0].Rows[0]["Url"].ToString();
                    Session["Type"] = ds.Tables[0].Rows[0]["Type"].ToString();
                    Session["AdminID"] = ds.Tables[0].Rows[0]["AdminLogin"].ToString();
                    Session["AdminPass"] = ds.Tables[0].Rows[0]["AdminPass"].ToString();
                }
                else
                {
                    TempData["Type"] = "NoDemo";
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "1")
                    {
                        string mailbody = "";
                        try
                        {
                            if (model.ContactusType == "Radio Advertising" || model.ContactusType == "Fabrication Services" || model.ContactusType == "Online Marketing" || model.ContactusType == ">Event Management")
                            {
                                subject = "Thank You,For Requesting Demo.";
                                mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
+ "<tr><td><div style = 'background:#fff;vertical-align:top;padding:1px 0;text-align:center;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'>"
+ "<h4 style = 'font-size:20px;padding:10px 8px'>Thank you!<br/> For Requesting Demo.<br/></h4><p style = 'text-align: left;padding-left: 15px;font-size:20px'>"
+ "Dear " + ds.Tables[0].Rows[0]["Name"].ToString() + ",Below is your Login Creditentials :-<br/></p><p style = 'text-align: left;padding-left: 15px;font-size:17px'><a style = 'color: #fff;background-color: #337ab7;border-color: #2e6da4;display: inline-block;padding: 6px 12px;margin-bottom: 0;font-size: 14px;font-weight: 400;line-height: 1.42857143;"
+ "text - align: center; white - space: nowrap; vertical - align: middle; touch - action: manipulation; user - select: none; background - image: none;"
+ "border: 1px solid transparent; border - radius: 4px; ' href='" + ds.Tables[0].Rows[0]["Url"].ToString() + "'>Click Here For Open Demo</a></p>"
+ "<p style = 'text-align: left;padding-left: 15px;font-size:17px'><b> Admin Panel </b></p><table style = 'margin-left: 15px;width: 95%;border: 1px solid #ddd;max-width: 100%;margin-bottom: 20px;background-color: transparent;border-spacing: 0;border-collapse: collapse;ox-sizing: border-box;' cellpadding = '0' cellspacing = '0'>"
+ "<thead><tr style = 'color: #707070;font-weight: 400;box-sizing: border-box;'><th style = 'border-top: 0;vertical-align: middle;border-bottom-width: 2px;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;text-align: left;'>"
+ "Login Id</th><th style = 'border-top: 0;vertical-align: middle;border-bottom-width: 2px;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;text-align: left;'>"
+ "Password</th></tr></thead><tbody><tr style = 'background-color: #f9f9f9;box-sizing: border-box;'><td style = 'text-align:left;vertical-align: middle;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;'>"
+ "" + ds.Tables[0].Rows[0]["AdminLogin"].ToString() + "</td><td style = 'text-align:left;vertical-align: middle;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;'>" + ds.Tables[0].Rows[0]["AdminPass"].ToString() + "</td></tr></tbody>"
+ "</table><p style = 'text-align: left;padding-left: 15px;font-size:17px'><b> Associate Panel </b></p><br/><table style = 'margin-left: 15px;width: 95%;border: 1px solid #ddd;max-width: 100%;margin-bottom: 20px;background-color: transparent;border-spacing: 0;border-collapse: collapse;ox-sizing: border-box;' cellpadding = '0' cellspacing = '0'>"
+ "<thead><tr style = 'color: #707070;font-weight: 400;box-sizing: border-box;'>"
+ "<th style = 'border-top: 0;vertical-align: middle;border-bottom-width: 2px;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;text-align: left;'>"
+ "Login Id</th><th style = 'border-top: 0;vertical-align: middle;border-bottom-width: 2px;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;text-align: left;'>"
+ "Password</th></tr></thead><tbody><tr style = 'background-color: #f9f9f9;box-sizing: border-box;'>"
+ "<td style = 'text-align:left;vertical-align: middle;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;'>"
+ "" + ds.Tables[0].Rows[0]["AssotId"].ToString() + "</td><td style = 'text-align:left;vertical-align: middle;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;'>" + Crypto.Decrypt(ds.Tables[0].Rows[0]["AssotPwd"].ToString()) + ""
+ "</td></tr></tbody></table></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
+ "<div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style = 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
+ "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow @afluex.com</i></h4>"
+ "<h4 style = 'color:white' ><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
+ "</div></div></td></tr><tr><td><p style = 'color:#888;font-size:11px;margin-bottom:20px' >© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";
                            }
                            else if (model.ContactusType == "Outdoor Advertising" || model.ContactusType == "Wall Wrap Ads" || model.ContactusType == "Inshop & Outdoor Branding" ||
                         model.ContactusType == "Mobile Van Promotion" || model.ContactusType == "Cinema Or Multiplex Advertising" || model.ContactusType == "Auto Branding"
                         || model.ContactusType == "Printing Services" || model.ContactusType == "Printing Services" || model.ContactusType == "TV Advertising")
                            {
                                subject = "Thank You,For Requesting Demo.";
                                mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
+ "<tr><td><div style = 'background:#fff;vertical-align:top;padding:1px 0;text-align:center;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'>"
+ "<h4 style = 'font-size:20px;padding:10px 8px'>Thank you!<br/> For Requesting Demo.<br/></h4><p style = 'text-align: left;padding-left: 15px;font-size:20px'>"
+ "Dear " + ds.Tables[0].Rows[0]["Name"].ToString() + ",Below is your Login Creditentials :-<br/></p><p style = 'text-align: left;padding-left: 15px;font-size:17px'><a style = 'color: #fff;background-color: #337ab7;border-color: #2e6da4;display: inline-block;padding: 6px 12px;margin-bottom: 0;font-size: 14px;font-weight: 400;line-height: 1.42857143;"
+ "text - align: center; white - space: nowrap; vertical - align: middle; touch - action: manipulation; user - select: none; background - image: none;"
+ "border: 1px solid transparent; border - radius: 4px; ' href='" + ds.Tables[0].Rows[0]["Url"].ToString() + "'>Click Here For Open Demo</a></p>"
+ "<p style = 'text-align: left;padding-left: 15px;font-size:17px'><b> Admin Panel </b></p><table style = 'margin-left: 15px;width: 95%;border: 1px solid #ddd;max-width: 100%;margin-bottom: 20px;background-color: transparent;border-spacing: 0;border-collapse: collapse;ox-sizing: border-box;' cellpadding = '0' cellspacing = '0'>"
+ "<thead><tr style = 'color: #707070;font-weight: 400;box-sizing: border-box;'><th style = 'border-top: 0;vertical-align: middle;border-bottom-width: 2px;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;text-align: left;'>"
+ "Login Id</th><th style = 'border-top: 0;vertical-align: middle;border-bottom-width: 2px;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;text-align: left;'>"
+ "Password</th></tr></thead><tbody><tr style = 'background-color: #f9f9f9;box-sizing: border-box;'><td style = 'text-align:left;vertical-align: middle;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;'>"
+ "" + ds.Tables[0].Rows[0]["AdminLogin"].ToString() + "</td><td style = 'text-align:left;vertical-align: middle;border: 1px solid #ddd;padding: 8px;line-height: 1.42857143;'>" + ds.Tables[0].Rows[0]["AdminPass"].ToString() + "</td></tr></tbody>"
+ "</table></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
+ "<div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style = 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
+ "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow @afluex.com</i></h4>"
+ "<h4 style = 'color:white' ><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
+ "</div></div></td></tr><tr><td><p style = 'color:#888;font-size:11px;margin-bottom:20px' >© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";
                            }
                            else
                            {
                                subject = "Thank You,For Requesting Demo.";
                                mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                           + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                            + "Dear " + ds.Tables[0].Rows[0]["Name"].ToString() + ",<br/> Thank you ! for Requesting Demo.<br/>Our Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -"
                             + "<a href = 'mailto:supportnow@afluex.com' target= '_blank'>supportnow@afluex.com</a>.</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
 + "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
 + "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
 + "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
 + "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";
                            }
                            var fromAddress = new MailAddress("contact.afluex@gmail.com", "Afluex Mutiserices LLP");
                            var toAddress = new MailAddress(model.Email);
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437")
                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = subject,
                                Body = mailbody
                            })
                                smtp.Send(message);
                        }
                        catch (Exception ex)
                        {
                        }




                        //string mob = model.Mobile;
                        //string str = "Dear " + model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                        //try
                        //{
                        //    //BLSMS.SendSMS(mob, str);
                        //}
                        //catch { }


                        string Name = ds.Tables[0].Rows[0]["Name"].ToString();
                        string mob = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str = "Dear " + Name + ", Thank You For Showing Your Interest In Afluex. Our HR Team Will Contact You Soon. For Direct Enquiry Call On 7310000413,412 Or Mail Us On Supportnow@Afluex.Com, Team Afluex";
                        string TempId = "1707166203837277816";
                        try
                        {
                            BLSMS.SendSMSS(mob, str, TempId);
                        }
                        catch { }



                        string messagelbody = "";
                        try
                        {

                            //messagelbody = "<b>Dear team</b>" + "<br/>" + "You got a contact whose " + "<br/>" + " Name : " + model.Name + "<br/>" + " Mobile : " + model.Mobile + "<br/>" + " Message : " + model.Message + " , regarding" + model.ContactusType;

                            mailbody = @"<html><body><div style='margin:0 auto; padding:0px; height:420px; width:600px; background:linear-gradient(146deg, rgba(150, 167, 177, 0.9),rgba(176, 196, 208, 0.9), rgb(220, 230, 235), rgba(232,243,249,6), rgb(182, 200, 210), rgb(135, 147, 153) 100.71%);'>";
                            mailbody += @"<div style='height:90px; width:100%; position:relative; background:rgba(5, 11, 27, 0.92); padding-top:0px'>";
                            mailbody += @"<img src ='https://www.afluex.com/images/tklogo.png' class='img-responsive' alt='logo' style='width:222px;padding-top:4px;padding-left: 188px;position: absolute;'></div>";
                            mailbody += @"<h1 style='color:#c09727; text-transform:capitalize;font-weight:700; padding-left:25px; position:relative;font-size:40px;'> Dear <span style='color:#c09727;font-weight:700;text-transform:capitalize;'>Team,</span></h1>";
                            mailbody += @"<p style='color: #7a7a77;padding-left: 20px;'> You got a contact with " + "<br/>" + "<b> Name :</b> " + model.Name + "<br/>" + " <b>Mobile :</b> " + model.Mobile + "<br/>" + "<b> Message :</b> " + model.Message + " <br/> <b>regarding :</b>  " + model.ContactusType + " <p>";
                            mailbody += @"<div style='height:125px;width:100%;position:relative;background:rgba(5, 11, 27, 0.95);'>";
                            mailbody += @"<b style='text-align:center;padding-left:200px;padding-top: 4px;color: #b8881c;box-sizing:border-box;'>Afluex Multiservices LLP</b>";
                            mailbody += @"<ul style='list-style-type:none;'>";
                            mailbody += @"<li style='font-size:14.5px;padding:0px -1px 0px 35px;color:#dcf1c5'><span style='color:#c09727'>Email :</span><a href='mailto:supportnow@afluex.com' style='color:#dcf1c5' target='_blank'>supportnow@afluex.com</a> <span style='color:#c09727'>Contact No:</span> +91 731-0000-413 / 412 </li>";

                            mailbody += @"<li style='font-size:14.5px; padding:0px -1px 0px 35px; color:#fff'><span style='color:#c09727'>Website :</span><span style='color:#fff'> <a href='https://www.afluex.com' style='color:#dcf1c5' target='_blank'>www.afluex.com</a></span></li>";
                            mailbody += @"<li style='font-size:14.5px; padding:0px -1px 0px 35px;color:#fff; font-style:italic;'> 'Our Expertise in : Advertising & IT Services' </li >";
                            mailbody += @"</ul></div></div></body></html>";
                            var fromAddress = new MailAddress("contact.afluex@gmail.com");
                            var toAddress = new MailAddress("contact.afluex@gmail.com");
                            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437")//"Multiservices@437")

                            };
                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                IsBodyHtml = true,
                                Subject = subject,
                                Body = mailbody
                            })
                                smtp.Send(message);
                            //TempData["ContactMsg"] = "message has been sent. ";
                        }
                        catch (Exception ex)
                        {

                        }


                        //string mobs = "7310000413";
                        //string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message + " , regarding " + model.ContactusType;
                        //try
                        //{
                        //    BLSMS.SendSMS(mobs, str2);
                        //}
                        //catch { }


                        string mobs = "7310000413";
                        string Name2 = ds.Tables[0].Rows[0]["Name"].ToString();
                        string Message = ds.Tables[0].Rows[0]["Message"].ToString();
                        string Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                        string str2 = "Dear team You got a contact whose Name : " + Name2 + ", Mobile : " + Mobile + ", Message : " + Message + ", Team Afluex";
                        string TempId2 = "1707166203848904315";

                        try
                        {
                            BLSMS.SendSMSS(mobs, str2, TempId2);
                        }
                        catch { }



                        TempData["ContactMsg"] = "message has been sent.";
                        FormName = "thankyou";
                        Controller = "advertisement";
                    }
                    else
                    {
                        TempData["ContactMsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
                else
                {
                    string mailbody = "";
                    try
                    {
                        if (strTemp[3].ToString() == "advertisement")
                        {
                            subject = "Thank You,for showing interest in advertising field.";
                            mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                              + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                               + "Dear " + model.Name + ",<br/> Thank you ! for showing interest in advertising field.<br/>Our Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -"
                                + "<a href = 'mailto:supportnow@afluex.com' target= '_blank'>supportnow@afluex.com</a>.</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
    + "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
    + "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
    + "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
    + "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";

                        }
                        else
                        {
                            subject = "Thank you ! for Requesting Demo.";
                            mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                               + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                                + "Dear " + model.Name + ",<br/> Thank you ! for Requesting Demo.<br/>Our Team will contact you soon.For Enquiry call us on 7310000413,412 or Mail us on -"
                                 + "<a href = 'mailto:supportnow@afluex.com' target= '_blank'>supportnow@afluex.com</a>.</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
     + "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
     + "<h4 style = 'color:#fff;font-weight:normal'> 'Our Expertise in : Advertising / IT Services' </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
     + "<h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Website : <i>https://www.afluex.com/</i></h4>"
     + "</div></div></td></tr><tr><td><p style='color:#888;font-size:11px;margin-bottom:20px'>© Copyright 2017 All Rights Reserved</p></td></tr></tbody></table></div>";
                        }
                        var fromAddress = new MailAddress("contact.afluex@gmail.com", "Afluex Multiservices LLP");
                        var toAddress = new MailAddress(model.Email);
                        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437") //"Multiservices@437")

                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            IsBodyHtml = true,
                            Subject = subject,
                            Body = mailbody
                        })
                            smtp.Send(message);
                    }
                    catch (Exception ex)
                    {

                    }


                    //string mob = model.Mobile;
                    //string str =  model.Name + " thank you for showing your interest. Our Team will contact you soon. For Enquiry call on 7310000413,412 or Mail us on supportnow@afluex.com";
                    //try
                    //{
                    //    //BLSMS.SendSMS(mob, str);
                    //}
                    //catch { }


                    string Name = ds.Tables[0].Rows[0]["Name"].ToString();
                    string mob = ds.Tables[0].Rows[0]["Mobile"].ToString();
                    string str = "Dear " + Name + ", Thank You For Showing Your Interest In Afluex. Our HR Team Will Contact You Soon. For Direct Enquiry Call On 7310000413,412 Or Mail Us On Supportnow@Afluex.Com, Team Afluex";
                    string TempId = "1707166203837277816";
                    try
                    {
                        BLSMS.SendSMSS(mob, str, TempId);
                    }
                    catch { }




                    string messagelbody = "";
                    try
                    {
                        mailbody = @"<html><body><div style='margin:0 auto; padding:0px; height:420px; width:600px; background:linear-gradient(146deg, rgba(150, 167, 177, 0.9),rgba(176, 196, 208, 0.9), rgb(220, 230, 235), rgba(232,243,249,6), rgb(182, 200, 210), rgb(135, 147, 153) 100.71%);'>";
                        mailbody += @"<div style='height:90px; width:100%; position:relative; background:rgba(5, 11, 27, 0.92); padding-top:0px'>";
                        mailbody += @"<img src ='https://www.afluex.com/images/tklogo.png' class='img-responsive' alt='logo' style='width:222px;padding-top:4px;padding-left: 188px;position: absolute;'></div>";
                        mailbody += @"<h1 style='color:#c09727; text-transform:capitalize;font-weight:700; padding-left:25px; position:relative;font-size:40px;'> Dear <span style='color:#c09727;font-weight:700;text-transform:capitalize;'>Team,</span></h1>";
                        mailbody += @"<p style='color: #7a7a77;padding-left: 20px;'> You got a contact with " + "<br/>" + "<b> Name :</b> " + model.Name + "<br/>" + " <b>Mobile :</b> " + model.Mobile + "<br/>" + "<b> Message :</b> " + model.Message + " <br/> <b>regarding :</b>  " + model.ContactusType + " <p>";

                        mailbody += @"<div style='height:125px;width:100%;position:relative;background:rgba(5, 11, 27, 0.95);'>";
                        mailbody += @"<b style='text-align:center;padding-left:200px;padding-top: 4px;color: #b8881c;box-sizing:border-box;'>Afluex Multiservices LLP</b>";
                        mailbody += @"<ul style='list-style-type:none;'>";
                        mailbody += @"<li style='font-size:14.5px;padding:0px -1px 0px 35px;color:#dcf1c5'><span style='color:#c09727'>Email :</span><a href='mailto:supportnow@afluex.com' style='color:#dcf1c5' target='_blank'>supportnow@afluex.com</a> <span style='color:#c09727'>Contact No:</span> +91 731-0000-413 / 412 </li>";

                        mailbody += @"<li style='font-size:14.5px; padding:0px -1px 0px 35px; color:#fff'><span style='color:#c09727'>Website :</span><span style='color:#fff'> <a href='https://www.afluex.com' style='color:#dcf1c5' target='_blank'>www.afluex.com</a></span></li>";
                        mailbody += @"<li style='font-size:14.5px; padding:0px -1px 0px 35px;color:#fff; font-style:italic;'> 'Our Expertise in : Advertising & IT Services' </li >";

                        mailbody += @"</ul></div></div></body></html>";
                        var fromAddress = new MailAddress("contact.afluex@gmail.com");
                        var toAddress = new MailAddress("contact.afluex@gmail.com");
                        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437")
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            IsBodyHtml = true,
                            Subject = "Request For Demo " + DateTime.Now.ToString(),
                            Body = messagelbody
                        })
                            smtp.Send(message);
                        TempData["ContactMsg"] = "message has been sent. ";
                    }
                    catch (Exception ex)
                    {
                    }

                    //string mobs = "7310000413";
                    //string str2 = "You got a contact whose name-" + model.Name + " , mob-" + model.Mobile + ", msg-" + model.Message + " , regarding" + model.ContactusType;
                    //try
                    //{
                    //    BLSMS.SendSMS(mobs, str2);
                    //}
                    //catch { }


                    string mobs = "7310000413";
                    string Name2 = ds.Tables[0].Rows[0]["Name"].ToString();
                    string Message = ds.Tables[0].Rows[0]["Message"].ToString();
                    string Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                    string str2 = "Dear team You got a contact whose Name : " + Name2 + ", Mobile : " + Mobile + ", Message : " + Message + ", Team Afluex";
                    string TempId2 = "1707166203848904315";

                    try
                    {
                        BLSMS.SendSMSS(mobs, str2, TempId2);
                    }
                    catch { }

                    TempData["ContactMsg"] = "message has been sent.";
                    FormName = "thankyou";
                    Controller = "advertisement";
                }
            }
            catch (Exception ex)
            {
                TempData["ContactMsg"] = ex.Message;
                FormName = "thankyou";
                Controller = "advertisement";
            }
            return RedirectToAction(FormName, Controller);
        }

        public ActionResult ValidateData(string MemberName, string Contact, string Email, string CusMessage)
        {
            Home model = new Home();
            model.Mobile = Contact;
            model.Name = MemberName;
            try
            {
                Random rnd = new Random();
                string ctrOTP = rnd.Next(111111, 999999).ToString();
                //string strotp = "Dear " + model.Name + ", Your OTP for Demo request is :" + ctrOTP;
                string strotp = "Dear " + model.Name + ", Your OTP for Demo request is " + ctrOTP + ", Team Afluex";
                string mobotp = model.Mobile;
                string mailbody = "";
                try
                {
                    mailbody = "<div style='width:100%;background:#fff;font-size:12px;font-family:Verdana,Geneva,sans-serif'><table style = 'width:640px;border:none;font-size:12px;margin:0 auto' cellpadding = '0' cellspacing = '0'><tbody><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:15px 0'><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div><a><img style = 'width:180px' src = 'https://afluex.com/Softwarecss/images/logo-load.png'></a></div><h1 style = 'color:#fff;font-weight:normal'></h1></div></div></td></tr>"
                + "<tr><td><div style='background:#fff;vertical-align:top;padding:1px 0;border-bottom-right-radius:5px;border-bottom-left-radius:5px;border-left:1px solid #ddd;border-right:1px solid #ddd'><h4 style = 'font-size:14px;padding:10px 8px'>"
                 + "Dear " + MemberName + ",<br/> Your OTP(One Time Password) is" + ctrOTP + "<br/>"
                  + "</h4></div></td></tr><tr><td><div style = 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:1px 0'>"
+ "<div style= 'background:#173d79;text-align:center;border-top-right-radius:5px;border-top-left-radius:5px;padding:0px 0'><div></div><h1 style= 'color:#fff;font-weight:normal'> Afluex Multiservices  LLP</h1>"
+ "<h4 style = 'color:#fff;font-weight:normal'> Our Expertise in : Advertising / IT Services </h4><h4 style = 'color:white'><i class='fa fa-volume-control-phone' aria-hidden='true'></i> &nbsp; Phone No : <i>+91 731-0000-413 / 05223550791</i><i class='fa fa-envelope-o' aria-hidden='true'></i>&nbsp; Email : <i> supportnow@afluex.com</i></h4>"
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
                        Credentials = new NetworkCredential(fromAddress.Address, "Multiservices@437")// "Multiservices@437")

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
                //try
                //{
                //    BLSMS.SendSMS(mobotp, strotp);
                //}
                //catch { }

                string TempId = "1707166203827049342";
                try
                {
                    BLSMS.SendSMSS(mobotp, strotp, TempId);
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
    }
}