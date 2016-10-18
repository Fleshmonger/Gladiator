using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pitfall : Trap
{
    private bool primed = true;
    private float rechargeTimer = 0f;
    private List<Gladiator> visitors = new List<Gladiator>();

    public float rechargeDelay = 1f;
    public GameObject entry, exit, plate;

    public override void EnterPath(Gladiator gladiator, GameObject path)
    {
        if (path.Equals(entry))
        {
            visitors.Add(gladiator);
        }
        else if (path.Equals(exit))
        {
            visitors.Remove(gladiator);
        }
    }

    public override GameObject GetPath(int pathIndex)
    {
        if (pathIndex == 0)
        {
            return entry;
        }
        else if (pathIndex == 1)
        {
            return exit;
        }
        else
        {
            return null;
        }
    }

    public void Update()
    {
        rechargeTimer -= Time.deltaTime;
        if (rechargeTimer <= 0f)
        {
            plate.SetActive(true);
            primed = true;
        }
    }

    public override void Activate()
    {
        if (primed)
        {
            plate.SetActive(false);
            foreach (Gladiator gladiator in visitors)
            {
                gladiator.Kill();
            }
            visitors.Clear();
            rechargeTimer = rechargeDelay;
            primed = false;
        }
    }
}
