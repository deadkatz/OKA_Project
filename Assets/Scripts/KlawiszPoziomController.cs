﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KlawiszPoziomController : MonoBehaviour {

	public RawImage ikonaOff;
	public GameObject ikonaOn;
	public GameObject tabOn;
	public bool CurrentImage;
	public bool Lines;

	// Use this for initialization
	void Start () {
		if (CurrentImage == true) {
			for( int i = 0; i < transform.childCount; ++i )
			{
				transform.GetChild(i).gameObject.SetActiveRecursively(true);
			}
			GetComponent<Button>().interactable = false;
//		tabOn.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Kliknij()
	{
		if (ikonaOff.enabled == true)
		{
			if(Lines == false){
			ikonaOff.enabled = false;
			}
			tabOn.SetActive(true);
			ikonaOn.SetActive(true);
		}
	}

	public void Wylacz()
	{
		ikonaOff.enabled = true;
		ikonaOn.SetActive(false);
		tabOn.SetActive(false);
	}
}