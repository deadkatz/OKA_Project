using UnityEngine;
using System.Collections;

public class KoloryWsunSkrypt : MonoBehaviour {

	public GameObject IkonyKolorow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void PokazIkonyKolorowSkrypt()
		{
			IkonyKolorow.GetComponent<Animator>().SetTrigger("KoloryWsun");
			IkonyKolorow.GetComponent<Animator> ().ResetTrigger ("KoloryWysun");
		}
		
	public void UkryjIkonyKolorowSkrypt()
		{
			IkonyKolorow.GetComponent<Animator>().SetTrigger("KoloryWysun");
			IkonyKolorow.GetComponent<Animator>().ResetTrigger("KoloryWsun");
		}

}
