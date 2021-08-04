using UnityEngine;
using System.Collections;

public class DistanceCalc : MonoBehaviour {
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject L;
	public GameObject LF1;
	public GameObject LF2;
	public GameObject LS1;
	public GameObject LS2;
	public GameObject LS3;
	public GameObject LS4;
	public GameObject LS5;
	public GameObject GC;

	//public GameObject atomicbomb;
	// Use this for initialization
	void Start () {
		L.SetActive(false);
		LF1.SetActive(false);
		LF2.SetActive(false);
		LS1.SetActive(false);
		LS2.SetActive(false);
		LS3.SetActive(false);
		LS4.SetActive(false);
		LS5.SetActive(false);
		GC.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (sphere1.transform.position, sphere2.transform.position);

		if (distance > 11) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
		if (distance > 8) {
			Debug.Log ("Level 6");
			sphere1.SetActive(true);
			L.SetActive(false);
			LF1.SetActive(false);
			LF2.SetActive(false);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (6 <= distance && distance < 7) {
			Debug.Log ("Level 5");
			sphere1.SetActive(true);
			L.SetActive(true);
			LF1.SetActive(false);
			LF2.SetActive(false);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		if (5 <= distance && distance < 4) {
			Debug.Log ("Level 4");
			sphere1.SetActive(true);
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(false);
			LS1.SetActive(false);
			LS2.SetActive(false);
			LS3.SetActive(false);
			LS4.SetActive(false);
			LS5.SetActive(false);
			GC.SetActive(false);
		}
		//if (6 <= distance && distance < 9) {
		//	Debug.Log ("Level 3");
		//	L.SetActive(true);
		//	LF1.SetActive(true);
		//	LF2.SetActive(true);
		//	LS1.SetActive(false);
		//	LS2.SetActive(false);
		//	LS3.SetActive(false);
		//	LS4.SetActive(false);
		//	LS5.SetActive(false);
		//	GC.SetActive(false);
		//}
		//if (4.5 <= distance && distance < 7) {
		//	Debug.Log ("Level 2");
		//	L.SetActive(true);
		//	LF1.SetActive(true);
		//	LF2.SetActive(true);
		//	LS1.SetActive(true);
		//	LS2.SetActive(false);
		//	LS3.SetActive(false);
		//	LS4.SetActive(false);
		//	LS5.SetActive(false);
		//	GC.SetActive(false);
		//}
		//if ( 3.0 <= distance && distance < 5.5) {
		//	Debug.Log ("Level 1");
		//	L.SetActive(true);
		//	LF1.SetActive(true);
		//	LF2.SetActive(true);
		//	LS1.SetActive(true);
		//	LS2.SetActive(true);
		//	LS3.SetActive(false);
		//	LS4.SetActive(false);
		//	LS5.SetActive(false);
		//	GC.SetActive(false);
		//}
		if (3.0 < distance && distance < 5.0) {
			sphere1.SetActive(true);
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(true);
			LS2.SetActive(true);
			LS3.SetActive(true);
			LS4.SetActive(true);
			LS5.SetActive(true);
			GC.SetActive(false);

		} 
		if (4.9 > distance) {
			sphere1.SetActive(false);
			sphere2.SetActive(false);
			L.SetActive(true);
			LF1.SetActive(true);
			LF2.SetActive(true);
			LS1.SetActive(true);
			LS2.SetActive(true);
			LS3.SetActive(true);
			LS4.SetActive(true);
			LS5.SetActive(true);
			GC.SetActive(true);
				
		} 
		Debug.Log (distance);
	}
}
