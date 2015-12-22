using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(ScrollRect))]
public class Scroller : MonoBehaviour
{
	[Tooltip("the container the screens or pages belong to")]
	public Transform ScreensContainer;
	[Tooltip("how many screens or pages are there within the content")]
	public int Screens = 1;
	[Tooltip("which screen or page to start on (starting at 1 for you designers)")]
	public int StartingScreen = 1;
	
	private List<Vector3> _positions;
	private ScrollRect _scroll_rect;
	private GraphicRaycaster _raycaster;
	private Button _button;
	private Vector3 _lerp_target;
	private bool _lerp;
	private Vector3 vec;
	private Vector3 NewLerpTaget;
	static bool Scrolled;
	
	// Use this for initialization
	void Start()
	{
		_scroll_rect = gameObject.GetComponent<ScrollRect>();
		_raycaster = gameObject.GetComponent<GraphicRaycaster> ();
		_button = gameObject.GetComponent<Button> ();
		_scroll_rect.inertia = false;
		_lerp = false;
		
		_positions = new List<Vector3>();

		Debug.Log (Scrolled);

		if (Screens > 0) {
			for (int i = 0; i < Screens; ++i) {
				_scroll_rect.horizontalNormalizedPosition = (float)i / (float)(Screens - 1);
				_positions.Add (ScreensContainer.localPosition);
			}

		if (Scrolled == true) {
			DisableScrollbar();

		}
		}
		
		_scroll_rect.horizontalNormalizedPosition = (float)(StartingScreen - 1) / (float)(Screens - 1);
	}
	
	void Update()
	{
		if (Scrolled == false) {
//		
			if (_lerp) {
				ScreensContainer.localPosition = Vector3.Lerp (ScreensContainer.localPosition, _lerp_target, 5 * Time.deltaTime);
				if (ScreensContainer.localPosition.x < -799) {
					DisableScrollbar();
				
					Scrolled = true;
				}

				if (Vector3.Distance (ScreensContainer.localPosition, _lerp_target) < 0.01f) {
					_lerp = false;

				}
			}
		}
	}

	void DisableScrollbar(){
		vec = new Vector3 (-800, 0, 0);
		ScreensContainer.localPosition = vec;

		_scroll_rect.enabled = false;
		_raycaster.enabled = false;
		_button.enabled = false;
		transform.gameObject.SetActive (false);
	}

	public void DragEnd()
	{
			if (_scroll_rect.horizontal) {
				_lerp = true;

//			if(ScreensContainer.localPosition.x < 540){
//				NewLerpTaget = new Vector3 (0, 0, 0);
//			}
			_lerp_target = FindClosestFrom (ScreensContainer.localPosition, _positions);
			Debug.Log (ScreensContainer.localPosition);
			}
	}
	
	public void OnDrag()
	{
		_lerp = false;
	}
	
	Vector3 FindClosestFrom(Vector3 start, List<Vector3> positions)
	{
		Vector3 closest = Vector3.zero;
		float distance = Mathf.Infinity;
		Vector3 dummy = new Vector3 (400,0,0);
		
		foreach (Vector3 position in _positions)
		{
			if (Vector3.Distance(start, position) < distance)
			{
				distance = Vector3.Distance(start, position + dummy);                
				closest = position;
			}
		}
		
		return closest;
	}
}