using UnityEngine;
using System.Collections;

public class ObslugaCamery : MonoBehaviour {

	public Transform target;
	
	public float distance= 10.0f;
	
	public int cameraSpeed= 10;
	
	public Vector3 targetOffset;
	
	
	
	public float xSpeed= 50.0f;
	
	public float ySpeed= 50.0f;
	
	public float pinchSpeed;
	
	private float lastDist = 10f;
	
	private float curDist = 10f;
	
	
	
	public int yMinLimit= 5; //Lowest vertical angle in respect with the target.
	
	public int yMaxLimit= 30;
	
	
	
	public float minDistance= .5f; //Min distance of the camera from the target
	
	public float maxDistance= 10f;
	
	
	
	private float x= 0.0f;
	
	private float y= 0.0f;
	
	private Touch touch;
	
	private bool CanClick;
	
	private Quaternion currentRotation;
	private Quaternion desiredRotation;
	private Quaternion rotation;

	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;

	public float smoothTimeRot = 0.3F;
	private Vector3 velocityRot = Vector3.zero;
	
	
	void  Start (){
		
		Vector3 angles= transform.eulerAngles;
		
		x = angles.y;
		
		y = angles.x;
		
		
		
		// Make the rigid body not change rotation
		
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		
		if (GetComponent<Rigidbody>())
			
			GetComponent<Rigidbody>().freezeRotation = true;
		
	}
	
	
	
	void  Update (){
		
		if (target && GetComponent<Camera>()) {
			
			
			
			//Zooming with mouse
			
			//			distance += Input.GetAxis("Mouse ScrollWheel")*distance;
			//			
			distance = Mathf.Clamp(distance, minDistance, maxDistance);
			
			
			if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) 
				
			{
				
				//One finger touch does orbit
				
				touch = Input.GetTouch(0);

				if (touch.deltaPosition.x >= 30f || touch.deltaPosition.x <= -30f || touch.deltaPosition.y >=30f || touch.deltaPosition.y <=-30f)
				{
				
					x += touch.deltaPosition.x * xSpeed * Time.deltaTime;
				
					y -= touch.deltaPosition.y * ySpeed * Time.deltaTime;
				}
				
			}
			
			
//			if (Input.touchCount > 1 && (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)) 
//				
//			{
//				
//				//Two finger touch does pinch to zoom
//				
//				var touch1 = Input.GetTouch(0);
//				
//				var touch2 = Input.GetTouch(1);
//				
//				curDist = Vector2.Distance(touch1.position, touch2.position);
//				
//				if(curDist > lastDist)
//					
//				{
//					
//					distance -= Vector2.Distance(touch1.deltaPosition, touch2.deltaPosition)*pinchSpeed/10;
//					//distance = Vector2.Lerp(touch1.deltaPosition, touch2.deltaPosition, cameraSpeed * Time.deltaTime);
//					
//				}else{
//					
//					distance += Vector2.Distance(touch1.deltaPosition, touch2.deltaPosition)*pinchSpeed/10;
//					
//				}
//				
//				
//				
//				lastDist = curDist;
//				
//			}
			
			//Detect mouse drag;
			
			//			if(Input.GetMouseButton(0))   {
			//				
			//				
			//				
			//				x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			//				
			//				y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;       
			//				
			//			}
			
			
			
			
			
			y = ClampAngle(y, yMinLimit, yMaxLimit);
			
			
			
			Quaternion rotation= Quaternion.Euler(y, x, 0);
			
			Vector3 vTemp = new Vector3(0.0f, 0.0f, -distance);
			
			Vector3 position= rotation * vTemp + target.position ;
			
			
			
			//transform.position = Vector3.Lerp (transform.position, position, cameraSpeed);
			transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smoothTime);

			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, smoothTimeRot);
			//transform.rotation = rotation;      
			
		}
		
	}
	
	
	
	static float  ClampAngle ( float angle ,   float min ,   float max  ){
		
		if (angle < -360)
			
			angle += 360;
		
		if (angle > 360)
			
			angle -= 360;
		
		return Mathf.Clamp (angle, min, max);
		
	}


}
