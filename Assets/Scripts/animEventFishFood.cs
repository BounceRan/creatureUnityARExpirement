using UnityEngine;
using System.Collections;

public class animEventFishFood : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void fishEatingEnd() {
		//gameObject.GetComponentInChildren <Renderer> ().enabled = false;
		GameObject.FindWithTag ("fishFood").GetComponent<Renderer> ().enabled = false;

		Debug.Log ("end -- fish food gone");
		
		
	}
}	
