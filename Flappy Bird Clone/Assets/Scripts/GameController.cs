using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text text;
    private int points = 1;
    private float timer = 0f;
    private float delayTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= delayTime)
        {
            timer = 0f;

            points++;
        }

        text.text = "Points: " + points.ToString();
    }
}
