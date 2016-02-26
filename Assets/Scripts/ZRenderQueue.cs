using UnityEngine;
using System.Collections;

public class ZRenderQueue : MonoBehaviour {
	
	// Use this for initialization
		protected void Start() {

		transform.GetComponent<MeshRenderer> ().sharedMaterial.renderQueue = 3001;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
