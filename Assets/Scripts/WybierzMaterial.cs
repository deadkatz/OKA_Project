using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WybierzMaterial : MonoBehaviour {

	public Material materialNaKlawiszu;
	private Texture teksturaNaKlawiszu;

	// Use this for initialization
	void Start () {
		teksturaNaKlawiszu = GetComponent<RawImage> ().texture;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void przeslijWybranyMaterial ()
	{
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().wybranaTekstura = teksturaNaKlawiszu;
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().wybranyMaterial = materialNaKlawiszu;
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().zmienMaterial1Modulu ();

	}
}
