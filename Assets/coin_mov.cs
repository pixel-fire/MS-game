using UnityEngine;
using System.Collections;

public class coin_mov : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = transform.right * -speed_of_movment.speed ;
	
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		//		print(other.gameObject.name);
		if(other.gameObject.tag == "hero" )
		{

			Destroy(gameObject) ;
		}
	}
}
