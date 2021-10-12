using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner: MonoBehaviour
{
    public Transform myPrefab;

    public Transform imageTarget;
    //public float xAngle, yAngle, zAngle;

    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            var position = new Vector3(Random.Range(-50.0f, 50.0f), 0, Random.Range(-50.0f, 50.0f));
            Instantiate(myPrefab, position, Quaternion.Euler(270, 0, 0), imageTarget);
        }
    }

}
  
