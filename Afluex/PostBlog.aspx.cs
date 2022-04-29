using Afluex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SD = System.Drawing;

namespace Afluex
{
    public partial class PostBlog : System.Web.UI.Page
    {
        Common obj = new Common();
        Blog objpost = new Blog();
        DataTable dtImages = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["dtSecImages"] = null;
                if (Session["Pk_AdminId"] == null)
                {
                    Response.Redirect("/Web/Login");
                }
                Session["ddlCategoryId"] = null;
                Session["ddlCategoryName"] = null;
                BindCategory();
                if (Session["Pk_BlogId"] != null)
                {
                    GetBlogData();
                }

                //if (Session["Pk_BlogId"] == null)
                //{
                //    Response.Redirect("/Admin/PostBlog");
                //}
                //else
                //{
                //    GetBlogData();
                //}
            }
        }
        protected void GetBlogData()
        {
            objpost.Pk_BlogId = Session["Pk_BlogId"].ToString();
            DataSet ds = objpost.GetBlogListByid();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                ddlcategory.SelectedValue= ds.Tables[0].Rows[0]["PK_CategoryID"].ToString();
                ddlcategorname.Text=ds.Tables[0].Rows[0]["CategoryName"].ToString();
                txttitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                hdnshortdescription.Text = ds.Tables[0].Rows[0]["ShortDecription"].ToString();
                hdndescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                ddlcategorname.Text = ds.Tables[0].Rows[0]["CategoryName"].ToString();
                shortdecription.Value = ds.Tables[0].Rows[0]["ShortDecription"].ToString();
                description.Value = ds.Tables[0].Rows[0]["Description"].ToString();
                gredimages.DataSource = ds.Tables[1];
                gredimages.DataBind();
                gredimages.Visible = true;
                btnUpdate.Visible = true;
                btnpost.Visible = false;
            }
        }
        public void BindCategory()
        {
            DataSet ds = obj.GetCategory();
            Common.BindDropDown(ddlcategory, "PK_CategoryID", "CategoryName", ds.Tables[0]);

        }
        protected void gredimages_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                objpost.Pk_BlogImageId = ((Label)gredimages.Rows[e.RowIndex].FindControl("Pk_BlogImagesId")).Text;
                objpost.AddedBy = Session["Pk_AdminId"].ToString();
                DataSet dsResult = objpost.DeleteBlogImage();
                if (dsResult != null && dsResult.Tables.Count > 0)
                {
                    if (dsResult.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        Response.Write("<script>alert('Image deleted Successfully !')</script>");
                        GetBlogData();
                        return;
                    }
                    else
                    {
                        Response.Write("<script>alert('Image not deleted !')</script>");
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["ddlCategoryId"] == null || Session["ddlCategoryId"] == "")
            {
                Session["ddlCategoryId"] = null;
                Session["ddlCategoryName"] = null;
                Session["ddlCategoryId"] = ',' + ddlcategory.SelectedValue + ',';
                Session["ddlCategoryName"] = ',' + ddlcategory.SelectedItem.Text + ',';
            }
            else
            {

                if (Session["ddlCategoryId"].ToString().Contains(ddlcategory.SelectedValue + ','))
                {

                    Session["ddlCategoryId"] = Session["ddlCategoryId"].ToString().Replace(',' + ddlcategory.SelectedValue + ',', ",");

                    Session["ddlCategoryName"] = Session["ddlCategoryName"].ToString().Replace(',' + ddlcategory.SelectedItem.Text + ',', ",");

                }
                else
                {

                    Session["ddlCategoryId"] = ',' + ddlcategory.SelectedValue + Session["ddlCategoryId"].ToString();
                    Session["ddlCategoryName"] = ',' + ddlcategory.SelectedItem.Text + Session["ddlCategoryName"].ToString();

                }
            }
            ddlcategoryid.Text = Session["ddlCategoryId"].ToString();
            ddlcategorname.Text = Session["ddlCategoryName"].ToString();
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            Session["ddlCategoryId"] = null;
            Session["ddlCategoryName"] = null;
            ddlcategoryid.Text = "";
            ddlcategorname.Text = "";
        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            try
            {
                objpost.Fk_CategoryId = ddlcategoryid.Text;
                objpost.Title = txttitle.Text;
                objpost.ShortDecription = shortdecription.Value;
                objpost.Decription = description.Value;
                objpost.AddedBy = Session["Pk_AdminId"].ToString();
                #region ImageStart
                if (flpimages.HasFiles)
                {
                    foreach (HttpPostedFile uploadedFile in flpimages.PostedFiles)
                    {
                        String path = HttpContext.Current.Request.PhysicalApplicationPath + "SoftwareCss\\images\\blog\\";
                        string filename = DateTime.Now.ToString("ddMMyyyyHHmmsss") + uploadedFile.FileName;

                        //uploadedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Images/NewsSecondaryImage"), filename));
                        Stream strm = uploadedFile.InputStream;
                        using (var image = System.Drawing.Image.FromStream(strm))
                        {
                            #region 270x205
                            int newWidth = Convert.ToInt32(606);
                            int newHeight = Convert.ToInt32(461);

                            var thumbImg = new SD.Bitmap(newWidth, newHeight);
                            var thumbGraph = SD.Graphics.FromImage(thumbImg);
                            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
                            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
                            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            var imgRectangle = new SD.Rectangle(0, 0, newWidth, newHeight);
                            thumbGraph.DrawImage(image, imgRectangle);

                            string targetPath = Server.MapPath("SoftwareCss/images/blog/") + filename;
                            thumbImg.Save(targetPath, image.RawFormat);
                            #endregion 270x205

                        }
                        if (Session["dtSecImages"] != null)
                        {
                            dtImages = (DataTable)Session["dtSecImages"];
                            DataRow dr = null;

                            if (dtImages.Rows.Count > 0)
                            {
                                dr = dtImages.NewRow();

                                dr["ImagePath"] = "SoftwareCss/images/blog/" + filename;
                                dtImages.Rows.Add(dr);
                                Session["dtSecImages"] = dtImages;
                            }
                        }
                        else
                        {
                            dtImages.Columns.Add("ImagePath", typeof(string));
                            DataRow dr = dtImages.NewRow();
                            dr["ImagePath"] = "SoftwareCss/images/blog/" + filename;
                            dtImages.Rows.Add(dr);
                            Session["dtSecImages"] = dtImages;
                        }

                    }
                }
                #endregion ImageEn
                dtImages = (DataTable)Session["dtSecImages"];
                objpost.dtimages = dtImages;
                DataSet ds = objpost.SaveBlog();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        Session["Pk_BlogId"] = null;
                        Common.ClearControls(this.Page.Controls);
                        Response.Write("<script>alert('Blog Saved Successfully!')</script>");
                        return;
                    }
                    else
                    {
                        Response.Write("<script>alert('" + ds.Tables[0].Rows[0]["ErrorMessage"].ToString() + "'')</script>");
                       
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'')</script>");
                return;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objpost.Pk_BlogId = Session["Pk_BlogId"].ToString();
                objpost.Fk_CategoryId = ddlcategoryid.Text;
                objpost.Title = txttitle.Text;
                objpost.ShortDecription = shortdecription.Value;
                objpost.Decription = description.Value;
                objpost.AddedBy = Session["Pk_AdminId"].ToString();
                #region ImageStart
                if (flpimages.HasFiles)
                {
                    foreach (HttpPostedFile uploadedFile in flpimages.PostedFiles)
                    {
                        String path = HttpContext.Current.Request.PhysicalApplicationPath + "SoftwareCss\\images\\blog\\";
                        string filename = DateTime.Now.ToString("ddMMyyyyHHmmsss") + uploadedFile.FileName;

                        //uploadedFile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Images/NewsSecondaryImage"), filename));
                        Stream strm = uploadedFile.InputStream;
                        using (var image = System.Drawing.Image.FromStream(strm))
                        {
                            #region 270x205
                            int newWidth = Convert.ToInt32(606);
                            int newHeight = Convert.ToInt32(461);

                            var thumbImg = new SD.Bitmap(newWidth, newHeight);
                            var thumbGraph = SD.Graphics.FromImage(thumbImg);
                            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
                            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
                            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            var imgRectangle = new SD.Rectangle(0, 0, newWidth, newHeight);
                            thumbGraph.DrawImage(image, imgRectangle);

                            string targetPath = Server.MapPath("SoftwareCss/images/blog/") + filename;
                            thumbImg.Save(targetPath, image.RawFormat);
                            #endregion 270x205

                        }
                        if (Session["dtSecImages"] != null)
                        {
                            dtImages = (DataTable)Session["dtSecImages"];
                            DataRow dr = null;

                            if (dtImages.Rows.Count > 0)
                            {
                                dr = dtImages.NewRow();

                                dr["ImagePath"] = "/SoftwareCss/images/blog/" + filename;
                                dtImages.Rows.Add(dr);
                                Session["dtSecImages"] = dtImages;
                            }
                        }
                        else
                        {
                            dtImages.Columns.Add("ImagePath", typeof(string));
                            DataRow dr = dtImages.NewRow();
                            dr["ImagePath"] = "/SoftwareCss/images/blog/" + filename;
                            dtImages.Rows.Add(dr);
                            Session["dtSecImages"] = dtImages;
                        }

                    }
                }
                #endregion ImageEn
               
                dtImages = (DataTable)Session["dtSecImages"];
                objpost.dtimages = dtImages;
                DataSet ds = objpost.UpdateBlog();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Msg"].ToString() == "1")
                    {
                        Common.ClearControls(this.Page.Controls);
                        Session["Pk_BlogId"] = null;
                        Response.Write("<script>alert('Blog Updated Successfully')</script>");
                       
                        gredimages.Visible = false;
                        btnUpdate.Visible = false;
                        btnpost.Visible = true;
                        hdnshortdescription.Text = "";
                        hdndescription.Text = "";
                        return;

                    }
                    else
                    {
                        Response.Write("<script>alert('" + ds.Tables[0].Rows[0]["ErrorMessage"].ToString() + "'')</script>");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'')</script>");
                return;
            }
        }
    }
}