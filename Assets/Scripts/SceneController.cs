using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public string nazwaSceny;

	static string aktualnaScena = "Firstline_Scene_01NEW";

	public bool Storyback = false;

	public GameObject blenda;

	// Use this for initialization
	void Start () {
		nazwaSceny = "Firstline_Scene_01NEW";
		//zmienScene ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void LadujScene (string NowaScena)
	{
			nazwaSceny = NowaScena;
		aktualnaScena = NowaScena;
		blenda.GetComponent<Animator> ().SetTrigger ("Wyjdz");
		//zmienScene ();
	}

	public void LadujStory ()
	{
		if (Storyback == false) {
			nazwaSceny = "Story";
		} else {
			nazwaSceny = aktualnaScena;
		}
		blenda.GetComponent<Animator> ().SetTrigger ("Wyjdz");
		//zmienScene ();
	}

//	public void zmienScene ()
//	{
//		if (nazwaSceny == 1)
//		{
//
//			GameObject aktualnaScena = GameObject.FindGameObjectWithTag("Scena");
////			Destroy(aktualnaScena);
//			
//			//GameObject scenaPrefab = (GameObject)Resources.Load ("Prefabs/biuro_Layer1", typeof(GameObject));
////			GameObject scenaAktualna = Instantiate (scenaPrefab, scenaPrefab.transform.position, scenaPrefab.transform.rotation) as GameObject;
//
//			GameObject.Find ("NazwaInfo").GetComponent<Text>().text = "Lorem Ipsum";
//			GameObject.Find ("Nazwa1Info").GetComponent<Text>().text = "/ Lorem Ipsum";
//			GameObject.Find ("OpisInfo").GetComponent<Text>().text = "Scena 1 Text: Collection of pieces with a 'cabinet-made' feel, with frames in multi-ply finished in gloss white lacquer : their rounded rear corners are characteristic of the collection. Brilliant-chromed handles and metal underframes. Drawer runners equipped with controlled automatic closin";
//		
//		}
//
//		else if (nazwaSceny == 2)
//		{
//
//			GameObject aktualnaScena = GameObject.FindGameObjectWithTag("Scena");
////			Destroy(aktualnaScena);
//			
////			GameObject scenaPrefab = (GameObject)Resources.Load ("Prefabs/biuro_Layer2", typeof(GameObject));
////			GameObject scenaAktualna = Instantiate (scenaPrefab, scenaPrefab.transform.position, scenaPrefab.transform.rotation) as GameObject;
//			
//			GameObject.Find ("NazwaInfo").GetComponent<Text>().text = "Lorem Ipsum2";
//			GameObject.Find ("Nazwa1Info").GetComponent<Text>().text = "/ Lorem Ipsum";
//			GameObject.Find ("OpisInfo").GetComponent<Text>().text = "Scena 2 Text: Collection of pieces with a 'cabinet-made' feel, with frames in multi-ply finished in gloss white lacquer : their rounded rear corners are characteristic of the collection. Brilliant-chromed handles and metal underframes. Drawer runners equipped with controlled automatic closin";
//
//		}
//		
//		else if (nazwaSceny == 3)
//		{
//
//			GameObject aktualnaScena = GameObject.FindGameObjectWithTag("Scena");
////			Destroy(aktualnaScena);
//			
////			GameObject scenaPrefab = (GameObject)Resources.Load ("Prefabs/biuro_Layer3", typeof(GameObject));
////			GameObject scenaAktualna = Instantiate (scenaPrefab, scenaPrefab.transform.position, scenaPrefab.transform.rotation) as GameObject;
//		
//			GameObject.Find ("NazwaInfo").GetComponent<Text>().text = "Lorem Ipsum";
//			GameObject.Find ("Nazwa1Info").GetComponent<Text>().text = "/ Lorem Ipsum";
//			GameObject.Find ("OpisInfo").GetComponent<Text>().text = "Scena 3 Text: Collection of pieces with a 'cabinet-made' feel, with frames in multi-ply finished in gloss white lacquer : their rounded rear corners are characteristic of the collection. Brilliant-chromed handles and metal underframes. Drawer runners equipped with controlled automatic closin";
//
//		}
//		else if (nazwaSceny == 4)
//		{
//			
//			GameObject aktualnaScena = GameObject.FindGameObjectWithTag("Scena");
//			//			Destroy(aktualnaScena);
//			
//			//			GameObject scenaPrefab = (GameObject)Resources.Load ("Prefabs/biuro_Layer3", typeof(GameObject));
//			//			GameObject scenaAktualna = Instantiate (scenaPrefab, scenaPrefab.transform.position, scenaPrefab.transform.rotation) as GameObject;
//			
//			GameObject.Find ("NazwaInfo").GetComponent<Text>().text = "Lorem Ipsum";
//			GameObject.Find ("Nazwa1Info").GetComponent<Text>().text = "/ Lorem Ipsum";
//			GameObject.Find ("OpisInfo").GetComponent<Text>().text = "Scena 4 Text: Collection of pieces with a 'cabinet-made' feel, with frames in multi-ply finished in gloss white lacquer : their rounded rear corners are characteristic of the collection. Brilliant-chromed handles and metal underframes. Drawer runners equipped with controlled automatic closin";
//			
//		}
//		else if (nazwaSceny == 5)
//		{
//			
//			GameObject aktualnaScena = GameObject.FindGameObjectWithTag("Scena");
//			//			Destroy(aktualnaScena);
//			
//			//			GameObject scenaPrefab = (GameObject)Resources.Load ("Prefabs/biuro_Layer3", typeof(GameObject));
//			//			GameObject scenaAktualna = Instantiate (scenaPrefab, scenaPrefab.transform.position, scenaPrefab.transform.rotation) as GameObject;
//			
//			GameObject.Find ("NazwaInfo").GetComponent<Text>().text = "Lorem Ipsum";
//			GameObject.Find ("Nazwa1Info").GetComponent<Text>().text = "/ Lorem Ipsum";
//			GameObject.Find ("OpisInfo").GetComponent<Text>().text = "Scena 5 Text: Collection of pieces with a 'cabinet-made' feel, with frames in multi-ply finished in gloss white lacquer : their rounded rear corners are characteristic of the collection. Brilliant-chromed handles and metal underframes. Drawer runners equipped with controlled automatic closin";
//			
//		}
//		else if (nazwaSceny == 6)
//		{
//			
//			GameObject aktualnaScena = GameObject.FindGameObjectWithTag("Scena");
//			//			Destroy(aktualnaScena);
//			
//			//			GameObject scenaPrefab = (GameObject)Resources.Load ("Prefabs/biuro_Layer3", typeof(GameObject));
//			//			GameObject scenaAktualna = Instantiate (scenaPrefab, scenaPrefab.transform.position, scenaPrefab.transform.rotation) as GameObject;
//			
//			GameObject.Find ("NazwaInfo").GetComponent<Text>().text = "Lorem Ipsum";
//			GameObject.Find ("Nazwa1Info").GetComponent<Text>().text = "/ Lorem Ipsum";
//			GameObject.Find ("OpisInfo").GetComponent<Text>().text = "Scena 6 Text: Collection of pieces with a 'cabinet-made' feel, with frames in multi-ply finished in gloss white lacquer : their rounded rear corners are characteristic of the collection. Brilliant-chromed handles and metal underframes. Drawer runners equipped with controlled automatic closin";
//			
//		}
//	}
}
