using UnityEngine;
using System.Collections;

public class beakwall : mive {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movw_with_pip () ;

	}
	void movw_with_pip ()
	{

			rigidbody2D.velocity = transform.right * -speed_of_movment.speed ;
		//transform.position += transform.right *Time.deltaTime * -speed ;
		if (transform.position.x < -11 )
		{
			Destroy(gameObject) ;
		}

	}
	private void OnTriggerEnter2D(Collider2D other)
	{
//		print(other.gameObject.name);
		if(other.gameObject.tag == "ball" )
		{
			//points.point += 1  ;
			Destroy(gameObject , 0.05f ) ;
			Destroy(other.gameObject);
		}
	}
}
