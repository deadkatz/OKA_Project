using UnityEngine;
using System.Collections;

public class WcisnijModulAddon : MonoBehaviour {

	public GameObject klawiszModulAddonWlaczony;

	public GameObject[] addony1;
	public GameObject[] addony2;
	public GameObject[] addony3;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		addony1 = GameObject.FindGameObjectsWithTag ("Item1");
		addony2 = GameObject.FindGameObjectsWithTag ("Item2");
		addony3 = GameObject.FindGameObjectsWithTag ("Item3");
	}

	public void wlaczKlawiszModulAddon()
	{
		klawiszModulAddonWlaczony.SetActive (true);
	}
	
	public void wylaczKlawiszModulAddon()
	{
		klawiszModulAddonWlaczony.SetActive (false);
	}
	
	public void modul1()
	{


		for (int i=0; i<addony1.Length; i++)
		{
			foreach (Transform child in addony1[i].transform)
			 {
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = true;
			}
		}

		for (int i=0; i<addony2.Length; i++) 
		{
			foreach (Transform child in addony2[i].transform) {
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer> ().enabled = false;
			}
		}
		for (int i=0; i<addony3.Length; i++)
		{
			foreach (Transform child in addony3[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = false;
			}
			}
	}
	
	public void modul2()
	{

		for (int i=0; i<addony1.Length; i++)
		{
			foreach (Transform child in addony1[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = false;
			}
				}
		for (int i=0; i<addony2.Length; i++)
		{
			foreach (Transform child in addony2[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = true;
			}
					}

		for (int i=0; i<addony3.Length; i++)
		{
			foreach (Transform child in addony3[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = false;
			}
					}
	}
	
	public void modul3()
	{

		for (int i=0; i<addony1.Length; i++)
		{
			foreach (Transform child in addony1[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = false;
			}
						}
		for (int i=0; i<addony2.Length; i++)
		{
			foreach (Transform child in addony2[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = false;
			}
							}
		for (int i=0; i<addony3.Length; i++)
		{
			foreach (Transform child in addony3[i].transform)
			{
				if(child.GetComponent<Renderer>())
				child.GetComponent<Renderer>().enabled = true;
			}
		}
	}
}