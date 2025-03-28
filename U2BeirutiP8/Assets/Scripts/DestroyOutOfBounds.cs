using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;
    private PlayerStats statManager;
    // Start is called before the first frame update
    void Start()
    {
        statManager = GameObject.Find("StatManager").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            statManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x > sideBound)
        {
            statManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x < -sideBound)
        {
            statManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
