using UnityEngine;
using System;
using System.IO;
using UnityEngine.Networking.Match;
using System.Net.Mail;
using System.Net.Mime;
using UnityEngine.UI;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

public class SendMail : MonoBehaviour {

	public string email;
	private string path = (Application.persistentDataPath + "/Screenshot.png");
	
	[SerializeField]
	private InputField nameInputField = null; // Assign in editor

	void Start()
	{
		// Add listener to catch the submit
		InputField.SubmitEvent submitEvent = new InputField.SubmitEvent();
		submitEvent.AddListener(SubmitName);
		nameInputField.onEndEdit = submitEvent;
		
		// Add validation
		nameInputField.characterValidation = InputField.CharacterValidation.EmailAddress;

		if (Application.platform == RuntimePlatform.IPhonePlayer) {
		
			path = (Application.persistentDataPath + "/Screenshot.png");
		} else {
			path = (Application.persistentDataPath + "/Screenshot.png");
		}
	}
	
	private void SubmitName(string name)
	{
		//What to do with the value from input field
//		email = name;
//		}
	}

	public void UpdateEMail(){
//		Debug.Log (email);
		email = nameInputField.text;
	}

	public void CaptureScreenShot() {

//		System.IO.File.Delete (path);
		Application.CaptureScreenshot(path);

		
		print(path);
	}

	public void SendMailTo() {
		ThreadPool.QueueUserWorkItem(x => ThreadMail());
//		ThreadMail ();


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
	void ThreadMail(){
		email = nameInputField.text;
		Debug.Log (email);
		
		MailMessage mail = new MailMessage("app@oka.de", email);
		Attachment a = new Attachment (path, MediaTypeNames.Application.Octet);
		mail.Attachments.Add (a);
		SmtpClient client = new SmtpClient();
		client.Host = "okangs9.ngdf.oka.de";
		client.Port = 587;
		client.DeliveryMethod = SmtpDeliveryMethod.Network;
		client.UseDefaultCredentials = false;
		client.Credentials = new System.Net.NetworkCredential ("app@oka.de", "oka") as ICredentialsByHost;
		client.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback =
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{ return true; };
		//client.Host = "smtp.3monkeys.pl";
		mail.Subject = "OKA Configuration";
		mail.Body = "";
		client.Send(mail);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
