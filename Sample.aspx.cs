using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalizationTest
{
    public class SessionBase
    {
        /// <summary>stores the selected EonPage enum, used for exception purpose</summary>
        public static string m_currentLanguage
        {
            get {
                return (string)HttpContext.Current.Session["m_currentLanguage"] ?? "";
            }
            set {
                HttpContext.Current.Session["m_currentLanguage"] = value;
            }
        }
    }

    public partial class Sample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected override void InitializeCulture()
        {
            String m_currentLanguage = SessionBase.m_currentLanguage;

            if (m_currentLanguage!="")
            {
                UICulture = m_currentLanguage;
                Culture = m_currentLanguage;

                System.Threading.Thread.CurrentThread.CurrentCulture =
                    CultureInfo.CreateSpecificCulture(m_currentLanguage);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new
                    CultureInfo(m_currentLanguage);
            }

            base.InitializeCulture();
        }

        void ChangeLanguage(String newLanguage)
        {
            SessionBase.m_currentLanguage = newLanguage;
            Response.Redirect(Request.RawUrl);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //System.Web.UI.ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Language changed to DE')", true);
            ChangeLanguage("de-DE");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //System.Web.UI.ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('Language changed to EN')", true);
            ChangeLanguage("en-US");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ChangeLanguage("fr-FR");
        }
    }
}