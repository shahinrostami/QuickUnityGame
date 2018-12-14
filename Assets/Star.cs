using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {
	public GameObject sparkle;
	// Use this for initialization
	void Start () {
		
	}
	
	Vector3 rotVec = new Vector3(0,1,0);
	// Testing capture at 20 FPS . . . . . . . . 
	// Testing capture at 20 FPS . . . . . . . . 
    
	// Update is called once per frame
	void FixedUpdate () {
		transform.RotateAroundLocal(rotVec, 2f * Time.deltaTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Player"))
		{
			GameManager.Instance.ScoreUp();
			GameManager.Instance.ScoreUp();
			GameManager.Instance.ScoreUp();
			GameManager.Instance.ScoreUp();
			GameManager.Instance.ScoreUp();
		}


		if (!other.tag.Equals("Asteroid") && !other.tag.Equals("Star"))
		{
			
			Instantiate(
				sparkle, 
				transform.position, 
				Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
