using UnityEngine;
using System.Collections;

public class WebcamInput : MonoBehaviour 
{	
	private float _screenHeight;
	private float _screenWidth;

	void Start () 
	{
		//scales the plane to the size of the screen.
		_screenHeight = Camera.main.orthographicSize / 5;
		_screenWidth = _screenHeight / Screen.height * Screen.width;
		transform.localScale = new Vector3 (_screenWidth,1,_screenHeight);
		 
		//displays the feed from the webcam upon the plane.
		WebCamTexture _webcam = new WebCamTexture ();
		Renderer renderer = GetComponent<Renderer> ();
		renderer.material.mainTexture = _webcam;
		_webcam.Play ();
	}

	void Update () 
	{
	
	}
}
