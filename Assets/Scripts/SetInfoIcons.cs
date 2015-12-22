using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetInfoIcons : MonoBehaviour {
	public Texture Tekstura;
	public string Opis;

	// Use this for initialization
	void Start () {
						
if (transform.gameObject.GetComponent<RawImage> ()){
			transform.gameObject.GetComponent<RawImage> ().texture = Tekstura;
		}

					
	if(transform.gameObject.GetComponentInChildren<Text>()){
			transform.gameObject.GetComponentInChildren<Text>().text = Opis;
				}
			}

		}
	


