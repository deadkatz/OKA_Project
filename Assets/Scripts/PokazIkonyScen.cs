using UnityEngine;
using System.Collections;

public class PokazIkonyScen : MonoBehaviour {

	public GameObject IkonyScen;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PokazIkonyScenSkrypt()
	{
		IkonyScen.GetComponent<Animator>().SetTrigger("WjazdScen");
		IkonyScen.GetComponent<Animator> ().ResetTrigger ("WyjazdScen");
	}

	public void UkryjIkonyScenSkrypt()
	{
		IkonyScen.GetComponent<Animator>().SetTrigger("WyjazdScen");
		IkonyScen.GetComponent<Animator>().ResetTrigger("WjazdScen");
	}

}
