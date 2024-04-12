using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float offsetX = 10;
    public float offsetY = 10;
    public float offsetZ = 10;


    void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(Camera.main.transform.position.x, -offsetX, offsetX),
            Mathf.Clamp(Camera.main.transform.position.y, -offsetY, offsetY),
            Mathf.Clamp(Camera.main.transform.position.z, -offsetZ, offsetZ));
    }
}
