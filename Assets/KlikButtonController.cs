using UnityEngine;
using System.Collections;

public class KlikButtonController : MonoBehaviour {

	public GameObject kamera;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void klawiszKlikniety ()
	{
		kamera = GameObject.Find ("Main Camera");
		kamera.GetComponent<KameraKontroller> ().buttonPressed = true;
	}

	public void klawiszPuszczony ()
	{
		kamera = GameObject.Find ("Main Camera");
		kamera.GetComponent<KameraKontroller> ().buttonPressed = false;
	}
}
