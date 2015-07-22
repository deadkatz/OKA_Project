using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KlawiszPoziomController : MonoBehaviour {

	public RawImage ikonaOff;
	public GameObject ikonaOn;
	public GameObject tabOn;
	public bool CurrentImage;

	// Use this for initialization
	void Start () {
		if (CurrentImage != true) {
			ikonaOff.enabled = true;
			ikonaOn.SetActive (false);
//		tabOn.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Kliknij()
	{
		if (ikonaOff.enabled == true)
		{
			ikonaOff.enabled = false;
			tabOn.SetActive(true);
			ikonaOn.SetActive(true);
		}
	}

	public void Wylacz()
	{
		ikonaOff.enabled = true;
		ikonaOn.SetActive(false);
		tabOn.SetActive(false);
	}
}