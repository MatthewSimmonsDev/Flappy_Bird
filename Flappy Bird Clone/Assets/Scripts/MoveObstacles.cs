using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    public GameObject obstacle;
    [SerializeField]
    private int obstacleMoveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obstacle.transform.Translate(Vector2.left * Time.deltaTime * obstacleMoveSpeed);
    }
}
