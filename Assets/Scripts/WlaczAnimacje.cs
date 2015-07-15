using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WlaczAnimacje : MonoBehaviour {

	public RawImage ikonaOff;
	public GameObject movableObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AnimacjaOnOff ()
	{
		if (ikonaOff.enabled == false)
		{
			GetComponent<KlawiszPoziomController>().Kliknij();
			movableObject.GetComponent<Animator>().SetBool("Animuj", true);
		}
		else if (ikonaOff.enabled == true)
		{
			GetComponent<KlawiszPoziomController>().Wylacz();
			movableObject.GetComponent<Animator>().SetBool("Animuj", false);
		}
	}

}
