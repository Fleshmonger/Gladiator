using UnityEngine;
using System.Collections;

public abstract class Trap : MonoBehaviour
{
    public virtual void Activate() { }
    public virtual void EnterPath(Gladiator gladiator, GameObject path) { }
    public abstract GameObject GetPath(int pathIndex);
}
