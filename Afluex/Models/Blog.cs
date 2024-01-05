using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Afluex.Models
{
    public class Blog : Common
    {
        public string CategoryName { get; set; }
        public string Fk_CategoryId { get; set; }
        public string Pk_BlogId { get; set; }
        public string Pk_BlogImageId { get; set; }
        public string Title { get; set; }
        [AllowHtml]
        public string ShortDecription { get; set; }
        [AllowHtml]
        public string Decription { get; set; }
        public string FileName { get; set; }
        public DataTable dtimages { get; set; }
        public List<Blog> List { get; set; }
        public List<Blog> lstimages { get; set; }
        public List<Blog> lstcategoryfull { get; set; }
        public List<Blog> lstcategory { get; set; }
        public List<Blog> lsttop4blog { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Message { get; set; }
        public string ContactusType { get; set; }
        
        public string PK_CareerOpporID { get; set; }
        public string MVCDeveloper { get; set; }
        public string MobileApplication { get; set; }
        public string Graphics { get; set; }
        public string SearchEngine { get; set; }
        public string Marketing { get; set; }

        public List<Blog> lstcareer { get; set; }
        public List<Blog> lstvacancy { get; set; }

        public string PK_VacancyID { get; set; }
        public string Designation { get; set; }
        public string MinExperience { get; set; }
        public string SalaryRange { get; set; }

        public string UploadFile { get; set; }
        public string TotalVacancy { get; set; }

        public DataSet SaveBlog()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@BlogCategory", Fk_CategoryId),
                                    new SqlParameter("@BlogImages", dtimages),
                                    new SqlParameter("@Title", Title),
                                    new SqlParameter("@ShortDescription", ShortDecription),
                                    new SqlParameter("@Description", Decription),
                                    new SqlParameter("@AddedBy", AddedBy),


                                  };
            DataSet ds = Connection.ExecuteQuery("SaveBlog", para);
            return ds;
        }
        public DataSet UpdateBlog()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@BlogCategory", Fk_CategoryId),
                                    new SqlParameter("@BlogImages", dtimages),
                                    new SqlParameter("@Title", Title),
                                    new SqlParameter("@ShortDescription", ShortDecription),
                                    new SqlParameter("@Description", Decription),
                                    new SqlParameter("@AddedBy", AddedBy),
                                    new SqlParameter("@Pk_BlogId",Pk_BlogId),

                                  };
            DataSet ds = Connection.ExecuteQuery("UpdateBlog", para);
            return ds;
        }
        public DataSet GetBlog()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_BlogId", Pk_BlogId),
                                    new SqlParameter("@Fk_CategoryId", Fk_CategoryId),


                                  };
            DataSet ds = Connection.ExecuteQuery("GetBlog", para);
            return ds;
        }
       
        public DataSet GetBlogAdvertisement()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Pk_BlogId", Pk_BlogId),
                                    new SqlParameter("@Fk_CategoryId", Fk_CategoryId),


                                  };
            DataSet ds = Connection.ExecuteQuery("GetBlogAdvertisement", para);
            return ds;
        }
        public DataSet GetBlogList()
        {
            DataSet ds = Connection.ExecuteQuery("GetBlogList");
            return ds;
        }

        public DataSet GetBlogListByid()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@PK_BlogId", Pk_BlogId),

                                  };
            DataSet ds = Connection.ExecuteQuery("GetBlogList", para);
            return ds;
        }

        public DataSet GetCareerList()
        {
            DataSet ds = Connection.ExecuteQuery("GetCareerList");
            return ds;
        }
        public DataSet Deleteblog()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@DeletedBy",AddedBy),
                                    new SqlParameter("@PK_BlogID", Pk_BlogId),


                                  };
            DataSet ds = Connection.ExecuteQuery("DeleteBlog", para);
            return ds;
        }
        public DataSet DeleteBlogImage()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@DeletedBy",AddedBy),
                                    new SqlParameter("@Pk_BlogImageId",Pk_BlogImageId),


                                  };
            DataSet ds = Connection.ExecuteQuery("DeleteBlogImage", para);
            return ds;
        }

        
        public DataSet CareerOpportunities()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Description",Description),
                                    new SqlParameter("@MVCDeveloper",MVCDeveloper),
                                        new SqlParameter("@MobileApplication",MobileApplication),
                                    new SqlParameter("@Graphics",Graphics),
                                        new SqlParameter("@SearchEngine",SearchEngine),
                                    new SqlParameter("@Marketing",Marketing),
                                        new SqlParameter("@AddedBy",AddedBy),
                                  };
            DataSet ds = Connection.ExecuteQuery("CareerOpportunities", para);
            return ds;
        }


        public DataSet UpdateCareerOpportunities()
        {
            SqlParameter[] para = {
                     new SqlParameter("@PK_CareerOpporID",PK_CareerOpporID),
                                    new SqlParameter("@Description",Description),
                                    new SqlParameter("@MVCDeveloper",MVCDeveloper),
                                        new SqlParameter("@MobileApplication",MobileApplication),
                                    new SqlParameter("@Graphics",Graphics),
                                        new SqlParameter("@SearchEngine",SearchEngine),
                                    new SqlParameter("@Marketing",Marketing),
                                        new SqlParameter("@AddedBy",AddedBy),
                                  };
            DataSet ds = Connection.ExecuteQuery("UpdateCareerOpportunities", para);
            return ds;
        }
        

        public DataSet GetCareerOpportunitiesList()
        {
            SqlParameter[] para =
            {
                new SqlParameter("@PK_CareerOpporID",PK_CareerOpporID),
            };
            DataSet ds = Connection.ExecuteQuery("GetCareerOpportunitiesList", para);
            return ds;
        }


        public DataSet SaveOpenVacancy()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@Designation",Designation),
                                    new SqlParameter("@MinExperience",MinExperience),
                                        new SqlParameter("@SalaryRange",SalaryRange),
                                            new SqlParameter("@UploadFile",UploadFile),
                                        new SqlParameter("@TotalVacancy",TotalVacancy),
                                        new SqlParameter("@AddedBy",AddedBy)
                                  };
            DataSet ds = Connection.ExecuteQuery("SaveOpenVacancy", para);
            return ds;
        }
        
        public DataSet GetOpenVacancyList()
        {
            SqlParameter[] para = {
                                    new SqlParameter("@PK_VacancyID",PK_VacancyID)
                                  };
            DataSet ds = Connection.ExecuteQuery("GetOpenVacancyList", para);
            return ds;
        }

        

        public DataSet UpdateOpenVacancy()
        {
            SqlParameter[] para = {
                                 new SqlParameter("@PK_VacancyID",PK_VacancyID),
                                    new SqlParameter("@Designation",Designation),
                                    new SqlParameter("@MinExperience",MinExperience),
                                        new SqlParameter("@SalaryRange",SalaryRange),
                                                     new SqlParameter("@UploadFile",UploadFile),
                                        new SqlParameter("@TotalVacancy",TotalVacancy),
                                        new SqlParameter("@AddedBy",AddedBy)
                                  };
            DataSet ds = Connection.ExecuteQuery("UpdateOpenVacancy", para);
            return ds;
        }



        public DataSet DeleteOpenVacancy()
        {
            SqlParameter[] para = {
                                 new SqlParameter("@PK_VacancyID",PK_VacancyID),
                                        new SqlParameter("@AddedBy",AddedBy)
                                  };
            DataSet ds = Connection.ExecuteQuery("DeleteOpenVacancy", para);
            return ds;
        }





        public DataSet GetInquiryList()
        {
            DataSet ds = Connection.ExecuteQuery("GetInquiryList");
            return ds;
        }


    }
}