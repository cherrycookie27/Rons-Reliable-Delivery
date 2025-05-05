//The code for the games watergun bullets. I struggled with making the bullet shoot from the right direction and keep it moving until it hit something, but I got it 
//done well enough in the end.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    public float speed = 10f;

    private bool isFacingRight = true;

    void Update()
    {
        // Move the bullet in the appropriate direction
        if (isFacingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    //Function to set the direction the player is facing. I would nowdays do this a bit better, 
    //removing the unnecessary bool from it, but this was the best I was able to do as a beginner with a time limit.
    public void SetFacingDirection(bool facingRight)
    {
        isFacingRight = facingRight;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Map"))
        {
            Destroy(gameObject);
        }
    }
}
