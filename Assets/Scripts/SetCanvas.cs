using UnityEngine;
using System.Collections;

public class SetCanvas : MonoBehaviour {

	public bool isEnabled;

	// Use this for initialization
	void Start () {
		if (isEnabled == true) {
			GetComponent<Canvas> ().sortingOrder = 3;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
