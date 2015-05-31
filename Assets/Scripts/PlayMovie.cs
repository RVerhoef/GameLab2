using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour 
{
	private float _screenHeight;
	private float _screenWidth;
	[SerializeField] private MovieTexture _movieTexture;

	void Start () 
	{
		//scales the plane to the size of the screen.
		_screenHeight = Camera.main.orthographicSize / 5;
		_screenWidth = _screenHeight / Screen.height * Screen.width;
		transform.localScale = new Vector3 (_screenWidth,1,_screenHeight);

		//play the intro movie on the plane.
		GetComponent<Renderer>().material.mainTexture = _movieTexture;
		_movieTexture.Play();
	}

	void Update ()
	{
		if (_movieTexture.isPlaying == false) 
		{
			Destroy(gameObject);
		}
	}	
}
 