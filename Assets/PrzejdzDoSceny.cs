using UnityEngine;
using System.Collections;

public class PrzejdzDoSceny : MonoBehaviour {

	public GameObject sceneKontroler;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void zaladujNowaScene ()
	{
		string nazwaSceny = sceneKontroler.GetComponent<SceneController> ().nazwaSceny;

//		if (nazwaSceny == "Firstline_Scene")
//		{
//			Application.LoadLevel ("FirstLine_MainScene");
//		}
//		else
		{
			Application.LoadLevel(nazwaSceny);
		}
	}
}