using UnityEngine;
using System.Collections;

public class grassTrigger : MonoBehaviour {
	public float trans1left= 0f;
	public float trans2up= 0f; //controls various transitions
	public float MoveSpeed = 5;   
//	public Vector2 Target = GameObject.FindGameObjectWithTag("fishFood").transform.position;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void 	OnReachTarget(){

	}

	void OnCollisionEnter(Collision col){

//		if (col.gameObject.name == "food") {
//			Animator ani = gameObject.GetComponent<Animator> ();
//			ani.SetTrigger("foodTrigger");
//			//ani.GetCurrentAnimationClipState().
//			Debug.Log ("Eat Food");
//		}
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Object Entered the trigger " + other.gameObject.name + " " + other.gameObject.tag );

		if (other.gameObject.tag == "elephant") {
			Animator ele = gameObject.GetComponent<Animator> ();
			ele.SetTrigger("elephantGrassTrigger");
			//ani.GetCurrentAnimationClipState().
			Debug.Log ("Elephant Rests");
		}

		//			Animator animator = gameObject.GetComponent<Animator>();
		//			ani.SetFloat ();
	}
	
}
