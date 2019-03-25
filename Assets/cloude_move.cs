using UnityEngine;
using System.Collections;

public class cloude_move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right *Time.deltaTime * -2 ;
		if (transform.position.x < -40 )
		{
			Destroy(gameObject) ;
		}

	}
}
