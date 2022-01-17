using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Afluex.Models
{
    public class Common
    {
        public string AddedOn { get; set; }
        public string AddedBy { get; set; }
        public string Result { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string DisplayName { get; set; }
        public string FileUpload { get; set; }

        public static string ConvertToSystemDate(string InputDate, string InputFormat)
        {
            string DateString = "";
            DateTime Dt;
            string[] DatePart = (InputDate).Split(new string[] { "-", @"/" }, StringSplitOptions.None);
            if (InputFormat == "dd-MMM-yyyy" || InputFormat == "dd/MMM/yyyy" || InputFormat == "dd/MM/yyyy" || InputFormat == "dd-MM-yyyy" || InputFormat == "DD/MM/YYYY" || InputFormat == "dd/mm/yyyy")
            {
                string Day = DatePart[0];
                string Month = DatePart[1];
                string Year = DatePart[2];
                if (Month.Length > 2)
                    DateString = InputDate;
                else
                    DateString = Month + "/" + Day + "/" + Year;
            }
            else if (InputFormat == "MM/dd/yyyy" || InputFormat == "MM-dd-yyyy")
            {
                DateString = InputDate;
            }
            else
            {
                throw new Exception("Invalid Date");
            }
            try
            {
                //Dt = DateTime.Parse(DateString);
                //return Dt.ToString("MM/dd/yyyy");
                return DateString;
            }
            catch
            {
                throw new Exception("Invalid Date");
            }
        }

        public static string GenerateRandom()
        {
            Random r = new Random();
            string s = "";
            for (int i = 0; i < 6; i++)
            {
                s = string.Concat(s, r.Next(10).ToString());
            }
            return s;
        }
        public DataSet GetCategory()
        {

            DataSet ds = Connection.ExecuteQuery("GetCategory");
            return ds;
        }
        static public void BindDropDown(DropDownList ddl, string dataValueField, string dataTextField, DataTable dtab)
        {
            try
            {

                if (dtab.Rows.Count == 0)
                {
                    ddl.Items.Clear();
                    ddl.Items.Insert(0, new ListItem("----Select----", "0"));
                    return;
                }
                else
                {

                    ddl.DataSource = dtab;
                    ddl.DataTextField = dataTextField;
                    ddl.DataValueField = dataValueField;
                    ddl.DataBind();
                    ddl.Items.Insert(0, new ListItem("----Select----", "0"));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public void ClearControls(ControlCollection page)
        {
            foreach (Control c in page)
            {
                if (c.ID != null)
                {

                    if (c.GetType().ToString() == "System.Web.UI.WebControls.TextBox")
                    {
                        TextBox txt = (TextBox)c;
                        txt.Text = "";
                    }
                    if (c.GetType().ToString() == "System.Web.UI.WebControls.DropDownList")
                    {
                        DropDownList ddl = (DropDownList)c;
                        ddl.SelectedIndex = 0;
                    }
                    if (c.GetType().ToString() == "System.Web.UI.WebControls.CheckBox")
                    {
                        CheckBox chk = (CheckBox)c;
                        chk.Checked = false;
                    }
                    if (c.GetType().ToString() == "System.Web.UI.WebControls.RadioButton")
                    {
                        RadioButton Rad = (RadioButton)c;
                        Rad.Checked = false;
                    }
                    if (c.GetType().ToString() == "System.Web.UI.WebControls.CheckBoxList")
                    {
                        CheckBoxList chkList = (CheckBoxList)c;
                        chkList.Items.Clear();
                    }
                    if (c.GetType().ToString() == "System.Web.UI.WebControls.RadioButtonList")
                    {
                        RadioButtonList RadList = (RadioButtonList)c;
                        RadList.Items.Clear();
                    }
                }

                if (c.HasControls())
                {
                    ClearControls(c.Controls);
                }
            }
        }




    }



}