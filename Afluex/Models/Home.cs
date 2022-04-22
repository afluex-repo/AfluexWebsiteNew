using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Afluex.Models
{
    public class Home : Common
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
      //  public string FileUpload { get; set; }
        public string About { get; set; }
        public string CustMessage { get; set; }
        public string Message { get; set; }
        public string ProjectType { get; set; }
        public string YourBudget { get; set; }
        public string ContactusType { get; set; }
        public string CareerType { get; set; }
        public string InquiryType { get; set; }
        public string Password { get; set; } public string LoginId { get; set; }
        public string EncryptPassword { get; set; }
        public string ConfirmPassword { get; set; }

        public string DemoType { get; set; }

        public string Otppin { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl { get; set; }
        public string SponsorId { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public DataSet SaveCareer()
        {
            SqlParameter[] para =
                            {
                                        new SqlParameter("@Name",Name),

                                         new SqlParameter("@Mobile",Mobile),
                                        new SqlParameter("@Email",Email),
                                        new SqlParameter("@Description",Description),
                                         new SqlParameter("@FileUpload",FileUpload),
                                         new SqlParameter("@CareerType",CareerType)

                            };
            DataSet ds = Connection.ExecuteQuery("InsertCareerDetails", para);
            return ds;
        }


        public DataSet SaveDemoDetails()
        {
            SqlParameter[] para =
                            {
                                        new SqlParameter("@Name",Name),
                                        new SqlParameter("@MobileNo",Mobile),
                                        new SqlParameter("@EmailId",Email),
                                        new SqlParameter("@UserName",Email),
                                        new SqlParameter("@Type",ContactusType),
                                        new SqlParameter("@Password",Password),
                                        new SqlParameter("@EncrptPassword", EncryptPassword),
                                        new SqlParameter("@Message",CustMessage),
                                    
                            };
            DataSet ds = Connection.ExecuteQuery("Registration", para);
            return ds;
        }
        public DataSet SaveContactUs()
        {
            SqlParameter[] para =
                           {
                                        new SqlParameter("@Name",Name),
                                        new SqlParameter("@About",About),
                                        new SqlParameter("@MobileNo",Mobile),
                                         new SqlParameter("@EmailId",Email),
                                        new SqlParameter("@Message",Message),

                            };
            DataSet ds = Connection.ExecuteQuery("SaveEnquiry", para);
            return ds;
        }

        public DataSet SaveInquiry()
        {
            SqlParameter[] para =
                            {
                                        new SqlParameter("@Name",Name),
                                        new SqlParameter("@Email",Email),
                                        new SqlParameter("@Mobile",Mobile),
                                        new SqlParameter("@ProjectType",ProjectType),
                                        new SqlParameter("@YourBudget",YourBudget),
                                        new SqlParameter("@Message",Message),
                                        new SqlParameter("@InquiryType",InquiryType)

                            };
            DataSet ds = Connection.ExecuteQuery("InsertInquiry", para);
            return ds;
        }

        public DataSet Login()
        {
            SqlParameter[] para ={new SqlParameter ("@LoginId",LoginId),
                                new SqlParameter("@Password",Password)};
            DataSet ds = Connection.ExecuteQuery("Login", para);
            return ds;
        }

        public DataSet SaveMessage()
        {
            SqlParameter[] para =
                           {
                                        new SqlParameter("@Name",Name),
                                        new SqlParameter("@MobileNo",Mobile),
                                         new SqlParameter("@Email",Email),
                                         new SqlParameter("@FromDate",FromDate),
                                          new SqlParameter("@ToDate",ToDate),
                                        new SqlParameter("@Message",CustMessage),

                            };
            DataSet ds = Connection.ExecuteQuery("InsertMessage", para);
            return ds;
        }
    }
}