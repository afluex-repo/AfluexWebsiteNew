using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Afluex.Models
{
    public class Ad : Common
    {
        public string Name { get; set; }
        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string FileUpload { get; set; }
        public string About { get; set; }
        public string CusMessage { get; set; }
        public string Message { get; set; }
        public string ProjectType { get; set; }
        public string YourBudget { get; set; }
        public string ContactusType { get; set; }
        public string CareerType { get; set; }

        public string InquiryType { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string DemoType { get; set; }
        public string Otppin { get; set; }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl { get; set; }

        public List<Ad> lstvacancy { get; set; }
        public string PK_VacancyID { get; set; }
        public string Designation { get; set; }
        public string MinExperience { get; set; }
        public string SalaryRange { get; set; }

        public string UploadFile { get; set; }
        public string TotalVacancy { get; set; }

         

        public DataSet SaveContactus()
        {
            SqlParameter[] para =
                            {
                                        new SqlParameter("@Name",Name),
                                        new SqlParameter("@Mobile",Mobile),
                                        new SqlParameter("@Email",Email),
                                        new SqlParameter("@Message",CusMessage),
                                        new SqlParameter("@About",About),
                                        new SqlParameter("@ContactusType",ContactusType)

                            };
            DataSet ds = Connection.ExecuteQuery("InsertContactUsDetails", para);
            return ds;
        }

        //public DataSet SaveContactUs()
        //{
        //    SqlParameter[] para =
        //                   {
        //                                new SqlParameter("@Name",Name),
        //                                new SqlParameter("@About",About),
        //                                new SqlParameter("@MobileNo",Mobile),
        //                                 new SqlParameter("@EmailId",Email),

        //                                new SqlParameter("@Message",Message),

        //                    };
        //    DataSet ds = Connection.ExecuteQuery("SaveEnquiryAD", para);
        //    return ds;
        //}


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


        public DataSet SaveProductDemo()
        {
            SqlParameter[] para =
                            {
                                        new SqlParameter("@Name",Name),
                                        new SqlParameter("@Mobile",Mobile),
                                        new SqlParameter("@Email",Email),
                                        new SqlParameter("@Password",Password),
                                        new SqlParameter("@ConfirmPassword",ConfirmPassword),
                                        new SqlParameter("@Description",Description),
                                        new SqlParameter("@DemoType",DemoType)

                            };
            DataSet ds = Connection.ExecuteQuery("InsertProductDemo", para);
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




    }
}