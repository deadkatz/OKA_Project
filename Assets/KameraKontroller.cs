using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KameraKontroller : MonoBehaviour {

	public GameObject target;
	public GameObject przewodnik;
	private int kat = 0;
	public float smoothTime = 1f;
	public Vector3 velocity = Vector3.zero;
	private Vector2 touchOrigin = -Vector2.one;
	private float x;
	private float y;

	public float katPoziom = 45f;
	public float katPion = 10f;

	public bool buttonPressed = false;

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

		//Debug.Log ("button pressed = " + buttonPressed);

		if (buttonPressed == false) {
		
			if (Input.touchCount == 1) {
				Touch myTouch = Input.touches [0];
			
				if (myTouch.phase == TouchPhase.Began) {
					touchOrigin = myTouch.position;
				}
			//else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x > 0)
			else if (myTouch.phase == TouchPhase.Moved && touchOrigin.x > 0) {
					Vector2 touchEnd = myTouch.position;
					x = touchEnd.x - touchOrigin.x;
					y = touchEnd.y - touchOrigin.y;
				
					touchOrigin.x = -1;
					touchOrigin.y = -1;
				
					//if (x > 40 || x < -40 || y > 40 || y < -40)
					//if (x > 1 || x < -1 || y > 1 || y < -1)
					//{
					if (Mathf.Abs(x) > Mathf.Abs (y))
					horizontal = x > 0 ? 1 : -1;
					else
					vertical = y > 0 ? 1 : -1;

				}
//			else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x > 0)
//				{
//					touchOrigin.x = -1;
//					touchOrigin.y = -1;
//				}
			}
		}



		if (Input.GetKeyDown(KeyCode.LeftArrow) || horizontal == 1)
		{
			przewodnik.transform.RotateAround(target.transform.position, Vector3.up, katPoziom);
			//transform.position = Vector3.SmoothDamp(actualPosition, przewodnik.transform.position, ref velocity, smoothTime);
			//transform.position = Vector3.SmoothDamp(transform.position, Vector3.left, ref velocity, smoothTime);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) || horizontal == -1)
		    {
			przewodnik.transform.RotateAround(target.transform.position, Vector3.up, -katPoziom);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) || vertical == 1)
		{
			kat = kat + 1;
			if (kat <= 0)
			{
				przewodnik.transform.RotateAround(target.transform.position, przewodnik.transform.right, -katPion);
			}
			if (kat > 0)
				kat = 0;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow) || vertical == -1)
		{
			kat = kat - 1;
			if (kat >= -4)
			{
				przewodnik.transform.RotateAround(target.transform.position, przewodnik.transform.right, katPion);
			}
			if (kat < -4)
				kat = -4;
		}

		transform.position = Vector3.SmoothDamp(transform.position, przewodnik.transform.position, ref velocity, smoothTime);
		przewodnik.transform.LookAt (target.transform.position);
		transform.LookAt (target.transform.position);
	}
}