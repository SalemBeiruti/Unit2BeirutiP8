using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCollisions : MonoBehaviour
{
    private PlayerStats statManager;
    // Start is called before the first frame update
    void Start()
    {
        statManager = GameObject.Find("StatManager").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            statManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            statManager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
