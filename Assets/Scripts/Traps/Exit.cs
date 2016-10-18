using UnityEngine;
using System.Collections;

public class Exit : Trap
{
    public GameObject path;

    public override void EnterPath(Gladiator gladiator, GameObject path)
    {
        if (path.Equals(path))
        {
            gladiator.Kill();
        }
    }

    public override GameObject GetPath(int pathIndex)
    {
        if (pathIndex == 0)
        {
            return path;
        }
        else
        {
            return null;
        }
    }
}
