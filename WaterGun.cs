//The watergun code. This was pretty simple with only spawning the bullet when needed.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject dropletPrefab;
    [SerializeField] AudioSource watersound;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Bullet gets spawned
            Instantiate(dropletPrefab, shootingPoint.position, transform.rotation);
            watersound.Play();
        }
    }
}
