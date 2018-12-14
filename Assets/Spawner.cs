using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {
    public GameObject LeftLimit;
    public GameObject RightLimit;



    public static Spawner Instance;


    public GameObject Asteroid;
    public GameObject Star;

    // Use this for initialization
    void Start () {
        Instance = this;
       Invoke("SpawnObject", 1);

    }
	
	// Update is called once per frame
	void Update () {
	}

    void SpawnObject()
    {
        if (!GameManager.Instance.PlayerDead)
        {
            Vector3 pos = LeftLimit.transform.position;

            pos.x = Random.Range(
                LeftLimit.transform.position.x,
                RightLimit.transform.position.x);

            GameObject toSpawn = Asteroid;
            Quaternion rotation = Random.rotation;
            
            if (Random.Range(0, 4) == 3)
            {
                toSpawn = Star;
                rotation = Quaternion.identity;

            }
            else
            {
                toSpawn.GetComponent<Rigidbody>().drag = Random.Range(0f,4f);
            }
            
            Instantiate(
                toSpawn,
                pos,
                rotation);
        }

        Invoke("SpawnObject", 1);
    }
}
