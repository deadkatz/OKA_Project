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
				ThreadMail ();
		
	}
	void ThreadMail(){
		email = nameInputField.text;
		Debug.Log (email);
		
		MailMessage mail = new MailMessage("kuba@3monkeys.pl", email);
		Attachment a = new Attachment (path, MediaTypeNames.Application.Octet);
		mail.Attachments.Add (a);
		SmtpClient client = new SmtpClient();
		client.Host = "smtp.3monkeys.pl";
		client.Port = 587;
		client.DeliveryMethod = SmtpDeliveryMethod.Network;
		client.UseDefaultCredentials = false;
		client.Credentials = new System.Net.NetworkCredential ("kuba@3monkeys.pl", "cieslIK_15") as ICredentialsByHost;
		client.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback =
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{ return true; };
		mail.Subject = "OKA Configuration";
		mail.Body = "";
		client.Send(mail);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}