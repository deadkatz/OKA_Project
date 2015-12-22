using UnityEngine;
using System.Collections;

public class DisableScroll : MonoBehaviour {
	private bool gate;

	// Use this for initialization
	void Start () {


		StartCoroutine (MyCoroutine());
		

	}
	IEnumerator MyCoroutine()
	{
		transform.gameObject.SetActive (true);
		yield return new WaitForSeconds(1);   //Wait one frame
		
		transform.gameObject.SetActive (false);
	}
}
