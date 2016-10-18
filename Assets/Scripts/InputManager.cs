using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Trap trap = hit.collider.GetComponentInParent<Trap>();
                if (trap != null)
                {
                    trap.Activate();
                }
            }
        }
    }
}