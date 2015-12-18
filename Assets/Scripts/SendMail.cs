using UnityEngine;
using System;
using UnityEngine.Networking.Match;
using System.Net.Mail;
using System.Net.Mime;

public class SendMail : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void SendMailTo() {
		Debug.Log ("cokolwiek");
		Application.CaptureScreenshot("Screenshot.png");

		MailMessage mail = new MailMessage("kuba@3monkeys.pl", "w.e.kazimierski@gmail.com");
		Attachment a = new Attachment ("Screenshot.png", MediaTypeNames.Application.Octet);
		mail.Attachments.Add (a);
		SmtpClient client = new SmtpClient("smtp.3monkeys.pl", 587);
		//client.Port = 587;
		client.DeliveryMethod = SmtpDeliveryMethod.Network;
		client.UseDefaultCredentials = false;
		client.Credentials = new System.Net.NetworkCredential ("kuba@3monkeys.pl", "cieslIK_15");
		//client.Host = "smtp.3monkeys.pl";
		mail.Subject = "this is a test email.";
		mail.Body = "this is my test email body";
		client.Send(mail);

//		SmtpClient smtpClient = new SmtpClient();
//		NetworkCredential basicCredential = 
//			new NetworkCredential("kuba@3monkeys.pl", "cieslIK@2015"); 
//		MailMessage message = new MailMessage(); 
//		MailAddress fromAddress = new MailAddress("kuba@3monkeys.pl"); 
//		
//		smtpClient.Host = "smtp.3monkeys.pl";
//		smtpClient.UseDefaultCredentials = false;
//		smtpClient.Credentials = basicCredential;
//		
//		message.From = fromAddress;
//		message.Subject = "your subject";
//		//Set IsBodyHtml to true means you can send HTML email.
//		message.IsBodyHtml = true;
//		message.Body = "<h1>your message body</h1>";
//		message.To.Add("karcisze@gmail.com"); 
//		
//		try
//		{
//			smtpClient.Send(message);
//		}
//		catch(Exception ex)
//		{
//			//Error, could not send the message
//			Debug.Log (ex.Message);
//		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
