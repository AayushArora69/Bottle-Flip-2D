using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public float YalueOfCam = -5f;
    public float ZalueOfCam = -10f;
    public Transform target;
    public float speed;


    void Update()
    {
        Vector3 targetPos = new Vector3(target.transform.position.x  , YalueOfCam, ZalueOfCam);
        transform.position = Vector3.Lerp(transform.position, targetPos, speed);
    }
}
