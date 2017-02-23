using UnityEngine;
using System.Collections;

public class elephantControl : MonoBehaviour {
	public float trans1left= 0f;
	public float trans2up= 0f; //controls various transitions
	public float MoveSpeed = 5;   
//	public Vector2 Target = GameObject.FindGameObjectWithTag("fishFood").transform.position;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.FindWithTag ("elephantFood").GetComponent<Renderer> ().enabled == true) {

			transform.LookAt(GameObject.FindGameObjectWithTag("elephantFood").transform);
			transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("elephantFood").transform.position, MoveSpeed * Time.deltaTime);

//			transform.position = Vector3.MoveTowards(transform.position, Target, MoveSpeed * Time.deltaTime);


//			if (transform.position == Target)
//				OnReachTarget();
			
		}
	

//		Animator ani = gameObject.GetComponent<Animator> ();
//
//		//left right
//		trans1left = Input.GetAxis ("Horizontal");
//			ani.SetFloat("horizontalControl",trans1left);
//
//		//up down
//		trans2up = Input.GetAxis ("Vertical");
//		ani.SetFloat ("verticalControl", trans2up);
	//	Debug.Log (trans2up);


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

		if (other.gameObject.tag == "elephantFood") {
			Animator ani = gameObject.GetComponent<Animator> ();
			ani.SetTrigger("elephantFoodTrigger");
			//ani.GetCurrentAnimationClipState().
			Debug.Log ("Eat Elephant Food");
		}

		//			Animator animator = gameObject.GetComponent<Animator>();
		//			ani.SetFloat ();
	}
}
