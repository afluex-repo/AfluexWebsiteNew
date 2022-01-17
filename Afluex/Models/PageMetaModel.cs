using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Afluex.Models
{
    public class PageMetaDetail
    {
        public static string UpdateMetaDetails(string pageUrl)
        {

            StringBuilder sbMetaTags = new StringBuilder();
            if (pageUrl == "web/INDEX")
            {
                sbMetaTags.Append("<title>Software Development Company & Advertising Agency In Lucknow | Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a digital innovative software development company & advertising agency along with other IT solutions for the clients from the all over INDIA. We work B2B-B2C with industry leading brands to help redefine the possibilities & potential of digital engagement.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='software development company, advertising agency, software development company in lucknow, advertising agency in lucknow, mlm software development copmany, mlm software development'/>");
            }
            if (pageUrl == "web/website-development-services")
            {
                sbMetaTags.Append("<title>Impressive Web Design & Development Company In India| Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Best website development company Afluex is the well-known name as a professional web design and development company based in Lucknow, India. We expertise in providing custom web development, Single Vendor & Multi-Vendor eCommerce web development, MLM website development.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='best web design and website development company in India Lucknow, cheap ecommerce website development and web design company lucknow india, interactive website development and web design company for small business, affordable website developer and website design & development company india lucknow, responsive web design company and multi-vendor ecommerce website developers in india lucknow'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/website-development-services'/>");


            }
            if (pageUrl == "web/it-services")
            {
                sbMetaTags.Append("<title>Responsive Website & Software Development Company In India| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='We are among the best software development company with having a global presence. Afluex specializing in software and website development, MLM software development. Get The Best customized ERP & CRM Software. Are you looking for software and website development company in India, Call us.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='software development company India software development company  in Lucknow, mlm software company custom software development website development, real estate software development company'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/it-services'/>");
            }
            if (pageUrl == "web/company-overview")
            {
                sbMetaTags.Append("<title>Company Overview| Web Development| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/company-overview'/>");
            }
            if (pageUrl == "web/vision-and-mission")
            {
                sbMetaTags.Append("<title>Our Mission And Vision| Web Development| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/vision-and-mission'/>");
            }
            if (pageUrl == "web/our-team")
            {
                sbMetaTags.Append("<title>Web Development Team| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/our-team'/>");
            }
            if (pageUrl == "web/products")
            {
                sbMetaTags.Append("<title> Our Products </title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/products'/>");
            }
            if (pageUrl == "web/portfolio")
            {
                sbMetaTags.Append("<title>Our Portfolio & Creation| Web Development| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/portfolio'/>");
            }
            if (pageUrl == "web/career")
            {
                sbMetaTags.Append("<title>Job Vacancy & Opportunity| Software Development| Career| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/career'/>");
            }
            if (pageUrl == "web/gallery")
            {
                sbMetaTags.Append("<title>Our Gallery| Software Development| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/gallery'/>");
            }
            if (pageUrl == "web/client")
            {
                sbMetaTags.Append("<title>Software Development| Our Clients| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/client'/>");
            }
            if (pageUrl == "web/blog")
            {
                sbMetaTags.Append("<title>Software Development| Blogs| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/blog'/>");
            }
            if (pageUrl == "web/contactus")
            {
                sbMetaTags.Append("<title>Contact Us| Software Development| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='test'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/contactus'/>");
            }
            if (pageUrl == "web/software-development-services")
            {
                sbMetaTags.Append("<title>Software development company in India| Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is an innovative software development company based in Lucknow, India and surrounding areas. We expertise in best software development services, MLM software design, custom software development ERP software, eCommerce, school & hospital management, CRM & HRMS software & various other sectors'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/software-development-services'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='Afluex is a leading mobile app development and ios app development company. We build rich media applications for the ios and android platforms. Are you planning to create a mobile app for your business, Afluex will help you. Feel free to call us.'/>");
            }

            if (pageUrl == "web/app-development-services")
            {
                sbMetaTags.Append("<title>Android & Ios App Development Company In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a leading mobile app development and ios app development company. We build rich media applications for the ios and android platforms. Are you planning to create a mobile app for your business, Afluex will help you. Feel free to call us.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/app-development-services'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/mvc-training-services")
            {
                sbMetaTags.Append("<title>ASP.net & MVC Training Centre In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Acquire knowledge of developing modern, dynamic, server-side web application using asp.net and MVC. Afluex provides live .net MVC training and helps to understand the concept of MVC design and development pattern. Looking for asp.net & MVC training with an expert live instructor? Contact us today.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/mvc-training-services'/>");
                sbMetaTags.Append(Environment.NewLine);
            }

            if (pageUrl == "web/digital-marketing-services")
            {
                sbMetaTags.Append("<title>Digital Marketing Services In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Gain your business online presence using digital marketing services with Afluex. We can help improve your Digital Strategy through SEO, Paid Search, and Social Media Advertising with our team of experts. Call +91 731-0000-413 / 414'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/digital-marketing-services'/>");
                sbMetaTags.Append(Environment.NewLine);
            }

            if (pageUrl == "web/domain-and-hosting-services")
            {
                sbMetaTags.Append("<title>Domain & Hosting Provider In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a powerful domain and hosting provider, 24x7 Support, Easy to Use Dashboard, 1-Click CMS Installation! Buy in INR. Single Domain Hosting,  Windows Hosting, Linux Hosting. Fast servers, Very strong security. Are you need a new web hosting or domain provider? Call +91 731-0000-413/414'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/domain-and-hosting-services'/>");
                sbMetaTags.Append(Environment.NewLine);
            }


            if (pageUrl == "web/real-estate-software")
            {
                sbMetaTags.Append("<title>Real Estate Software & Website Development Company In Lucknow</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a leading software development company that specialing in real estate software and website development. It is a complete list of Real Estate startups in Lucknow,India and surrounding areas. Manage Clients From Any Computer or Location. 100% Web-Based. Demo Now! Live Chat Available.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/real-estate-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }

            if (pageUrl == "web/mlm-software")
            {
                sbMetaTags.Append("<title>MLM Software & Web Development Company In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a big name in the MLM industry for MLM software and website development services. Get MLM software and binary, matrix MLM software at an affordable cost. Develop any kind of MLM Software within your Budget. If you interested MLM Software demo. Call us at +91 731-0000-413 / 414'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/mlm-software'/>");
                sbMetaTags.Append(Environment.NewLine);


                sbMetaTags.Append("<meta name='robots' content='index, follow'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og:title' content='MLM Software & Web Development Company In Lucknow| Afluex'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og:site_name' content='MLM Software'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og:url' content='https://www.Afluex.com/web/mlm-software'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og:description' content='Get MLM software and binary, matrix MLM software at an affordable cost for more Inquiry call +91 731-0000-414'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og:type' content='website'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og:image' content='https://Afluex.com/images/Afluexog.png'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='twitter:card' content='summary'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='twitter:site' content='@AfluexLlp'>");
                sbMetaTags.Append(Environment.NewLine);


                sbMetaTags.Append("<meta name='twitter:creator' content='@AfluexLlp'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='twitter:title' content='MLM Software & Web Development Company In Lucknow| Afluex''>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='twitter:description' content='Get MLM software and binary, matrix MLM software at an affordable cost for more Inquiry call +91 731-0000-414'>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='twitter:image' content='https://Afluex.com/images/Afluexog.png'>");
                sbMetaTags.Append(Environment.NewLine);

            }


            if (pageUrl == "web/ecommerce-software")
            {
                sbMetaTags.Append("<title>Ecommerce Software & Website Design Company In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a professional eCommerce software development company. Grow Your Business With Our Unified Platform.Unlimited 24/7 Support. Secure Shopping Cart. Fraud Prevention. Social Media Integration. Full Blogging Platform. Get more Secure Solution for Mobile Payments on your software.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/ecommerce-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/hospital-management-software")
            {
                sbMetaTags.Append("<title>Hospital Management Software & Website Development Company|Afluex </title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is an innovative software development company based in Lucknow, India, Offers a variety of solution in best hospital management software & website development services like Multilingual, Integrated modules, Mobile App, Cloud Data Access & Backup, Patient Record Management, Patient Portal.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/hospital-management-software'/>");
                sbMetaTags.Append(Environment.NewLine);

            }
            if (pageUrl == "web/school-management-software")
            {
                sbMetaTags.Append("<title>School Management Software & Website Design Company| Afluex </title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is an impressive software development company based in Lucknow, India, Offers a variety of solution in best school management software & website development services. Manage Schedules With Multiple Teachers, Students, Locations. Integrated CRM System, Easy to use, 100% secure. Get the demo.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/school-management-software'/>");
                sbMetaTags.Append(Environment.NewLine);

            }
            if (pageUrl == "web/restaurant-billing-software")
            {
                sbMetaTags.Append("<title>Restaurant Billing Software & Website Design Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is an impressive software development company based in Lucknow, India, Offers a variety of solution in best restaurant billing software & website development services. Vendor Payments. Track Menu-Level Ingredient Price Fluctuations. Easily Manage Invoices. Provide Detailed Insights'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/restaurant-billing-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/crm-software")
            {
                sbMetaTags.Append("<title>CRM Software Company & Website Design Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a big name in the CRM software industry for CRM software and website development services. CRM can allow your team to be more productive by centralizing all of your customer-related data and tasks in one easy to use platform. Our platform helps you with individual customer experiences.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/crm-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/hrms-software")
            {
                sbMetaTags.Append("<title>HRMS Software & Website Design Company In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is an impressive software development company based in all over India. Automate Your Entire HR Process. No Coding. Drag & Drop. Try for Free! Highly Customizable. Custom Workflows. Digital Signature. 360 degree HR & World-class Solution.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/hrms-software'/>");
                sbMetaTags.Append(Environment.NewLine);

            }
            if (pageUrl == "web/erp-software")
            {
                sbMetaTags.Append("<title>ERP Software Company & Website Design Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a leading software development company that specialing in ERP software and website development. Its a complete list of ERP software startups in Lucknow,India and surrounding areas. Learn How We Can Help You.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/erp-software'/>");
                sbMetaTags.Append(Environment.NewLine);

            }
            if (pageUrl == "web/flight-booking-software")
            {
                sbMetaTags.Append("<title>Flight Booking Software & Website Design Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a leading software development company that specialing in flight booking software and website development. Get your flight booking software from Afluex & Get an efficient result from your travel portal.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content=''/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/flight-booking-software'/>");
                sbMetaTags.Append(Environment.NewLine);

            }
            if (pageUrl == "web/inventry-management-software")
            {
                sbMetaTags.Append("<title>Inventory Management Software & Website Design Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex offers advisable inventory management software for your company. It is a complete list of inventory management software development startups & solutions in Lucknow,India and surrounding areas. Our software gives you 100 % secure, complete control over your business & is in perfect compliance.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/inventry-management-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/loan-management-software")
            {
                sbMetaTags.Append("<title>Loan Management Software & Website Development Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Get the best loan management software for your business. Afluex highly configurable solutions to build your check cashing & loans business! First-Class Service. Afluex provides End-to-end loan management software, commercial, consumer, & mortgage lending software.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/loan-management-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/mart-billing-software")
            {
                sbMetaTags.Append("<title>Mart Billing Software & Website Development Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Get the best mart billing software for your business. Afluex highly configurable solutions to build your mart billing software. First-class service. Easily add products. Realtime rating. Automate your billing. Create sales receipts on the spot when selling items or services. Get free demo'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/mart-billing-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/mobile-recharge-software")
            {
                sbMetaTags.Append("<title>Mobile Recharge Software & Website Development Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='We are leading mobile Recharge software provider in India. We offer online mobile payment solutions to make faster and secure mobile payments. We provide high-quality custom recharge software solutions, Multi Recharge Solution, Working capital depends on your daily basis transactions.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/mobile-recharge-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/news-portal-software")
            {
                sbMetaTags.Append("<title>News Portal Software & Website Design| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex offers to customize user-friendly news portal website portal development services in Lucknow, India and surrounding areas. We provide customized news portal design, development, news portal website, and application. To discuss your project Contact Us +91 731-0000-413/414.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/news-portal-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/travel-portal-software")
            {
                sbMetaTags.Append("<title>Travel Portal Software & Website Solution| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a leading travel portal development company deliver travel technology solutions and travel website development in Lucknow, India and surrounding areas. Our main products are Hotel booking engine, Hotel CRS and PMS, Airline ticketing system and Car booking engine.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/travel-portal-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/followup-software")
            {
                sbMetaTags.Append("<title>Follow Up Software & Website Development Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex offers to customize follow-up software design & development services. We help time tracking & projection, easy-to-understand & track the progress. Communicate updates with local & distributed teams, and share task lists, feedback, and assignments from customers.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/followup-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }

            if (pageUrl == "web/daily-expenses-software")
            {
                sbMetaTags.Append("<title>Expense Tracking Software & Management Solution| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Get Real-Time Expense Reporting Software by Afluex. CRM Integration, Setup your budgets & daily limits. Track your projects and invoice clients. Automate your workflows. Gain real-time insights into staff utilization, resource projections.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");

                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/daily-expenses-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }

            if (pageUrl == "web/nidhi-software")
            {
                sbMetaTags.Append("<title>Best Nidhi Software & Website Development Company| RD FD MIS Software</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Afluex is a Nidhi software development and website designing company in Lucknow, India, surrounding areas. Manage RD, FD, MIS online with powerful features. Contact at +91 731-0000-413/ 414 for best Price and free demo.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/nidhi-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }
            if (pageUrl == "web/helping-software")
            {
                sbMetaTags.Append("<title>Helping Plan| Donation Plan & Crowd Funding Software Company| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Get high secured &  fully automated helping plan software design & development company. Afluex provides gift plan mlm software, helping plan mlm software, Crowdfunding software, donation plan MLM software at best price. It also provide free demo for services. Call at +91 731-0000-413 / 414.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='xyz'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.Afluex.com/web/helping-software'/>");
                sbMetaTags.Append(Environment.NewLine);
            }

            if (pageUrl == "web/graphic-designs")
            {
                sbMetaTags.Append("<title>Graphic Designing Company In Lucknow| Smart+Strategic Creative Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='We bring your ideas to life with our custom, fast & great looking graphic designs at reasonable prices. Explore how we can help you with your project. feel free to contact us! +91 522-3550-791. Services- Web Design, Logo Design, Flyer, Brochure.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='interactive branding graphic design agency, graphic designing company lucknow, hire creative professional graphic designer, graphic design services in lucknow'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.afluex.com/web/graphic-designs'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='robots' href='index, follow'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='googlebot' href='index, follow'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: type' content='article' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: title' content='Graphic Designing Company In Lucknow | Smart + Strategic Creative  Afluex' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: description' content='We bring your ideas to life with our custom, fast & great looking graphic designs at reasonable prices. Explore how we can help you with your project. feel free to contact us! +91 522-3550-791. Services- Web Design, Logo Design, Flyer, Brochure' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: url' content='https://www.afluex.com/web/graphic-designs' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: site_name' content='Afluex Multiservices' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='article:publisher' content='https://www.facebook.com/afluexllp/' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:card' content='summary_large_image'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:description' content='We bring your ideas to life with our custom, fast & great looking graphic designs at reasonable prices. Explore how we can help you with your project. feel free to contact us! +91 522-3550-791. Services- Web Design, Logo Design, Flyer, Brochure'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:title' content='Graphic Designing Company In Lucknow| Smart+Strategic Creative  Afluex'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:site' content='@AfluexLlp'/>");
                sbMetaTags.Append(Environment.NewLine);


                sbMetaTags.Append("<meta property='twitter:creator' content='@AfluexLlp'/>");
                sbMetaTags.Append(Environment.NewLine);

            }

            if (pageUrl == "web/seo-services")
            {
                sbMetaTags.Append("<title>SEO Services & Digital Marketing Company In Lucknow| Afluex</title>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='description' content='Looking for the best SEO Services in Lucknow, India? We have a digital marketing plan which includes, Social Media Strategy, Google Ads Strategy. SEO Strategy, and everything in between! Feel Free To Contact Us! +91 522-3550-791.'/>");

                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta name='keywords' content='seo company in lucknow, seo services in lucknow, best seo company, top seo company companies in lucknow, top affordable SEO services in india'/>");
                sbMetaTags.Append("<link rel='canonical' href='https://www.afluex.com/web/seo-services'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='robots' href='index, follow'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<link rel='googlebot' href='index, follow'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: type' content='article' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: title' content='SEO Services & Digital Marketing Company In Lucknow| Afluex' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: description' content='Looking for the best SEO Services in Lucknow, India? We have a digital marketing plan which includes, Social Media Strategy, Google Ads Strategy. SEO Strategy, and everything in between! Feel Free To Contact Us! +91 522-3550-791' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: url' content='https://www.afluex.com/web/seo-services' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='og: site_name' content='Afluex Multiservices' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='article:publisher' content='https://www.facebook.com/afluexllp/' />");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:card' content='summary_large_image'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:description' content='Looking for the best SEO Services in Lucknow, India? We have a digital marketing plan which includes, Social Media Strategy, Google Ads Strategy. SEO Strategy, and everything in between! Feel Free To Contact Us! +91 522-3550-791'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:title' content='SEO Services & Digital Marketing Company In Lucknow| Afluex'/>");
                sbMetaTags.Append(Environment.NewLine);

                sbMetaTags.Append("<meta property='twitter:site' content='@AfluexLlp'/>");
                sbMetaTags.Append(Environment.NewLine);


                sbMetaTags.Append("<meta property='twitter:creator' content='@AfluexLlp'/>");
                sbMetaTags.Append(Environment.NewLine);

            }
            return sbMetaTags.ToString();
        }
    }
}