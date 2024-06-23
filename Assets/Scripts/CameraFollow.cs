using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;
    
    void FixedUpdate()
    {
        transform.position = objectToFollow.transform.position - (Vector3.forward * 10) + (Vector3.up * 5);
    }
}
