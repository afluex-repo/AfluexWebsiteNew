using Afluex.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                    Obj.Pk_BlogId= r["Pk_BlogId"].ToString();
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
    }
}