//The Energyballs you could collect to increare your energybar.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBallz : MonoBehaviour
{

    [SerializeField] private AudioSource collectSound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Makes sure it was player who touched the object.
        if (other.gameObject.CompareTag("Player"))
        {
            collectSound.Play();

            EnergyBar energyBar = FindObjectOfType<EnergyBar>();
            EnergyBar timer = energyBar;

            if (timer != null)
            {
                //Timer increased.
                timer.CollectibleCollected();
            }

            Destroy(gameObject);
        }
    }
}
