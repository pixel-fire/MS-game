using UnityEngine;
using System.Collections;

public class enmy : MonoBehaviour {
	 float speed_of_move ; 
     float Timer = 2;
	 float timer_speed  ;
	 public GameObject prefab ; 



	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		timer_speed = Random.Range(0.2f ,2f );
		speed_of_move = Random.Range(0.5f ,5f);
		transform.position = Vector2.MoveTowards(transform.localPosition , new Vector2(0  ,bird.pos_y_of_bird  )   , speed_of_move * Time.deltaTime ) ;
		Timer -= 1 * Time.deltaTime * timer_speed ;
		if (Timer <= 0) 
		{
		 Instantiate(prefab , transform.localPosition ,Quaternion.identity) ; 

			
			Timer = 2;	
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		//		print(other.gameObject.name);
		if(other.gameObject.tag == "ball" )
		{
			Destroy(other.gameObject);
			Destroy(gameObject) ;
		}

}
}