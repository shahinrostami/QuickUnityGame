using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public GameObject explosion;
	// Use this for initialization
	void Start () {
		
	}
	
    // Testing capture at 20 FPS . . . . . . . . 
    // Testing capture at 20 FPS . . . . . . . . 
    
	// Update is called once per frame
	void FixedUpdate () {
        transform.RotateAroundLocal(Vector3.one, 0.5f * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
	        GameManager.Instance.StopGame();
        }
        else
        {
	        GameManager.Instance.ScoreUp();
        }


	    if (!other.tag.Equals("Asteroid") && !other.tag.Equals("Star"))
	    {
		    	    
		    Instantiate(
			    explosion, 
			    transform.position, 
			    Quaternion.identity);
		    Destroy(gameObject);
	    }
    }
}
