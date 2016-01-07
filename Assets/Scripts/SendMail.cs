using UnityEngine;
using System;
using UnityEngine.Networking.Match;
using System.Net.Mail;
using System.Net.Mime;
using UnityEngine.UI;

public class SendMail : MonoBehaviour {

	private string email;

	[SerializeField]
	private InputField nameInputField = null; // Assign in editor

	private void Start()
	{
		// Add listener to catch the submit
		InputField.SubmitEvent submitEvent = new InputField.SubmitEvent();
		submitEvent.AddListener(SubmitName);
		nameInputField.onEndEdit = submitEvent;
		
		// Add validation
		nameInputField.characterValidation = InputField.CharacterValidation.EmailAddress;
	}
	
	private void SubmitName(string name)
	{
		//What to do with the value from input field
		Debug.Log (name);
		email = name;
//		}
	}

	public void UpdateEMail(){
//		Debug.Log (name);
		email = nameInputField.text;
	}

	public void CaptureScreenShot() {
		System.IO.File.Delete ("Screenshot.png");
		Application.CaptureScreenshot("Screenshot.png");
	}

	public void SendMailTo() {

//		Debug.Log ("cokolwiek");

		MailMessage mail = new MailMessage("kuba@3monkeys.pl", email);
		Attachment a = new Attachment ("Screenshot.png", MediaTypeNames.Application.Octet);
		mail.Attachments.Add (a);
		SmtpClient client = new SmtpClient("smtp.3monkeys.pl", 587);
		//client.Port = 587;
		client.DeliveryMethod = SmtpDeliveryMethod.Network;
		client.UseDefaultCredentials = false;
		client.Credentials = new System.Net.NetworkCredential ("kuba@3monkeys.pl", "cieslIK_15");
		//client.Host = "smtp.3monkeys.pl";
		mail.Subject = "OKA Configuration";
		mail.Body = "";
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
