using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WybierzMaterial : MonoBehaviour {

	public Material materialNaKlawiszu;
	private Texture teksturaNaKlawiszu;
	private string PodpisMaterial;
	public bool StartColor;
	public int Modul = 1;

	// Use this for initialization
	void Start () {
		PodpisMaterial = GetComponentInChildren<Text> ().text;
		teksturaNaKlawiszu = GetComponent<RawImage> ().texture;

		if (StartColor == true) {
			if (Modul == 1) {
				GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag ("Module1");
				for (int i = 0; i < modulyDoWymiany.Length; i++) {
					if (modulyDoWymiany [i].GetComponent<RawImage> ()) {
						modulyDoWymiany [i].GetComponent<RawImage> ().texture = teksturaNaKlawiszu;
				
					} else if (modulyDoWymiany [i].GetComponent<Text> ()) {
						modulyDoWymiany [i].GetComponent<Text> ().text = PodpisMaterial;
					}
				}
			}
			if (Modul == 2) {
				GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag ("Module2");
				for (int i = 0; i < modulyDoWymiany.Length; i++) {
					if (modulyDoWymiany [i].GetComponent<RawImage> ()) {
						modulyDoWymiany [i].GetComponent<RawImage> ().texture = teksturaNaKlawiszu;
						
					} else if (modulyDoWymiany [i].GetComponent<Text> ()) {
						modulyDoWymiany [i].GetComponent<Text> ().text = PodpisMaterial;
					}
				}
			}
			if (Modul == 3) {
				GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag ("Module3");
				for (int i = 0; i < modulyDoWymiany.Length; i++) {
					if (modulyDoWymiany [i].GetComponent<RawImage> ()) {
						modulyDoWymiany [i].GetComponent<RawImage> ().texture = teksturaNaKlawiszu;
						
					} else if (modulyDoWymiany [i].GetComponent<Text> ()) {
						modulyDoWymiany [i].GetComponent<Text> ().text = PodpisMaterial;
					}
				}
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void przeslijWybranyMaterial ()
	{
		PodpisMaterial = GetComponentInChildren<Text> ().text;
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().wybranaTekstura = teksturaNaKlawiszu;
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().wybranyMaterial = materialNaKlawiszu;
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().zmienMaterial1Modulu (PodpisMaterial);
	}

}
