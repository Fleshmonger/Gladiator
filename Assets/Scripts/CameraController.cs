using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
        }
        transform.Translate(direction * Time.deltaTime * moveSpeed);
    }
}
