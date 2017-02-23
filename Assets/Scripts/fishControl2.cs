using UnityEngine;
using System.Collections;

public class fishControl2 : MonoBehaviour {
	public float trans1left= 0f;
	public float trans2up= 0f; //controls various transitions
	public float MoveSpeed = 15;   
//	public Vector2 Target = GameObject.FindGameObjectWithTag("fishFood").transform.position;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		float minMoveDistance = 1f;

		if (GameObject.FindWithTag ("fishFood").GetComponent<Renderer> ().enabled == true) {
			GameObject other = GameObject.FindGameObjectWithTag("fishFood");

			if (other) {

			gameObject.GetComponent<Animator>().SetLayerWeight(1,1);
			transform.LookAt(GameObject.FindGameObjectWithTag("fishFood").transform);

			Vector3 newPos = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("fishFood").transform.position, MoveSpeed * Time.deltaTime);
			transform.Translate(newPos-transform.position);
//			transform.position = Vector3.MoveTowards(transform.position, Target, MoveSpeed * Time.deltaTime);


//			if (transform.position == Target)
//				OnReachTarget();
			}
			
		} 


		if (GameObject.FindWithTag ("water").GetComponent<Renderer> ().enabled == true) {
			GameObject other = GameObject.FindGameObjectWithTag("water");
			Vector3 pos1 = GameObject.FindGameObjectWithTag("water").transform.position;

			if (other) {

			if (Vector3.Distance(pos1,transform.position) > minMoveDistance) {
				
				gameObject.GetComponent<Animator>().SetLayerWeight(1,1);

				transform.LookAt(GameObject.FindGameObjectWithTag("water").transform);
				
				Vector3 newPos = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("water").transform.position, MoveSpeed * Time.deltaTime);
				transform.Translate(newPos-transform.position);
				//			transform.position = Vector3.MoveTowards(transform.position, Target, MoveSpeed * Time.deltaTime);
				
				
				//			if (transform.position == Target)
				//				OnReachTarget();
			}
			}
			
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

		if (other.gameObject.tag == "fishFood") {
			Animator ani = gameObject.GetComponent<Animator> ();
			ani.SetTrigger("fishFoodTrigger");
			//ani.GetCurrentAnimationClipState().
			Debug.Log ("Eat Fish Food");
		}

		if (other.gameObject.tag == "water") {
			Animator ani = gameObject.GetComponent<Animator> ();
//			gameObject.GetComponent<Animator>().SetLayerWeight(2,1);
			ani.SetTrigger("fishWaterTrigger");
			//ani.GetCurrentAnimationClipState().
			Debug.Log ("Fish Struggle");
		}
		
		//			Animator animator = gameObject.GetComponent<Animator>();
		//			ani.SetFloat ();
	}
}
