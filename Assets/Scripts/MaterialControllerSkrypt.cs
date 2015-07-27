using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaterialControllerSkrypt : MonoBehaviour {

	public int numerModulu = 1;
	public Material wybranyMaterial;
	public Texture wybranaTekstura;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("numer Modulu = " + numerModulu);
	}

	public void zmienMaterial1Modulu()
	{
		//Debug.Log ("Wywolanie zmien material modulu");
		if (numerModulu == 1)
		{
			GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag("Module1");

			for (int i = 0; i < modulyDoWymiany.Length; i++)
			{
				if(modulyDoWymiany[i].GetComponent<Renderer>()){
				modulyDoWymiany[i].GetComponent<MeshRenderer>().material = wybranyMaterial;
				}else if(modulyDoWymiany[i].GetComponent<RawImage>()){
					modulyDoWymiany[i].GetComponent<RawImage>().texture = wybranaTekstura;
				}
			}
		}

		else if (numerModulu == 2)
		{
			GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag("Module2");
			
			for (int i = 0; i < modulyDoWymiany.Length; i++)
			{
				if(modulyDoWymiany[i].GetComponent<Renderer>()){
					modulyDoWymiany[i].GetComponent<MeshRenderer>().material = wybranyMaterial;
				}else if(modulyDoWymiany[i].GetComponent<RawImage>()){
					modulyDoWymiany[i].GetComponent<RawImage>().texture = wybranaTekstura;
				}
			}
		}

		else if (numerModulu == 3)
		{
			GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag("Module3");
			
			for (int i = 0; i < modulyDoWymiany.Length; i++)
			{
				if(modulyDoWymiany[i].GetComponent<Renderer>()){
					modulyDoWymiany[i].GetComponent<MeshRenderer>().material = wybranyMaterial;
				}else if(modulyDoWymiany[i].GetComponent<RawImage>()){
					modulyDoWymiany[i].GetComponent<RawImage>().texture = wybranaTekstura;
				}
			}
		}
	}
}