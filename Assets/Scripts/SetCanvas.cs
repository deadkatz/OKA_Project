using UnityEngine;
using System.Collections;

public class SetCanvas : MonoBehaviour {

	public bool isEnabled;
	public int CanvasOrder = 0;

	// Use this for initialization
	void Start () {
		if (isEnabled == true) {
			GetComponent<Canvas> ().sortingOrder = 3;
		} else if (CanvasOrder != 0) {
			GetComponent<Canvas> ().sortingOrder = CanvasOrder;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
