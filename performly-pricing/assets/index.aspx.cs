using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformlyWebsite
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!Request.IsLocal && !Request.IsSecureConnection)
            //{
            //    string redirectUrl = Request.Url.ToString().Replace("http:", "https:");
            //    Response.Redirect(redirectUrl, false);

            //}

        }

        [WebMethod]
        public static string AddDemoRequest(string name, string company, string title, string email, string phone, string message, string random)
        {



            if (name.Length > 500)
                name = name.Substring(0, 500);
            if (company.Length > 500)
                company = company.Substring(0, 500);
            if (title.Length > 500)
                title = title.Substring(0, 500);
            if (email.Length > 500)
                email = email.Substring(0, 500);
            if (phone.Length > 500)
                phone = phone.Substring(0, 500);
            if (message.Length > 4000)
                message = message.Substring(0, 500);
            name = HttpContext.Current.Server.HtmlEncode(name);
            company = HttpContext.Current.Server.HtmlEncode(company);
            title = HttpContext.Current.Server.HtmlEncode(title);
            email = HttpContext.Current.Server.HtmlEncode(email);
            phone = HttpContext.Current.Server.HtmlEncode(phone);
            message = HttpContext.Current.Server.HtmlEncode(message);


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("AddDemoRequest", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddRange(new SqlParameter[] { new SqlParameter("name",name),new SqlParameter("company",company),new SqlParameter("title",title)
                               ,new SqlParameter("email",email),new SqlParameter("phone",phone),new SqlParameter("message",message)});
            int result = command.ExecuteNonQuery();
            con.Close();
            string newCaption = (new Random().Next() % 10000).ToString();
            HttpContext.Current.Session["random"] = newCaption;

            try
            {
                SendMail(name, company, title, email, phone, message);
            }
            catch { }

            return newCaption;
        }

        private static void SendMail(string name, string company, string title, string email, string phone, string mesg)
        {

            Dictionary<string, string> parametes = new Dictionary<string, string>();
            parametes.Add("#Details#", "Name:<b> " + name + " </b><br/>company:<b> " + company + "</b><br/> title:<b> " + title + "</b><br/> mail:<b> " + email + "</b><br/> phone:<b> " + phone + "</b><br/> message:<b> " + mesg);
            parametes.Add("Subject", "Demo Request");
            parametes.Add("#EmailSubject#", "Demo Request");
            parametes.Add("#EmailFrom#", "Performly.Notification@Performly.com");
            Mail mail = new Mail("hany.nabil@a15.com;sameh.makin@a15.com;hany.nabil@performly.com;sameh.makin@performly.com", "", "", 156, parametes);
            mail.AddEmailRecord(System.Configuration.ConfigurationManager.ConnectionStrings["PMSConnectionString"].ConnectionString);



            //Dictionary<string, string> parametes = new Dictionary<string, string>();
            //parametes.Add("#Details#", "Name:<b> " + name + " </b><br/>company:<b> " + company + "</b><br/> title:<b> " + title + "</b><br/> mail:<b> " + email + "</b><br/> phone:<b> " + phone + "</b><br/> message:<b> " + mesg);
            //parametes.Add("#EmailFrom#", "demo@performly.com");
            //parametes.Add("Subject", "Performy Demo Request");
            //parametes.Add("#EmailSubject#", "Performy Demo Request");
            try
            {
                Mail mail2 = new Mail();
                mail2.EM_UserMail = email;
                mail2.ET_ID = 159;
                mail2.EM_Attach = "c:\\Performly_Notebook.pdf";

                mail2.AddEmailRecord(System.Configuration.ConfigurationManager.ConnectionStrings["PMSConnectionString"].ConnectionString);
            }
            catch { }
            //return;
            //MailMessage mailMsg = new MailMessage();


            //var smtp = new SmtpClient
            //{
            //    Host = "41.128.145.143",
            //    Port = 25,
            //    // EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = true,
            //    //  Credentials = new NetworkCredential("demo@Performly.com","OTV@MIS321456")
            //};
            //using (var message = new MailMessage("demo@Performly.com", "sameh.makin@a15.com")
            //{
            //    Subject = "Demo Request",
            //    Body = "Body",
            //    IsBodyHtml = true
            //})
            //{
            //    smtp.Send(message);
            //}
        }
    }



    /// <summary>
    /// 
    /// </summary>
    internal class Mail
    {
        /// <summary>
        /// 
        /// </summary>
        private class Strings
        { }
        #region Fields
        #region Email Message fields
        /// <summary>
        /// 
        /// </summary>
        int em_ID = -1;
        /// <summary>
        /// 
        /// </summary>
        string em_UserMail;
        /// <summary>
        /// 
        /// </summary>
        string em_CC;
        /// <summary>
        /// 
        /// </summary>
        string em_BCC;
        /// <summary>
        /// 
        /// </summary>
        string em_Attach;
        /// <summary>
        /// 
        /// </summary>
        int et_ID;
        /// <summary>
        /// 
        /// </summary>
        int em_SendStatus = -1;
        /// <summary>
        /// 
        /// </summary>
        DateTime creation_date;
        /// <summary>
        /// 
        /// </summary>
        DateTime send_date;
        /// <summary>
        /// 
        /// </summary>
        Dictionary<string, string> em_Parameters;
        #endregion

        #region Email Type fields
        /// <summary>
        /// 
        /// </summary>
        string et_From = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        string et_Subject = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        string et_MessageBody = string.Empty;
        #endregion
        #endregion

        #region Properties
        #region Email Message fields
        /// <summary>
        /// 
        /// </summary>
        public int EM_ID
        {
            get { return em_ID; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EM_UserMail
        {
            get { return em_UserMail; }
            set { em_UserMail = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EM_CC
        {
            get { return em_CC; }
            set { em_CC = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EM_BCC
        {
            get { return em_BCC; }
            set { em_BCC = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EM_Attach
        {
            get { return em_Attach; }
            set { em_Attach = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ET_ID
        {
            get { return et_ID; }
            set { et_ID = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return em_Parameters; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int EM_SendStatus
        {
            get { return em_SendStatus; }
            set { em_SendStatus = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreationDate
        {
            get { return creation_date; }
            set { creation_date = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SendDate
        {
            get { return send_date; }
            set { send_date = value; }
        }
        #endregion

        #region Email Type fields
        /// <summary>
        /// 
        /// </summary>
        public string ET_From
        {
            get { return et_From; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ET_Subject
        {
            get { return et_Subject; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ET_MessageBody
        {
            get { return et_MessageBody; }
        }
        #endregion
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Mail()
        {
            em_UserMail = string.Empty;
            em_CC = string.Empty;
            em_BCC = string.Empty;
            et_ID = -1;
            em_Parameters = new Dictionary<string, string>();
            creation_date = send_date = DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EM_UserMail"></param>
        /// <param name="EM_CC"></param>
        /// <param name="EM_BCC"></param>
        /// <param name="ET_ID"></param>
        public Mail(string EM_UserMail, string EM_CC, string EM_BCC, int ET_ID)
        {
            em_UserMail = EM_UserMail;
            em_CC = EM_CC;
            em_BCC = EM_BCC;
            et_ID = ET_ID;
            em_Parameters = new Dictionary<string, string>();
            creation_date = send_date = DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EM_UserMail"></param>
        /// <param name="EM_CC"></param>
        /// <param name="EM_BCC"></param>
        /// <param name="ET_ID"></param>
        /// <param name="EM_Parameters"></param>
        public Mail(string EM_UserMail, string EM_CC, string EM_BCC, int ET_ID, Dictionary<string, string> EM_Parameters)
        {
            em_UserMail = EM_UserMail;
            em_CC = EM_CC;
            em_BCC = EM_BCC;
            et_ID = ET_ID;
            em_Parameters = (EM_Parameters != null) ? EM_Parameters : new Dictionary<string, string>();
            creation_date = send_date = DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EM_UserMail"></param>
        /// <param name="EM_CC"></param>
        /// <param name="EM_BCC"></param>
        /// <param name="ET_ID"></param>
        /// <param name="CreationDate"></param>
        /// <param name="SendDate"></param>
        public Mail(string EM_UserMail, string EM_CC, string EM_BCC, int ET_ID, DateTime CreationDate, DateTime SendDate)
        {
            em_UserMail = EM_UserMail;
            em_CC = EM_CC;
            em_BCC = EM_BCC;
            et_ID = ET_ID;
            em_Parameters = new Dictionary<string, string>();
            creation_date = CreationDate;
            send_date = SendDate;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EM_UserMail"></param>
        /// <param name="EM_CC"></param>
        /// <param name="EM_BCC"></param>
        /// <param name="ET_ID"></param>
        /// <param name="EM_Parameters"></param>
        /// <param name="CreationDate"></param>
        /// <param name="SendDate"></param>
        public Mail(string EM_UserMail, string EM_CC, string EM_BCC, int ET_ID, Dictionary<string, string> EM_Parameters, DateTime CreationDate, DateTime SendDate)
        {
            em_UserMail = EM_UserMail;
            em_CC = EM_CC;
            em_BCC = EM_BCC;
            et_ID = ET_ID;
            em_Parameters = (EM_Parameters != null) ? EM_Parameters : new Dictionary<string, string>();
            creation_date = CreationDate;
            send_date = SendDate;
        }
        #endregion

        #region Methods

        #region Helper Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetParametersXML()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("Params");
            ds.Tables[0].Columns.Add("name");
            ds.Tables[0].Columns.Add("value");

            foreach (string key in em_Parameters.Keys)
            {
                ds.Tables[0].Rows.Add(key, em_Parameters[key]);
            }

            StringWriter writer = new StringWriter();
            ds.WriteXml(writer);

            return writer.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        private void GetMessageParameters(string connectionString)
        {
            SqlCommand command = new SqlCommand("EMAIL_GET_MESSAGE_PARAMETERS", new SqlConnection(connectionString));
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.Add("@EM_ID", SqlDbType.Int).Value = em_ID;

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    em_Parameters[reader["ET_PARAM_NAME"].ToString()] = reader["EM_PARAM_VALUE"].ToString();
                }
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception in GetMessageParameters. connectionString = " + connectionString, ex);
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void ParseMessageParameters()
        {
            foreach (string key in em_Parameters.Keys)
            {
                et_MessageBody = et_MessageBody.Replace(key, em_Parameters[key]);
            }
        }
        #endregion

        #region Class Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public int AddEmailRecord(string connectionString)
        {

            //#if Debug
            //           em_UserMail = "sameh.makin@mail.link.net";
            //#endif
            em_ID = 0;

            SqlCommand command = new SqlCommand("EMAIL_ADD_MESSAGE", new SqlConnection(connectionString));
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                //to insert the Email Record into link database and return the id of mail inserted
                #region Generate Params
                command.Parameters.Add("@EM_USER_MAIL", SqlDbType.NVarChar).Value = em_UserMail;
                command.Parameters.Add("@EM_CC", SqlDbType.NVarChar).Value = em_CC;
                command.Parameters.Add("@EM_BCC", SqlDbType.NVarChar).Value = em_BCC;
                if (em_Attach != null && em_Attach != String.Empty)
                    command.Parameters.Add("@EM_ATTACH", SqlDbType.NVarChar).Value = em_Attach;
                command.Parameters.Add("@ET_ID", SqlDbType.SmallInt).Value = et_ID;
                command.Parameters.Add("@EM_PARAMETER_VALUES", SqlDbType.Xml).Value = GetParametersXML();
                command.Parameters.Add("@CREATION_DATE", SqlDbType.DateTime).Value = creation_date;
                command.Parameters.Add("@SEND_DATE", SqlDbType.DateTime).Value = send_date;

                SqlParameter param = new SqlParameter("@EM_ID", SqlDbType.Int);
                param.Value = DBNull.Value;
                param.Direction = ParameterDirection.Output;
                command.Parameters.Add(param);
                #endregion

                #region Execute SP and get result
                command.Connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                //to return the EM_ID
                int.TryParse(command.Parameters["@EM_ID"].Value.ToString(), out em_ID);
                #endregion

                return em_ID;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception in AddEmailRecord. connectionString = " + connectionString, ex);
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString"></param>
        public void UpdateMessageStatus(string connectionString)
        {
            SqlCommand command = new SqlCommand("EMAIL_UPDATE_MESSAGE_STATUS", new SqlConnection(connectionString));
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Parameters.Add("@EM_ID", SqlDbType.Int).Value = em_ID;
                command.Parameters.Add("@EM_SEND_STATUS", SqlDbType.SmallInt).Value = em_SendStatus;

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception in UpdateMessageStatus. connectionString = " + connectionString, ex);
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }
        #endregion

        #region Static Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static Mail[] GetMessagesByStatus(int status, string connectionString)
        {
            SqlCommand command = new SqlCommand("EMAIL_GET_MESSAGES_BY_STATUS", new SqlConnection(connectionString));
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Parameters.Add("@EM_SEND_STATUS", SqlDbType.SmallInt).Value = status;
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Mail> output = new List<Mail>();
                while (reader.Read())
                {
                    Mail mail = new Mail();
                    mail.em_ID = (int)reader["EM_ID"];
                    mail.em_UserMail = (string)reader["EM_USER_MAIL"];
                    if (reader["EM_CC"] != null && reader["EM_CC"].ToString() != string.Empty)
                        mail.em_CC = (string)reader["EM_CC"];
                    if (reader["EM_BCC"] != null && reader["EM_BCC"].ToString() != string.Empty)
                        mail.em_BCC = (string)reader["EM_BCC"];
                    if (reader["EM_ATTACH"].ToString() != null && reader["EM_ATTACH"].ToString() != string.Empty)
                        mail.em_Attach = (string)reader["EM_ATTACH"];
                    mail.et_ID = (short)reader["ET_ID"];

                    mail.et_From = (string)reader["ET_FROM"];
                    mail.et_Subject = (string)reader["ET_SUBJECT"];
                    mail.et_MessageBody = (string)reader["ET_MESSAGE_BODY"];

                    mail.creation_date = (DateTime)reader["CREATION_DATE"];
                    mail.send_date = (DateTime)reader["SEND_DATE"];

                    mail.em_SendStatus = status;

                    output.Add(mail);
                }
                command.Connection.Close();

                foreach (Mail mail in output)
                {
                    mail.GetMessageParameters(connectionString);
                    mail.ParseMessageParameters();
                }

                return output.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sendDate"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static Mail[] GetMessagesBySendDate(DateTime sendDate, string connectionString)
        {
            SqlCommand command = new SqlCommand("EMAIL_GET_MESSAGES_BY_SEND_DATE", new SqlConnection(connectionString));
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Parameters.Add("@SEND_DATE", SqlDbType.DateTime).Value = sendDate;
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Mail> output = new List<Mail>();
                while (reader.Read())
                {
                    Mail mail = new Mail();
                    mail.em_ID = (int)reader["EM_ID"];
                    mail.em_UserMail = (string)reader["EM_USER_MAIL"];
                    if (reader["EM_CC"] != null && reader["EM_CC"].ToString() != string.Empty)
                        mail.em_CC = (string)reader["EM_CC"];
                    if (reader["EM_BCC"] != null && reader["EM_BCC"].ToString() != string.Empty)
                        mail.em_BCC = (string)reader["EM_BCC"];
                    if (reader["EM_ATTACH"].ToString() != null && reader["EM_ATTACH"].ToString() != string.Empty)
                        mail.em_Attach = (string)reader["EM_ATTACH"];
                    mail.et_ID = (short)reader["ET_ID"];

                    mail.et_From = (string)reader["ET_FROM"];
                    mail.et_Subject = (string)reader["ET_SUBJECT"];
                    mail.et_MessageBody = (string)reader["ET_MESSAGE_BODY"];

                    mail.creation_date = (DateTime)reader["CREATION_DATE"];
                    mail.send_date = (DateTime)reader["SEND_DATE"];

                    mail.em_SendStatus = (int)reader["EM_SEND_STATUS"];

                    output.Add(mail);
                }
                command.Connection.Close();

                foreach (Mail mail in output)
                {
                    mail.GetMessageParameters(connectionString);
                    mail.ParseMessageParameters();
                }

                return output.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="sendDate"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static Mail[] GetMessagesByStatusAndSendDate(int status, DateTime sendDate, string connectionString)
        {
            SqlCommand command = new SqlCommand("EMAIL_GET_MESSAGES_BY_STATUS_AND_SEND_DATE", new SqlConnection(connectionString));
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Parameters.Add("@EM_SEND_STATUS", SqlDbType.SmallInt).Value = status;
                command.Parameters.Add("@SEND_DATE", SqlDbType.DateTime).Value = sendDate;

                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Mail> output = new List<Mail>();
                while (reader.Read())
                {
                    Mail mail = new Mail();
                    mail.em_ID = (int)reader["EM_ID"];
                    mail.em_UserMail = (string)reader["EM_USER_MAIL"];
                    if (reader["EM_CC"] != null && reader["EM_CC"].ToString() != string.Empty)
                        mail.em_CC = (string)reader["EM_CC"];
                    if (reader["EM_BCC"] != null && reader["EM_BCC"].ToString() != string.Empty)
                        mail.em_BCC = (string)reader["EM_BCC"];
                    if (reader["EM_ATTACH"].ToString() != null && reader["EM_ATTACH"].ToString() != string.Empty)
                        mail.em_Attach = (string)reader["EM_ATTACH"];
                    mail.et_ID = (short)reader["ET_ID"];

                    mail.et_From = (string)reader["ET_FROM"];
                    mail.et_Subject = (string)reader["ET_SUBJECT"];
                    mail.et_MessageBody = (string)reader["ET_MESSAGE_BODY"];

                    mail.creation_date = (DateTime)reader["CREATION_DATE"];
                    mail.send_date = (DateTime)reader["SEND_DATE"];

                    mail.em_SendStatus = status;

                    output.Add(mail);
                }
                command.Connection.Close();

                foreach (Mail mail in output)
                {
                    mail.GetMessageParameters(connectionString);
                    mail.ParseMessageParameters();
                }

                return output.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeID"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public DataSet GetMailTypeByID(int typeID, string connectionString)
        {
            using (SqlCommand command = new SqlCommand("EMAIL_TYPE_GET_BY_ID", new SqlConnection(connectionString)))
            {
                command.Parameters.AddWithValue("@TypeID", typeID);
                command.CommandType = CommandType.StoredProcedure;
                DataSet dsFeedback = new DataSet();

                try
                {
                    if (command.Connection.State != ConnectionState.Open)
                        command.Connection.Open();

                    SqlDataAdapter objAdapter = new SqlDataAdapter(command);
                    objAdapter.Fill(dsFeedback, "tempTable");
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    if (command.Connection.State == ConnectionState.Open)
                        command.Connection.Close();
                }

                return dsFeedback;
            }
        }
        #endregion

        #endregion
    }
}