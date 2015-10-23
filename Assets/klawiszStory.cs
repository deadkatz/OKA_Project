using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class klawiszStory : MonoBehaviour {

	public GameObject prefabObrazek;
	public GameObject miejsceWrzutuPrefaba;
	public Sprite obrazek1;
	private GameObject obrazek;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void otworz1 ()
	{
		prefabObrazek = (GameObject)Resources.Load ("Prefabs/Story/Obrazek", typeof(GameObject));
		GameObject obrazek = Instantiate (prefabObrazek, prefabObrazek.transform.position, prefabObrazek.transform.rotation) as GameObject;
		obrazek.transform.SetParent (miejsceWrzutuPrefaba.transform, false);
		obrazek.GetComponent<Image> ().sprite = obrazek1;
	}

}