using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRotation : MonoBehaviour
{
    float speed = 200f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
