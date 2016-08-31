using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


public class Help : MonoBehaviour {

    public string MailBody = "default";

    public void OnEndMessage(string msg)
    {
        MailBody = msg;
    }

    public void OnValueChanged(string msg)
    {
        MailBody = msg;
    }

    public void onSendButtonClicked()
    {
        
        // 메일 발송
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress("jeonghuny3412@gmail.com");
        mail.To.Add("jeonghuny3412@gmail.com");
        mail.Subject = "test mail";
        mail.Body = MailBody;

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = 
            new System.Net.NetworkCredential("jeonghuny3412@gmail.com", 
            "fltl9292!") as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
        smtpServer.Send(mail);
        Debug.Log("success");
        
        SceneManager.LoadScene("MainMenu");
    }

    public void onBackButtonClicked()
    {
        Debug.Log("abc");
        SceneManager.LoadScene("MainMenu");
    }

    void OnGUI()
    {

    }

}
