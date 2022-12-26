using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 offset;
    public Transform target;


    private void Start()
    {
        offset = transform.position - target.position;
    }


    private void Update()
    {
        transform.position = target.position + offset;
    }



}
