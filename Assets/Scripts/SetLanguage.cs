using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetLanguage : MonoBehaviour {
	
	static bool Language = false;

	// Use this for initialization
	void Start () {
	
	}
	void Update (){
	}

	public void SetNewLanguange(){

		if (Language == true) {
			Language = false;

		} else {
			Language = true;
		}

		ChangeLanguage ();
	}

	void ChangeLanguage () {
		GameObject[] ENobj = GameObject.FindGameObjectsWithTag ("en");
		GameObject[] DEobj = GameObject.FindGameObjectsWithTag ("de");

		if (Language == true) {

			for (int i = 0; i < ENobj.Length; i++) {

				ENobj [i].GetComponent<RawImage>().enabled = true;
			}

			for (int i = 0; i < DEobj.Length; i++) {
				DEobj [i].GetComponent<RawImage>().enabled = false;
				}

		} else {
			for (int i = 0; i < DEobj.Length; i++) {
				DEobj [i].GetComponent<RawImage>().enabled = true;
			}
			for (int i = 0; i < ENobj.Length; i++) {
				ENobj [i].GetComponent<RawImage>().enabled = false;
			}
		}
	}
}
