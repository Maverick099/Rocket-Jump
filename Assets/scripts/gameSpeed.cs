using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSpeed : MonoBehaviour
{
    private int speed;
    private float gamespeed;
    private int scoreRemainder;
    // Start is called before the first frame update
    void Start()
    {
        gamespeed = Game_controller.Instance.ScrollSpeed;
        speed = Game_controller.Instance.Score;
    }

    // Update is called once per frame
    void Update()
    {
        GameSpeed(gamespeed);
    }
    private float GameSpeed(float scrollspeed)
    {
        if (speed > 0)
        {
            scoreRemainder = speed % 5;
            if (scoreRemainder == 0)
            {
                gamespeed = gamespeed * 100;
            }
        }
        return gamespeed;
    }
}
