using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    [SerializeField]
    public Vector3 offset;

    [SerializeField]
    public Vector3 offsetRot;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + Quaternion.Slerp(transform.rotation, target.transform.rotation, 100) * offset;
        transform.rotation = target.transform.rotation * Quaternion.Euler(offsetRot);
    }
}
