using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class FotoLoader : MonoBehaviour {
	
	public string LiniaName;
	public int ScenaName;
	public GameObject[] Fotos;


//	public Texture2D NewFoto01;

	// Use this for initialization
	void Start () {

		GetPictures();
	}

	public void GetPictures(){

		MyService service = new MyService ();
		service.Timeout = 3000;

		for (int i = 0; i <= 1; i++){
			
		Texture2D NewFoto = new Texture2D(2048, 1536);
		byte[] bytes = service.getLiniaPicture (LiniaName, i + 1);
//		Debug.Log ("test");

		NewFoto.LoadImage (bytes);
//		transform.GetComponent<RawImage>().texture = NewFoto;
		Fotos[i].GetComponent<RawImage>().texture = NewFoto;

		}
	}
}
