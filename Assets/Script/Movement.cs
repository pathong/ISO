using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float rotateSpeed;
    public float moveSpeed;


    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Debug.Log(x);

        transform.Rotate(0, rotateSpeed * x, 0);
        controller.Move(transform.forward * moveSpeed*y*Time.deltaTime);
        

        

    }

}
