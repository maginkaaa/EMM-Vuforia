using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    private float angle = 0;
    /* private float jumpHeight = 1.0f;
     private float gravityValue = -9.81f; */

   

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        angle += moveHorizontal * 0.05f;

        //Moving to the direction the player is looking
        Vector3 moveDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));

        transform.position += moveDirection * Time.deltaTime * playerSpeed * moveVertical;
        transform.rotation = Quaternion.LookRotation(moveDirection);
    }
}