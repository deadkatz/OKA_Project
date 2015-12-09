using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetLanguage : MonoBehaviour {
	
	static bool Language = false;

	// Use this for initialization
	void Start () {
		ChangeLanguage ();
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

	public void UpdateLanguage(){
		ChangeLanguage ();
	}

	void ChangeLanguage () {
		GameObject[] ENobj = GameObject.FindGameObjectsWithTag ("en");
		GameObject[] DEobj = GameObject.FindGameObjectsWithTag ("de");

		if (Language == true) {

			for (int i = 0; i < ENobj.Length; i++) {

				if(ENobj[i].GetComponent<RawImage>()){

				ENobj [i].GetComponent<RawImage>().enabled = true;

				} else if(ENobj[i].GetComponent<Text>()){

				ENobj [i].GetComponent<Text>().enabled = true;

				} else if(ENobj[i].GetComponent<Button>()){
					
					ENobj [i].GetComponent<Button>().enabled = true;
				}
		}

			for (int i = 0; i < DEobj.Length; i++) {
				if(DEobj[i].GetComponent<RawImage>()){

				DEobj [i].GetComponent<RawImage>().enabled = false;
				}
				else if(DEobj[i].GetComponent<Text>()){
				DEobj [i].GetComponent<Text>().enabled = false;

				} else if(DEobj[i].GetComponent<Button>()){
					
					DEobj [i].GetComponent<Button>().enabled = false;
				}
			}

		} else {
			for (int i = 0; i < DEobj.Length; i++) {
				if(DEobj[i].GetComponent<RawImage>()){
				DEobj [i].GetComponent<RawImage>().enabled = true;
				} 
				else if(DEobj[i].GetComponent<Text>()){
				DEobj [i].GetComponent<Text>().enabled = true;

				} else if(DEobj[i].GetComponent<Button>()){
					
					DEobj [i].GetComponent<Button>().enabled = true;
				}
		}
			for (int i = 0; i < ENobj.Length; i++) {

				if(ENobj[i].GetComponent<RawImage>()){
				ENobj [i].GetComponent<RawImage>().enabled = false;

				}
					else if(ENobj[i].GetComponent<Text>()){
						ENobj [i].GetComponent<Text>().enabled = false;

				} else if(ENobj[i].GetComponent<Button>()){
					
					ENobj [i].GetComponent<Button>().enabled = false;
				}
		}
	}
}
}
