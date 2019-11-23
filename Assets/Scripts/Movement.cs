using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//To be changed to Player Control
public class Movement : MonoBehaviour
{
    public float speed = 6.0f;
    public float turnSpeed = 180f;
    private Vector3 moveDirection = Vector3.zero;
    public int heldItem = 0;

   
    void Update()
    {
        //GetComponent<Animation>().Play();

        if (Input.GetMouseButton(0) && heldItem==1) {
            GameObject.Find("Pickaxe").GetComponent<Animation>().Play("pickaxe");
        }
        else
        {
            GetComponent<Animation>().Stop("pickaxe");
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)||
            Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ||
            Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            GetComponent<Animation>().Play("Movement");
        }
        else
        {
            GetComponent<Animation>().Stop("Movement");
        }
        

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) )
        {
            transform.position += Vector3.left * speed * Time.deltaTime;           
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position -= Vector3.forward * speed * Time.deltaTime; 
        }

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(moveDirection), turnSpeed * Time.deltaTime);
    }


}
