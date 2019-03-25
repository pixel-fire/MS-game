using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {
	float inputx ; 
	float inputy ; 
	public int speed = 1 ; 
	public static float pos_y_of_bird ;
	public int garavity = 5 ; 
	public int power_of_jump = 10 ; 
	public static Vector2 bird_pos ; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		inputx = Input.GetAxis("Horizontal") ; 
		inputy = Input.GetAxis("Vertical") ;
		bird_pos = transform.position ;
//		print(pos_y_of_bird) ;
	   // mov = new Vector2 (inputx * speed  , inputy *speed * 15 ) ;
		bird_move () ; 


	}
	void FixedUpdate () 
	{


	}
	void bird_move ()
	{
		//transform.Translate (mov * Time.deltaTime ) ;
		if (transform.position.y > - 4 ) 
		{	
			if (Input.GetKeyDown("space"))
			{
				rigidbody2D.AddForce(transform.up * power_of_jump * 2 ) ;
				//rigidbody2D.velocity = Vector2.up * 10 ; 
			}
			rigidbody2D.isKinematic = false ; 
			rigidbody2D.AddForce(transform.up * -garavity  ) ;
		
			
		}
		if (transform.position.y < - 4  )
		{
			rigidbody2D.isKinematic = true   ;

		}
		if (transform.position.y < - 4  )
		{
			rigidbody2D.isKinematic = true   ;
		}
		if (transform.position.y > 4.0f )
		{
			rigidbody2D.velocity = Vector2.zero  ;
		}
		pos_y_of_bird = transform.position.y ;

	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		//print ("you hit somthing !" ) ;
	}

}
