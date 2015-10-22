using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisableParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DisableParentFunction() {
		transform.parent.GetComponent<Button>().interactable = false;
	}
}
