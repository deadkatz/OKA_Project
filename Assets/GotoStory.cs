using UnityEngine;
using System.Collections;

public class GotoStory : MonoBehaviour {

	public GameObject blenda;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PrzejdzDoStory ()
	{
		blenda.GetComponent<Animator> ().SetTrigger ("Wyjdz");
		Application.LoadLevel (1);
	}
}