using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WlaczAnimacje : MonoBehaviour {

	public RawImage ikonaOff;
	public GameObject movableObject;
	public bool mail;
	private bool AnimState = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AnimacjaOnOff ()
	{
		AnimState = movableObject.GetComponent<Animator> ().GetBool ("Animuj");
//		Debug.Log (AnimState);
		if (AnimState == false)
		{
			if(mail == false){
			if(ikonaOff.enabled == false){
				GetComponent<KlawiszPoziomController>().Kliknij();
			}else{
				GetComponent<KlawiszPoziomController>().Wylacz();
			}
			}
			movableObject.GetComponent<Animator>().SetBool("Animuj", true);
		}
		else if (AnimState == true)
		{
			if(mail == false){
			if(ikonaOff.enabled == false){
				GetComponent<KlawiszPoziomController>().Kliknij();
			}else{
				GetComponent<KlawiszPoziomController>().Wylacz();
			}
			}
			movableObject.GetComponent<Animator>().SetBool("Animuj", false);
		}
	}

}
