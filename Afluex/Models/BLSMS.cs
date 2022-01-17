using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.IO;

namespace Afluex.Models
{
    static public class BLSMS
    {
        static public string SendSMS(string Mobile, string Message)
        {
            //try
            //{

            //    string SMSAPI  = "https://smsw.co.in/API/WebSMS/Http/v1.0a/index.php?username=Afluex&password=f6b7c7-970d7&sender=Afluex&to=" + Mobile + "&message=" + Message + "&reqid=1&format={json}&route_id=39&callback=#&unique=0&sendondate='" + DateTime.Now.ToString() + "'";
            //    SMSAPI = SMSAPI.Replace("[AND]", "&");
            //    SMSAPI = SMSAPI.Replace("[MOBILE]", Mobile);
            //    SMSAPI = SMSAPI.Replace("[MESSAGE]", Message);

            //    HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(SMSAPI, false));
            //    HttpWebResponse httpResponse = (HttpWebResponse)(httpReq.GetResponse());




            //}
            //catch (Exception ex)
            //{
            //}

            string strUrl = "http://smsw.co.in/API/WebSMS/Http/v1.0a/index.php?username=Afluex&password=f6b7c7-970d7&sender=Afluex&to=" + Mobile + "&message=" + Message + "& reqid = 1 & format ={ json}&route_id = 39 & callback =#&unique=0&sendondate='" + DateTime.Now.ToString() + " '";

            WebRequest request = HttpWebRequest.Create(strUrl);
            // Get the response back  
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream s = (Stream)response.GetResponseStream();
            StreamReader readStream = new StreamReader(s);
            string dataString = readStream.ReadToEnd();
            response.Close();
            s.Close();
            readStream.Close();
            return dataString;
        }

        static public string Booking(string BookingNo, string BookingAmount, string AssociateName, string Plot)
        {

            string Message = ConfigurationSettings.AppSettings["Booking"].ToString();


            Message = Message.Replace("[AssociateName]", AssociateName);
            Message = Message.Replace("[BookingNo]", BookingNo);
            Message = Message.Replace("[Plot]", Plot);
            Message = Message.Replace("[BookingAmt]", BookingAmount);
            return Message;


        }
        


        static public string ForgetPassword(string FirstName, string Password)
        {
            string Message = ConfigurationSettings.AppSettings["ForgetPassword"].ToString();

            Message = Message.Replace("[FirstName]", FirstName);
            Message = Message.Replace("[Password]", Password);

            return Message;
        }


        static public string Registration(string MemberName, string LoginId, string Password)
        {
            string Message = ConfigurationSettings.AppSettings["REGISTRATION"].ToString();
            Message = Message.Replace("[Member-Name]", MemberName);
            Message = Message.Replace("[LoginId]", LoginId);
            Message = Message.Replace("[Password]", Password);
           
            return Message;
        }

        
    }
}
