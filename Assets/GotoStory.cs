using UnityEngine;
using System.Collections;

public class GotoStory : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PrzejdzDoStory ()
	{
		Application.LoadLevel (1);
	}
}