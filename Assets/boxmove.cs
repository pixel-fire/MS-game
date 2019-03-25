using UnityEngine;
using System.Collections;

public class boxmove : MonoBehaviour {
	// "Bobbing" animation from 1D Perlin noise.
	
	// Range over which height varies.
	float heightScale = 3.0f;
	int your_gift ; 
	public GameObject helth ; 
	public GameObject destoy ; 
	public GameObject somthing ; 
	
	// Distance covered per second along X axis of Perlin plane.
	float xScale = 1.2f;
	float pluse_scale ; 
	
	
	void Update()
	{
		pluse_scale = Random.Range(-1,1);
		float height = heightScale * Mathf.PerlinNoise(Time.time * xScale, 0.0f);
		Vector2 pos = transform.position;
		pos.y = - height  ;
		transform.position = pos;
		transform.position += transform.right * -0.1f ;
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		//		print(other.gameObject.name);
		if(other.gameObject.tag == "ball" )
		{
			points.point += 1  ;
			Destroy(gameObject , 0.05f ) ;
			Destroy(other.gameObject);
			box_luck() ; 
		}
	}

		void box_luck()
		{
			your_gift = 0 ; 
			if (your_gift == 0 )
			{
				//helth 
				GameObject he =  Instantiate(helth , transform.localPosition  , Quaternion.identity) as GameObject ; 
				Destroy(gameObject, 0.5f ) ; 
				Destroy(he , 0.5f ) ;
				points.lives = 5 ; 
			}
			if (your_gift == 1 )
			{
				Destroy(gameObject, 1f ) ;
			}
			if (your_gift == 2 )
			{
				Destroy(gameObject, 1f ) ;
			}


	}
}