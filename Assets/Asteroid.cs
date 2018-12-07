using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    public GameObject explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.RotateAroundLocal(Vector3.one, 0.5f * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Spawner.Instance.itDead = true;
            Destroy(other.gameObject);
        }
        else
        {
            if (!Spawner.Instance.itDead)
            {
                Spawner.Instance.scoreInt++;
                Spawner.Instance.score.text =
                    Spawner.Instance.scoreInt.ToString();
            }
        }
        Instantiate(
            explosion, 
            transform.position, 
            Quaternion.identity);

        Destroy(gameObject);
    }
}
