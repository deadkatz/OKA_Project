using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class FotoLoader : MonoBehaviour {

	private string FotoString;
	public GameObject Foto01;
	private Texture2D NewFoto01;

	// Use this for initialization
	void Start () {

		GetPictures();
	}

	public void GetPictures(){

		MyService service = new MyService ();
//		service.Timeout = 3000;
	 	byte[] nBytes = new byte[]{48,64,69,92,0};

		FotoString = service.getLiniaPictureBase64String ("BaseLine", 1);

		byte[] bytes = System.Text.Encoding.Default.GetBytes(FotoString);

//		NewFoto01 = System.Convert.FromBase64String (bytes);

//		File.WriteAllBytes ("data.png", bytes);

//		NewFoto01.LoadImage(bytes);

//		NewFoto01 = System.Convert.FromBase64String (FotoString);

//		NewFoto01 = (Texture2D) Resources.Load(bytes);

		Foto01.GetComponent<RawImage>().texture = NewFoto01;

		Debug.Log (FotoString);
}
}
