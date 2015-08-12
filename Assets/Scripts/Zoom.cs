using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

	public GameObject kameraGlowna;
	public float perspectiveZoomSpeed = 0.3f;

	private float FOVpoprzedni = 60f;
	private float FOVdocelowy = 60f;

	public float perspectiveVelocity;

	public float zoomSpeedKlawiatury = 100f;

	public float zoomMin = 30.0f;
	public float zoomMax = 70.0f;
//	public bool SetForAndroid;

	// Use this for initialization
	void Start () {
		if (Application.platform == RuntimePlatform.Android) {
			perspectiveZoomSpeed = perspectiveZoomSpeed *2;
		}
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.touchCount == 2 || Input.anyKey)
		{
			if (Input.touchCount == 2)
			{
				Touch touchZero = Input.GetTouch(0);
				Touch touchOne = Input.GetTouch(1);
				
				Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
				Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
				
				float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
				float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
				
				float deltaMagnitudediff = prevTouchDeltaMag - touchDeltaMag;
				FOVpoprzedni = kameraGlowna.GetComponent<Camera>().fieldOfView;
				FOVdocelowy = Mathf.Round(FOVpoprzedni + deltaMagnitudediff);
			}

			if (Input.GetKey(KeyCode.A))
			{
				FOVpoprzedni = kameraGlowna.GetComponent<Camera>().fieldOfView;
				FOVdocelowy = Mathf.Round(FOVpoprzedni - perspectiveVelocity * zoomSpeedKlawiatury);
			}
			else if (Input.GetKey(KeyCode.Z))
			{
				FOVpoprzedni = kameraGlowna.GetComponent<Camera>().fieldOfView;
				FOVdocelowy = Mathf.Round(FOVpoprzedni + perspectiveVelocity *  zoomSpeedKlawiatury);
			}
				

			if (FOVdocelowy < zoomMin)
			{
				FOVdocelowy = zoomMin;
				//deltaMagnitudediff = 0;
			}
			else if (FOVdocelowy > zoomMax)
			{
				FOVdocelowy = zoomMax;
			}

//			kameraGlowna.GetComponent<Camera>().fieldOfView = Mathf.SmoothDamp (FOVpoprzedni, FOVdocelowy, ref perspectiveVelocity, perspectiveZoomSpeed);
			kameraGlowna.GetComponent<Camera>().fieldOfView = Mathf.Lerp (FOVpoprzedni, FOVdocelowy, perspectiveVelocity * perspectiveZoomSpeed);
			//FOVdocelowy = Mathf.Clamp(FOVdocelowy, 30, 70);
		}

		//kameraGlowna.GetComponent<Camera>().fieldOfView = Mathf.SmoothDamp (FOVpoprzedni, FOVdocelowy, ref perspectiveVelocity, perspectiveZoomSpeed);

	}
}
