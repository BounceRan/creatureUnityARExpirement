using UnityEngine;
using System.Collections;

public class fishControl3 : MonoBehaviour {
	public float trans1left= 0f;
	public float trans2up= 0f; //controls various transitions
	public float MoveSpeed = 5;   
	//	public Vector2 Target = GameObject.FindGameObjectWithTag("fishFood").transform.position;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		float minMoveDistance = 1f;
		
		if (GameObject.FindWithTag ("fishFood").GetComponent<Renderer> ().enabled == true) {
			
			
			Vector3 pos1 = GameObject.FindGameObjectWithTag("fishFood").transform.position;
			
			if (Vector3.Distance(pos1,transform.position) > minMoveDistance) {
				GetComponent<Animator>().SetLayerWeight(1,1);
				transform.LookAt(GameObject.FindGameObjectWithTag("fishFood").transform);
				transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("elephantFood").transform.position, MoveSpeed * Time.deltaTime);
				
			}
			//			transform.position = Vector3.MoveTowards(transform.position, Target, MoveSpeed * Time.deltaTime);
			
			
			//			if (transform.position == Target)
			//				OnReachTarget();
			
		}
		
		if (GameObject.FindWithTag ("water").GetComponent<Renderer> ().enabled == true) {
			
			
			Vector3 pos2 = GameObject.FindGameObjectWithTag("water").transform.position;
			
			if (Vector3.Distance(pos2,transform.position) > minMoveDistance) {
				
				transform.LookAt(GameObject.FindGameObjectWithTag("water").transform);
				transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("grass").transform.position, MoveSpeed * Time.deltaTime);
				Debug.Log ("found" + gameObject.tag);
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
			Debug.Log ("Fish Swims");
			ani.SetTrigger("fishWaterTrigger");
			//ani.GetCurrentAnimationClipState().
			
		}
		
		//			Animator animator = gameObject.GetComponent<Animator>();
		//			ani.SetFloat ();
	}
	
}
