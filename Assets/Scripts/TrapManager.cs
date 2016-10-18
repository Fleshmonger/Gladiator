using UnityEngine;
using System.Collections;

public class TrapManager : MonoBehaviour
{
    public static TrapManager _instance;

    public Trap[] traps;

    public void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Trap GetTrap(int trapIndex)
    {
        if (trapIndex < traps.Length)
        {
            return traps[trapIndex];
        }
        else
        {
            return null;
        }
    }

    public GameObject GetPath(Trap trap, int pathIndex)
    {
        if (trap != null)
        {
            return trap.GetPath(pathIndex);
        }
        else
        {
            return null;
        }
    }

    public GameObject GetPath(int trapIndex, int pathIndex)
    {
        return GetPath(GetTrap(trapIndex), pathIndex);
    }
}