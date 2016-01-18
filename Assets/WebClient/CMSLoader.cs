using UnityEngine;
using System;
using System.Collections;

public class CMSLoader : MonoBehaviour
{
	void Start()
	{
		MyService service = new MyService();
		string n = service.test (9, 10, "wynik: +");
		Debug.Log(n);
	}
}