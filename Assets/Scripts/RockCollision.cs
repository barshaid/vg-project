using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Color myColor = new Color(255, 0, 0);
    
        if (col.gameObject.name == "Player" && col.transform.GetComponent<Movement>().heldItem == 1 && Input.GetMouseButton(0))
        {
            Destroy(gameObject);
            if (gameObject.GetComponent<Renderer>().material.color == Color.white)
            {
                GameObject[] rocks = GameObject.FindGameObjectsWithTag("door");
                foreach (GameObject rock in rocks)
                    GameObject.Destroy(rock);
            }
        }
    }
}
