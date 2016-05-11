﻿using UnityEngine;

public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 300);
    public Vector2 rightForce = new Vector2(300,0);
	
	// Update is called once per frame
	void Update ()
	{
		// Jump
		if (Input.GetKeyUp("space"))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}

        // fly right
	    if (Input.GetKeyUp("right"))
	    {
	        GetComponent<Rigidbody2D>().AddForce(rightForce);
	    }
		
		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			//Die();
		}
        // Die by being off screen left side
	    if (screenPosition.x < 0)
	    {
	        Die();
	    }
	}
	
	// Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		//Die();
	}
	
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}