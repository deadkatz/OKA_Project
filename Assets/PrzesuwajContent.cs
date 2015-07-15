using UnityEngine;
using System.Collections;

public class PrzesuwajContent : MonoBehaviour {

	private Vector2 touchOrigin = -Vector2.one;
	public GameObject Content;
	public GameObject znacznik;

	private float x;
	private float y;

	private Vector3 position;
	public float cameraSpeed = 0.1f;

	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;

	public float zoomSpeed = 0.01f;

	// Use this for initialization
	void Start () {
		position = new Vector3 (777, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	


//		if (Input.touchCount == 2)
//		{
//			Touch touchZero = Input.GetTouch(0);
//			Touch touchOne = Input.GetTouch(1);
//			
//			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
//			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
//			
//			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
//			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
//			
//			float deltaMagnitudediff = prevTouchDeltaMag - touchDeltaMag;
//
//			float skalaX = Content.transform.localScale.x;
//			skalaX += deltaMagnitudediff * zoomSpeed;
//			skalaX = Mathf.Clamp (skalaX, 0.25f, 0.5f);
//
//			float skalaY = Content.transform.localScale.y;
//			skalaY += deltaMagnitudediff * zoomSpeed;
//			skalaY = Mathf.Clamp (skalaY, 0.25f, 0.5f);
//
//			float skalaZ = Content.transform.localScale.z;
//			skalaZ += deltaMagnitudediff * zoomSpeed;
//			skalaZ = Mathf.Clamp (skalaZ, 0.25f, 0.5f);
//
//			Content.transform.localScale = new Vector3 (skalaX, skalaY, skalaZ);
//			
//		}


		int horizontal = 0;
		int vertical = 0;
		
		if (Input.touchCount == 1)
		{
			Touch myTouch = Input.touches[0];
			
			if (myTouch.phase == TouchPhase.Began)
			{
				touchOrigin = myTouch.position;
			}
			else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x > 0)
			{
				Vector2 touchEnd = myTouch.position;
				x = touchEnd.x - touchOrigin.x;
				y = touchEnd.y - touchOrigin.y;
				
				touchOrigin.x = -1;
				
				if (x > 40 || x < -40 || y > 40 || y < -40)
				{
					if (Mathf.Abs(x) > Mathf.Abs (y))
						horizontal = x > 0 ? 1 : -1;
					else
						vertical = y > 0 ? 1 : -1;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			horizontal = 1;
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			horizontal = -1;
		}

		
		if (horizontal == 1)
		{
			//swipe w prawo

			float aktualPoz = Content.transform.localPosition.x + 200;
			if (aktualPoz > 777)
				aktualPoz = 777;

			position = new Vector3 (aktualPoz, Content.transform.localPosition.y, Content.transform.localPosition.z);
		}
		if (horizontal == -1) {
			//swipe w lewo
			float aktualPoz = Content.transform.localPosition.x - 200;
			if (aktualPoz < -777)
				aktualPoz = -777;
			position = new Vector3 (aktualPoz, Content.transform.localPosition.y, Content.transform.localPosition.z);
		}
		if (vertical == 1)
		{
			//swipe gora
		}
		if (vertical == -1)
		{
			//swipe dol
		}

		//Content.transform.localPosition = Vector3.Lerp (Content.transform.localPosition, position, cameraSpeed);
		Content.transform.localPosition = Vector3.SmoothDamp(Content.transform.localPosition, position, ref velocity, smoothTime);
		float pozZnacznikX = -334 - ((-777 + Content.transform.localPosition.x) * 0.42f);
		pozZnacznikX = Mathf.Clamp (pozZnacznikX, -334, 314);
		znacznik.transform.localPosition = new Vector3 (pozZnacznikX, znacznik.transform.localPosition.y, znacznik.transform.localPosition.z);

	}
}