using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum_pool : MonoBehaviour 
{
	private GameObject[] columns;
	public int ColumnPoolSize = 5;
	public GameObject columnPrefab;
	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
	private float timesincelastspawn;
	public float spawnrate = 4f;
	public float columnMin = -1f;
	public float columnMax = 3.5f;
	private float Xposition = 10f;
	private int currentColumn = 0;
	// Use this for initialization
	void Start () 
	{
		timesincelastspawn = 0f;
		columns = new GameObject[ColumnPoolSize];
		for (int i = 0; i < ColumnPoolSize; i++) 
		{
			columns [i] = (GameObject)Instantiate (columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		timesincelastspawn += Time.deltaTime;
		if (Game_controller.Instance.gameOver == false && timesincelastspawn>=spawnrate)
		{
			timesincelastspawn = 0f;
			float spawnYposition = Random.Range (columnMin, columnMax);
			columns [currentColumn].transform.position = new Vector2 (Xposition, spawnYposition);
			currentColumn++;
			if (currentColumn >= ColumnPoolSize)
			{
				currentColumn = 0;
			}
			
		}
	}
}
