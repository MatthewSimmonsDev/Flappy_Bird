using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObstacles : MonoBehaviour
{
    public GameObject obstacle;
    private float randomStart;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1, Random.Range(0.5f, 3f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObstacle()
    {
        Instantiate(obstacle, new Vector2(10f, RandomSpawn()), Quaternion.identity);
    }

     float RandomSpawn()
    {
        randomStart = Random.value > .5f ? Random.Range(1.5f, 5.5f) : Random.Range(-1.5f, -5.5f);
        return randomStart;
    }

  
}
