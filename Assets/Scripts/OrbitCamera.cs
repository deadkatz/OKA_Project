using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.UI;
using System.Collections;

//[AddComponentMenu("Camera-Control/Mouse drag Orbit with zoom")]
public class OrbitCamera : MonoBehaviour
{
	private Transform target;
	private string stringTarget;
	
	public Transform watchTarget;
	
//	public GameObject Env;
	
	public float distance = 13.0f;
	public float xSpeed = 15.0f;
	public float ySpeed = 30.0f;
	
	public float yMinLimit = 5f;
	public float yMaxLimit = 40f;
	
	private float pinchSpeed;
	private float distanceMin = .5f;
	private float distanceMax = 15f;
	
	private float smoothTime = 2f;
	
	private Touch touch;
//	private bool CanClick;
	
	private float lastDist = 0;
	private float curDist = 0;
	private float NewDistance;
	private float OldDistance;
	private float pinchsmoothtime;
	private Vector3 targetOffset;
	private bool CamAnim = false;
	private Vector3 TargetPosition;
	private Quaternion FromRot;
	private Quaternion ToRot;
	private float LerpTime;
//	public Animator Fader;
	
	float rotationYAxis = 0.0f;
	float rotationXAxis = 0.0f;
	
	float velocityX = 0.0f;
	float velocityY = 0.0f;

	
	// Use this for initialization
	void Start()
	{
		Vector3 angles = transform.eulerAngles;
		rotationYAxis = angles.y;
		rotationXAxis = angles.x;

		target = watchTarget;
		
		// Make the rigid body not change rotation
		if (GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}
//	void Fade(bool isOpen){
//		if (isOpen) {
//			Fader.enabled = true;
//			Fader.SetBool ("isOpen", false);
//		} else {
//			Fader.enabled = true;
//			Fader.SetBool ("isOpen", true);
//		}
//	}
	
//	void SetNewOffset (int renderTarget){
//		if (renderTarget == 0) {
//			targetOffset = new Vector3( 0, 0, 0 )/10;
//		} else if(renderTarget == 1) {
//			targetOffset = new Vector3( 0, 0, 7 )/10;
//		}else if(renderTarget == 2){
//			targetOffset = new Vector3( 0, 25, 0 )/10;
//		}else if(renderTarget == 3){
//			targetOffset = new Vector3( 0, 5, 0 )/10;
//		}else if(renderTarget == 4){
//			targetOffset = new Vector3( 0, 5, 0 )/10;
//		}else if(renderTarget == 5){
//			targetOffset = new Vector3( 0, 10, 0 )/10;
//		}
//	}
	
	void LateUpdate()
	{
		if (EventSystem.current.currentSelectedGameObject) {
			target = null;
		}else{
				target = watchTarget;
		}

		
		if (!EventSystem.current.IsPointerOverGameObject () && !CamAnim) {
			//print (transform.rotation.eulerAngles);
			
			// allow/rotate your camera
			if (target && GetComponent<Camera> ()) {
				
				//				distance += Input.GetAxis("Mouse ScrollWheel")*NewDistance;
				
				distance = Mathf.Clamp (distance, distanceMin, distanceMax);
				
				if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Moved) {
					touch = Input.GetTouch (0);
					velocityX += xSpeed * touch.deltaPosition.x * 0.02f;
					velocityY += ySpeed * touch.deltaPosition.y * 0.02f;
				}
				
//				if (Input.touchCount > 1 && (Input.GetTouch (0).phase == TouchPhase.Moved || Input.GetTouch (1).phase == TouchPhase.Moved)) {
//					
//					//Two finger touch does pinch to zoom
//					
//					var touch1 = Input.GetTouch (0);
//					
//					var touch2 = Input.GetTouch (1);
//					
//					curDist = Vector2.Distance (touch1.position, touch2.position);
//					
//					//distance = OldDistance;
//					
//					if (curDist > lastDist) {
//						
//						NewDistance = Vector2.Distance (touch1.deltaPosition, touch2.deltaPosition) * pinchSpeed / 10;
//						distance -= NewDistance;
//						
//					} else {
//						
//						NewDistance = Vector2.Distance (touch1.deltaPosition, touch2.deltaPosition) * pinchSpeed / 10;
//						distance += NewDistance;
//						
//					}
//					//
//					if (distance <= distanceMin) {
//						//minimum camera distance
//						distance = distanceMin;
//					}
//					
//					if (distance >= distanceMax) {
//						//maximum camera distance
//						distance = distanceMax;
//					}
//					lastDist = curDist;	
//					//distance = distance * (1 - Time.deltaTime * 10);
//				}
											if(Input.GetMouseButton(0))   {
												
												
												
									velocityX += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
												
									velocityY -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;       
												
											}
				
				
				rotationYAxis += velocityX;
				rotationXAxis -= velocityY;
				
				rotationXAxis = ClampAngle (rotationXAxis, yMinLimit, yMaxLimit);
				
				//print (distance);
				
				
				Quaternion fromRotation = Quaternion.Euler (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
				Quaternion toRotation = Quaternion.Euler (rotationXAxis, rotationYAxis, 0);
				Quaternion rotation = toRotation;
				
				Vector3 negDistance = new Vector3 (0.0f, 0.0f, -distance);
				Vector3 position = rotation * negDistance + target.position + targetOffset;
				
				transform.rotation = rotation;
				transform.position = position;
				
				//distance = Mathf.Lerp(distance, NewDistance, Time.deltaTime * smoothTime);
				
				velocityX = Mathf.Lerp (velocityX, 0, Time.deltaTime * smoothTime);
				velocityY = Mathf.Lerp (velocityY, 0, Time.deltaTime * smoothTime);
				
			}
//		} else if (CamAnim) {
//			float timeSinceStarted = Time.time - LerpTime;
//			float percentageComplete = timeSinceStarted / 1;
//			transform.rotation = Quaternion.Lerp (FromRot, ToRot, percentageComplete);
//			
//			//			print(percentageComplete);
//			
//			if (percentageComplete >= 1.0f) {
//				
//				if (stringTarget.Equals("biuro")) {
//					biuroEnv.SetActive(true);
//					mebelEnv.SetActive(false);
//					lampaEnv.SetActive(false);
//					designEnv.SetActive(false);
//					diamondEnv.SetActive(false);
//					krzesloEnv.SetActive(false);
//					SetNewOffset(0);
//					target = biuroTarget;
//				} else if (stringTarget == "mebel") {
//					mebelEnv.SetActive(true);
//					biuroEnv.SetActive(false);
//					lampaEnv.SetActive(false);
//					designEnv.SetActive(false);
//					diamondEnv.SetActive(false);
//					krzesloEnv.SetActive(false);
//					SetNewOffset(0);
//					target = mebelTarget;
//				} else if (stringTarget == "lampa") {
//					lampaEnv.SetActive(true);
//					biuroEnv.SetActive(false);
//					mebelEnv.SetActive(false);
//					designEnv.SetActive(false);
//					diamondEnv.SetActive(false);
//					krzesloEnv.SetActive(false);
//					SetNewOffset(0);
//					target = lampaTarget;
//				} else if (stringTarget == "design") {
//					designEnv.SetActive(true);
//					biuroEnv.SetActive(false);
//					mebelEnv.SetActive(false);
//					lampaEnv.SetActive(false);
//					diamondEnv.SetActive(false);
//					krzesloEnv.SetActive(false);
//					SetNewOffset(0);
//					target = designTarget;
//				} else if (stringTarget == "diamond") {
//					diamondEnv.SetActive(true);
//					biuroEnv.SetActive(false);
//					mebelEnv.SetActive(false);
//					lampaEnv.SetActive(false);
//					designEnv.SetActive(false);
//					krzesloEnv.SetActive(false);
//					SetNewOffset(0);
//					target = diamondTarget;
//				} else if (stringTarget == "krzeslo") {
//					krzesloEnv.SetActive(true);
//					diamondEnv.SetActive(false);
//					biuroEnv.SetActive(false);
//					mebelEnv.SetActive(false);
//					lampaEnv.SetActive(false);
//					designEnv.SetActive(false);
//					SetNewOffset(0);
//					target = krzesloTarget;
//				}
				
				//				print (stringTarget);
				//			
				//					}
				//					transform.rotation = FromRot;
				//					Vector3 negDistance = new Vector3 (1.0f, 1.0f, 1.0f);
				//					Vector3 position = transform.rotation * negDistance + target.position + targetOffset;
				//							
				//					transform.position = position;
				
//				Quaternion fromRotation = Quaternion.Euler (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
//				Quaternion toRotation = Quaternion.Euler (rotationXAxis, rotationYAxis, 0);
//				Quaternion rotation = toRotation;
//				
//				Vector3 negDistance = new Vector3 (0.0f, 0.0f, -distance);
//				Vector3 position = rotation * negDistance + target.position + targetOffset;
//				
//				transform.rotation = rotation;
//				transform.position = position;
//				
//				velocityX = Mathf.Lerp (velocityX, 0, Time.deltaTime * smoothTime);
//				velocityY = Mathf.Lerp (velocityY, 0, Time.deltaTime * smoothTime);
//				
//				
//				CamAnim = false;
////				Fade (true);
//				
//			}
			
		}
	}

	
//	public void PlayCamAnim(string newCameraTarget){
//		
//		LerpTime = Time.time;
//		FromRot = Quaternion.Euler (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
//		ToRot = Quaternion.Euler (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 90, 0);
//		stringTarget = newCameraTarget;
//		CamAnim = true;
////		Fade(false);
//	}
	
	
	public static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360F)
			angle += 360F;
		if (angle > 360F)
			angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}
}
