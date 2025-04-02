using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;
    private int currentFedAmount = 0;
    private PlayerStats statManager;
    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        statManager = GameObject.Find("StatManager").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        if (currentFedAmount >= amountToBeFed)
        {
            statManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
