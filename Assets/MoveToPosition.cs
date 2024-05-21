using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        Vector3 move = Input.mousePosition + offset;
        move.z = 10;
        transform.position = move;
    }
}
