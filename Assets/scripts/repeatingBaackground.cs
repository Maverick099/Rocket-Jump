using UnityEngine;
using System.Collections;

public class repeatingBaackground : MonoBehaviour
{
    private BoxCollider2D ground;
    private float groundHorizontalLength;
    private void Awake()
    {
        ground = GetComponent<BoxCollider2D>();
        groundHorizontalLength = ground.size.x;
    }
    private void Update()
    {
        if (transform.position.x<-groundHorizontalLength)
        {
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}