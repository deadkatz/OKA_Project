using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WcisnijKlawiszSceny : MonoBehaviour {

	public GameObject KlawiszWlaczony;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void klawiszScenyWlacz()
	{
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("Klawisz");
		foreach (GameObject target in gameObjects) {
			target.GetComponent<Button> ().interactable = false;
			target.SetActive (false);
		}
			GameObject[] BKG_klawisze = GameObject.FindGameObjectsWithTag ("Bkg_Klawisz");
			foreach (GameObject CurrentKlawisz in BKG_klawisze) {
				CurrentKlawisz.SetActive (false);

			}
		KlawiszWlaczony.SetActive (true);

	}
	public void klawiszliniiWlacz()
	{
		GameObject[] linieKlawisze = GameObject.FindGameObjectsWithTag ("LinieKlawisz");
		foreach (GameObject linietarget in linieKlawisze) {
			linietarget.GetComponent<Button> ().interactable = false;
//			linietarget.SetActive (false);
		}
		GameObject[] BKG_klawisze = GameObject.FindGameObjectsWithTag ("Bkg_Klawisz");
		foreach (GameObject CurrentKlawisz in BKG_klawisze) {
			CurrentKlawisz.SetActive (false);
			
		}

	}
}
//	public void klawiszScenyWylacz()
//	{
////		KlawiszWlaczony.SetActive (false);
//		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Klawisz");
//		foreach (GameObject target in gameObjects) {
//			target.SetActive (false);
//		}
//	}