using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class CMSLoader : MonoBehaviour
{
	public string Line;
	public int Numer;
	public bool ScenaObiekt = true;
	private string InfoContentDE;
	private string InfoContentEN;

	void Start()
	{
//		GetInfo ();
	}

	public void GetInfo(){

		MyService service = new MyService ();
		service.Timeout = 1500;
//		print(service.);

			//mamy lacznosc...
			if (ScenaObiekt == true) {
				//jesli jestesmy w scenie
				InfoContentDE = service.getScenaTextDE (Line, Numer);
				InfoContentEN = service.getScenaTextEN (Line, Numer);
			} else {
				//jelsi jestesmy w obiekcie
				InfoContentEN = service.getObiektTextEN (Line);
				InfoContentDE = service.getObiektTextDE (Line);
			}
			//wybieramy jezyk
			if (transform.CompareTag ("en")) {
				transform.GetComponent<Text> ().text = InfoContentEN;
			} else if (transform.CompareTag ("de")) {
				transform.GetComponent<Text> ().text = InfoContentDE;
			}
//		} else {
//			//jesli nie mozemy sie polaczyc
//		print(InfoContentEN);
//		}
	}
}