using UnityEngine;
using System.Collections;

public class HiResScreenshot : MonoBehaviour {


	
	public void email_send()
	{
		Application.CaptureScreenshot("Screenshot.png");
	}
}