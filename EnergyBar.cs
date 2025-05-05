//The code for the energybar the player had. The idea was, that as the player could have an energy system as the player character was 
//a robot and the energybar could be used to build more tension to move forward.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public static EnergyBar instance;
    public Slider timerSlider;
    public float maxTime = 60f;
    public float timePerCollectible = 10f;

    private float currentTime;

    void Start()
    {
        currentTime = maxTime;
        UpdateSlider();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            //As time went forward the energy kept being reduzed from the slider. 
            currentTime -= Time.deltaTime;
            UpdateSlider();
        }
        else
        {
            SceneManager.LoadScene("Lose Screen");
        }
    }

    //EnergyBall collectibles were used to add time to the slider.
    public void CollectibleCollected()
    {
        currentTime += timePerCollectible;
        if (currentTime > maxTime)
            currentTime = maxTime;

        UpdateSlider();
    }

    void UpdateSlider()
    {
        timerSlider.value = currentTime / maxTime;
    }
}
