using UnityEngine;
using System.Collections;

public class Gladiator : MonoBehaviour
{
    public float speed = 5f;

    public void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
