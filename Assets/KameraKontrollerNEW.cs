using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KameraKontrollerNEW : MonoBehaviour {

	public GameObject target;
	public GameObject przewodnik;
	public float smoothTime = 0.3f;
	public Vector3 velocity = Vector3.zero;
	private float PrzesX;
	private float PrzesY;
	
	public bool buttonPressed = false;

	public float ogarniczenieZGory = 4f;

	public float klawiszObrotPoziom = 10f;
	public float klawiszObrotPion = 10f;
	
	// Use this for initialization
	void Start () {
		przewodnik.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (EventSystem.current.currentSelectedGameObject)
			buttonPressed = true;
		else
			buttonPressed = false;
		
		int horizontal = 0;
		int vertical = 0;
		PrzesX = 0;
		PrzesY = 0;
		
		//Debug.Log ("button pressed = " + buttonPressed);
		
		if (buttonPressed == false) 
		{
			
			if (Input.touchCount == 1 || Input.anyKey) {

				if (Input.touchCount == 1)
				{
					Touch myTouch = Input.touches [0];

					if (myTouch.phase == TouchPhase.Moved)
					{
						PrzesX = myTouch.deltaPosition.x;
						PrzesY = myTouch.deltaPosition.y;
					}
				}

				if (Input.GetKey(KeyCode.RightArrow))
				{
					PrzesX = klawiszObrotPoziom;
				}

				if (Input.GetKey(KeyCode.LeftArrow))
				{
					PrzesX = -klawiszObrotPoziom;
				}

				if (Input.GetKey(KeyCode.UpArrow))
				{
					PrzesY = -klawiszObrotPion;
				}

				if (Input.GetKey(KeyCode.DownArrow))
				{
					PrzesY = klawiszObrotPion;
				}

				przewodnik.transform.RotateAround(target.transform.position, Vector3.up, PrzesX/40);

				//if (przewodnik.transform.position.y >= 0f || PrzesY < 0)
				//{
					if (przewodnik.transform.position.y < ogarniczenieZGory || przewodnik.transform.position.y > 0f)
					{
							przewodnik.transform.RotateAround(target.transform.position, przewodnik.transform.right, -PrzesY/6);
					}

					if (przewodnik.transform.position.y > ogarniczenieZGory || przewodnik.transform.position.y < 0f)
					{
						przewodnik.transform.RotateAround(target.transform.position, przewodnik.transform.right, PrzesY/6);
					}
				//}
			}
		}

		transform.position = Vector3.SmoothDamp(transform.position, przewodnik.transform.position, ref velocity, smoothTime);
		przewodnik.transform.LookAt (target.transform.position);
		transform.LookAt (target.transform.position);
	}
}