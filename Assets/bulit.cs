using UnityEngine;
using System.Collections;

public class bulit : MonoBehaviour {


	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//transform.Rotate(starting_rot) ;
		rigidbody2D.velocity = transform.up * -10f ;

	}

}
