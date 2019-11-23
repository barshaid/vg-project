using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeball : gameover
{
    public float speed = 0.5f;
    public GameObject goUI;
    public bool cat = false;
    void Start()
    {
        Vector3 v = new Vector3(speed, 0, speed);
        gameObject.transform.GetComponent<Rigidbody>().velocity = v;
        
        goUI = GameObject.Find("gameover");
        if (cat)
            goUI.SetActive(false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            goUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}