using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Game_controller : MonoBehaviour 
{
	public GameObject gameOverText;
	public bool gameOver=false;
	public static Game_controller Instance;
	public float ScrollSpeed = -2.5f;
	public int Score=0;
	public Text ScoreText;
	private int ScoreSpeed;
    private int remainder;
	// Use this for initialization
	void Awake () 							//called before start
	{
		if (Instance == null) 
		{
			Instance = this;
		} 
		else if (Instance != this) 
		{
			Destroy (gameObject);
		}
	}

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (gameOver==true && ArdunioController.Input.Data=="high")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if ( Score> 0)
        {
            remainder = Score % 5;
            if (remainder == 0)
            {
                ScrollSpeed = ScrollSpeed * 100;
            }
        }
    }
    public void birdDead()
	{
		gameOverText.SetActive (true);
		gameOver=true;
	}
	public void BirdScored()
	{
		if (gameOver) 
		{
			return;
		}
		Score++;
		ScoreText.text = "Score:" + Score.ToString ();
	}
	
}

