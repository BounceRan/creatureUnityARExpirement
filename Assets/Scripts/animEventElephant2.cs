using UnityEngine;
using System.Collections;

public class animEventElephant : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void elephantEatingEnd() {
		//gameObject.GetComponentInChildren <Renderer> ().enabled = false;
		GameObject.FindWithTag ("elephantFood").GetComponent<Renderer> ().enabled = false;

		Debug.Log ("end -- elephant food gone");
		
		
	}

	void elephantSleepingEnd() {
		//gameObject.GetComponentInChildren <Renderer> ().enabled = false;
//		GameObject.FindWithTag ("elephantFood").GetComponent<Renderer> ().enabled = false;
//		
//		Debug.Log ("end -- elephant food gone");
		
		
	}
}	
