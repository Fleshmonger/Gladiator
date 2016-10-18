using UnityEngine;
using System.Collections;

public class Gladiator : MonoBehaviour
{
    private int trapIndex = 0, pathIndex = 0;
    private Trap trap = null;
    private GameObject path = null;

    public float speed = 5f;

    public void Start()
    {
        SetPath();
    }

    public void Update()
    {
        Move(speed * Time.deltaTime);
    }

    private void SetPath()
    {
        trap = TrapManager._instance.GetTrap(trapIndex);
        if (trap != null)
        {
            GameObject nextPath = trap.GetPath(pathIndex);
            if (nextPath != null)
            {
                path = nextPath;
            }
            else
            {
                trapIndex++;
                pathIndex = 0;
                SetPath();
            }
        }
        else
        {
            path = null;
        }
    }

    public void Move(float distance)
    {
        if (path != null)
        {
            Vector3 direction = path.transform.position - transform.position;
            if (direction.magnitude < distance)
            {
                if (trap != null)
                {
                    trap.EnterPath(this, path);
                }
                transform.position = path.transform.position;
                pathIndex++;
                SetPath();
                Move(distance - direction.magnitude);
            }
            else
            {
                transform.Translate(direction.normalized * distance);
            }
        }
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}
