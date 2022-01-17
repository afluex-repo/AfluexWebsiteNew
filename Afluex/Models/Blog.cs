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
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Message { get; set; }
        public string ContactusType { get; set; }

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

        public DataSet GetCareerList()
        {
            DataSet ds = Connection.ExecuteQuery("GetCareerList");
            return ds;
        }
    }
}