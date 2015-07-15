using UnityEngine;
using System.Collections;

public class UkryjIkonyLinii : MonoBehaviour {

	public GameObject IkonyLinii;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void PokazIkonyLiniiSkrypt()
	{
		IkonyLinii.GetComponent<Animator>().SetTrigger("WjazdScen");
		IkonyLinii.GetComponent<Animator> ().ResetTrigger ("WyjazdScen");
	}
	
	public void UkryjIkonyLiniiSkrypt()
	{
		IkonyLinii.GetComponent<Animator>().SetTrigger("WyjazdScen");
		IkonyLinii.GetComponent<Animator>().ResetTrigger("WjazdScen");
	}
	
}
