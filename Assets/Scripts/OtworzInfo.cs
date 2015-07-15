using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OtworzInfo : MonoBehaviour {

	public GameObject infoText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void pokazInfo()
	{
		infoText.GetComponent<Animator>().SetTrigger("InfoWsun");
		infoText.GetComponent<Animator> ().ResetTrigger ("InfoWysun");
	}

	public void ukryjInfo()
	{
		infoText.GetComponent<Animator>().SetTrigger("InfoWysun");
		infoText.GetComponent<Animator>().ResetTrigger("InfoWsun");
	}
}