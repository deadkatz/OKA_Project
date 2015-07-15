using UnityEngine;
using System.Collections;

public class WybierzMaterial : MonoBehaviour {

	public Material materialNaKlawiszu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void przeslijWybranyMaterial ()
	{
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().wybranyMaterial = materialNaKlawiszu;
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().zmienMaterial1Modulu ();
	}
}
