using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetInfoIcons : MonoBehaviour {

//	private Material materialNaKlawiszu;
	public GameObject Przycisk;
	private Texture RoundTexture;
	private string RoundText;

	// Use this for initialization
	void Start () {

		GameObject Przycisk_Instance = Instantiate (Przycisk, new Vector3 (-500,-500,-500), Quaternion.Euler (0, 0, 0)) as GameObject;

		if(Przycisk != null){

		RoundText = Przycisk_Instance.GetComponentInChildren<Text> ().text;
		RoundTexture = Przycisk_Instance.GetComponent<RawImage> ().texture;

//		Debug.Log (PodpisMaterial);

//			GameObject[] modulyDoWymiany = GameObject.FindGameObjectsWithTag ("Module1");
//			for (int i = 0; i < modulyDoWymiany.Length; i++) {

		transform.GetComponent<RawImage> ().texture = RoundTexture;
		transform.GetComponentInChildren<Text> ().text = RoundText;
				}
			}
		}
//	}
//	}
	