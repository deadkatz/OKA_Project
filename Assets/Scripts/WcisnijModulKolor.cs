using UnityEngine;
using System.Collections;

public class WcisnijModulKolor : MonoBehaviour {

	public GameObject klawiszModulKolorWlaczony;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void wlaczKlawiszModul()
	{
		klawiszModulKolorWlaczony.SetActive (true);
	}

	public void wylaczKlawiszModul()
	{
		klawiszModulKolorWlaczony.SetActive (false);
	}

	public void modul1()
	{
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().numerModulu = 1;
	}

	public void modul2()
	{
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().numerModulu = 2;
	}

	public void modul3()
	{
		GameObject.Find ("MaterialController").GetComponent<MaterialControllerSkrypt> ().numerModulu = 3;
	}
}