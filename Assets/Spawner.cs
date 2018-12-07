using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {
    public GameObject LeftLimit;
    public GameObject RightLimit;

    public Text score;
    public int scoreInt;
    public static Spawner Instance;
    public bool itDead;

    public GameObject Asteroid;

    // Use this for initialization
    void Start () {
        itDead = false;
        scoreInt = 0;
        Instance = this;
       Invoke("SpawnComet", 1);

    }
	
	// Update is called once per frame
	void Update () {
	}

    void SpawnComet()
    {
        Vector3 pos = LeftLimit.transform.position;

        pos.x = Random.Range(
            LeftLimit.transform.position.x,
            RightLimit.transform.position.x);

        Instantiate(
            Asteroid,
            pos,
            Random.rotation);

        Invoke("SpawnComet", 1);
    }
}
