using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] float zAngle = 10f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, zAngle * Time.deltaTime, Space.Self);
    }
}
