using Afluex.Filter;
using Afluex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Afluex.Controllers
{
    public class AdminController : AdminBaseController
    {
        // GET: Admin
        public ActionResult DashBoard()
        {

            return View();
        }

        public ActionResult PostBlog(string ID)
        {
            if (ID != null)
            {
                Session["Pk_BlogId"] = ID;
            }
            else
            {
                Session["Pk_BlogId"] = null;
            }
            return View();
        }
        public ActionResult BlogList(Blog obj)
        {
            List<Blog> lst1 = new List<Blog>();
            DataSet ds = obj.GetBlogList();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Blog Obj = new Blog();
                    Obj.Title = r["Title"].ToString();
                    Obj.ShortDecription = r["ShortDecription"].ToString();
                    Obj.Decription = r["Description"].ToString();
                    Obj.Pk_BlogId = r["Pk_BlogId"].ToString();
                    Obj.AddedBy = r["Name"].ToString();
                    Obj.FileUpload = r["AddedOn"].ToString();


                    lst1.Add(Obj);
                }
                obj.List = lst1;
            }
            return View(obj);
        }

        public ActionResult DeleteBlog(string id)
        {
            try
            {
                Blog model = new Blog();
                model.AddedBy = Session["Pk_AdminId"].ToString();
                model.Pk_BlogId = id;
                DataSet ds = model.Deleteblog();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        TempData["Blog"] = "Blog Details Deleted Successfully !!";
                    }
                    else
                    {
                        TempData["Blog"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("BlogList");
        }
        public ActionResult CareerList(Blog obj)
        {
            List<Blog> lst1 = new List<Blog>();
            DataSet ds = obj.GetCareerList();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Blog Obj = new Blog();
                    Obj.FullName = r["FullName"].ToString();
                    Obj.Mobile = r["Mobile"].ToString();
                    Obj.Email = r["Email"].ToString();
                    Obj.Description = r["Description"].ToString();
                    Obj.FileUpload = r["FileUpload"].ToString();
                    Obj.AddedOn = r["AddedOn"].ToString();

                    lst1.Add(Obj);
                }
                obj.List = lst1;
            }
            return View(obj);
        }


        public ActionResult ContactUs(Blog obj)
        {
            List<Blog> lst1 = new List<Blog>();
            DataSet ds = obj.GetCareerList();
            if (ds != null && ds.Tables[1].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[1].Rows)
                {
                    Blog Obj = new Blog();
                    Obj.FullName = r["FullName"].ToString();
                    Obj.About = r["About"].ToString();
                    Obj.Mobile = r["Mobile"].ToString();
                    Obj.Email = r["Email"].ToString();
                    Obj.Message = r["Message"].ToString();
                    Obj.ContactusType = r["ContactusType"].ToString();
                    Obj.AddedOn = r["AddedOn"].ToString();

                    lst1.Add(Obj);
                }
                obj.List = lst1;
            }
            return View(obj);
        }

        public ActionResult CareerOpportunities(string Id)
        {
            Blog model = new Blog();
            if (Id != null)
            {
                model.PK_CareerOpporID = Id;
                DataSet ds = model.GetCareerOpportunitiesList();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    model.PK_CareerOpporID = ds.Tables[0].Rows[0]["PK_CareerOpporID"].ToString();
                    model.MVCDeveloper = ds.Tables[0].Rows[0]["MVCDeveloper"].ToString();
                    model.MobileApplication = ds.Tables[0].Rows[0]["MobileApplication"].ToString();
                    model.Graphics = ds.Tables[0].Rows[0]["Graphics"].ToString();
                    model.SearchEngine = ds.Tables[0].Rows[0]["SearchEngine"].ToString();
                    model.Marketing = ds.Tables[0].Rows[0]["Marketing"].ToString();
                    model.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                }
            }

            return View(model);
        }

        [HttpPost]
        [ActionName("CareerOpportunities")]
        [OnAction(ButtonName = "btnsave")]
        public ActionResult CareerOpportunities(Blog model)
        {
            try
            {
                model.AddedBy = Session["Pk_AdminId"].ToString();
                DataSet ds = model.CareerOpportunities();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        TempData["Careermsg"] = "Career Opportunities Saved Successfully !!";
                    }
                    else
                    {
                        TempData["Careermsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("CareerOpportunities", "Admin");
        }


        [HttpPost]
        [ActionName("CareerOpportunities")]
        [OnAction(ButtonName = "btnupdate")]
        public ActionResult UpdateCareerOpportunities(Blog model)
        {
            try
            {
                model.AddedBy = Session["Pk_AdminId"].ToString();
                DataSet ds = model.UpdateCareerOpportunities();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        TempData["Careermsg"] = "Career Opportunities Updated Successfully !!";
                    }
                    else
                    {
                        TempData["Careermsg"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("CareerOpportunities", "Admin");
        }


        public ActionResult CareerOpportunitiesList(Blog obj)
        {
            List<Blog> lst = new List<Blog>();
            DataSet ds = obj.GetCareerOpportunitiesList();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Blog Obj = new Blog();
                    Obj.PK_CareerOpporID = r["PK_CareerOpporID"].ToString();
                    Obj.MVCDeveloper = r["MVCDeveloper"].ToString();
                    Obj.MobileApplication = r["MobileApplication"].ToString();
                    Obj.Graphics = r["Graphics"].ToString();
                    Obj.SearchEngine = r["SearchEngine"].ToString();
                    Obj.Marketing = r["Marketing"].ToString();
                    Obj.Description = r["Description"].ToString();
                    lst.Add(Obj);
                }
                obj.lstcareer = lst;
            }
            return View(obj);
        }

        public ActionResult OpenVacancy(Blog model, string Id)
        {
            if (Id != null)
            {
                model.PK_VacancyID = Id;
                DataSet ds = model.GetOpenVacancyList();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    model.Designation = ds.Tables[0].Rows[0]["Designation"].ToString();
                    model.MinExperience = ds.Tables[0].Rows[0]["MinExperience"].ToString();
                    model.SalaryRange = ds.Tables[0].Rows[0]["SalaryRange"].ToString();
                    model.UploadFile = ds.Tables[0].Rows[0]["UploadFile"].ToString();
                    model.TotalVacancy = ds.Tables[0].Rows[0]["TotalVacancy"].ToString();
                }
            }
            return View(model);
        }

        [HttpPost]
        [ActionName("OpenVacancy")]
        [OnAction(ButtonName = "btnsave")]
        public ActionResult OpenVacancy(Blog model, HttpPostedFileBase postedFile)
        {
            try
            {
                if (postedFile != null)
                {
                    model.UploadFile = "/UploadFile/" + Guid.NewGuid() + Path.GetExtension(postedFile.FileName);
                    postedFile.SaveAs(Path.Combine(Server.MapPath(model.UploadFile)));
                }
                model.AddedBy = Session["Pk_AdminId"].ToString();
                DataSet ds = model.SaveOpenVacancy();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        TempData["OpenVacancy"] = "Open Vacancy Saved Successfully !!";
                    }
                    else
                    {
                        TempData["OpenVacancy"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("OpenVacancy", "Admin");
        }


        public ActionResult OpenVacancyList(Blog obj)
        {
            List<Blog> lst = new List<Blog>();
            DataSet ds = obj.GetOpenVacancyList();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    Blog Obj = new Blog();
                    Obj.Designation = r["Designation"].ToString();
                    Obj.PK_VacancyID = r["PK_VacancyID"].ToString();
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
        [ActionName("OpenVacancy")]
        [OnAction(ButtonName = "btnupdate")]
        public ActionResult UpdateOpenVacancy(Blog model, HttpPostedFileBase postedFile)
        {
            try
            {

                if (postedFile != null)
                {
                    model.UploadFile = "/UploadFile/" + Guid.NewGuid() + Path.GetExtension(postedFile.FileName);
                    postedFile.SaveAs(Path.Combine(Server.MapPath(model.UploadFile)));
                    
                }
                model.AddedBy = Session["Pk_AdminId"].ToString();
                DataSet ds = model.UpdateOpenVacancy();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        TempData["OpenVacancy"] = "Open Vacancy Updated Successfully !!";
                    }
                    else
                    {
                        TempData["OpenVacancy"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("OpenVacancy", "Admin");
        }



        public ActionResult DeleteOpenVacancy(Blog model, string Id)
        {
            try
            {
                if (Id != null)
                {
                    model.PK_VacancyID = Id;
                    model.AddedBy = Session["Pk_AdminId"].ToString();
                    DataSet ds = model.DeleteOpenVacancy();
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                        {
                            model.Result = "yes";
                            TempData["OpenVacancy"] = "Open Vacancy details Deleted Successfully !!";
                        }
                        else
                        {
                            TempData["OpenVacancy"] = ds.Tables[0].Rows[0]["ErrorMessage"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Json(model,JsonRequestBehavior.AllowGet);
           
        }










    }
}