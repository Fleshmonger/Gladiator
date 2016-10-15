using UnityEngine;
using System.Collections;

public class GladiatorSpawner : MonoBehaviour
{
    private float timer = 0f;

    public int gladiators = 10;
    public float delay = 4f;
    public Gladiator gladiatorPrefab;

    public void Update()
    {
        if (gladiators > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                SpawnGladiator(gladiatorPrefab);
                gladiators--;
                timer += delay;
            }
        }
    }

    public void SpawnGladiator(Gladiator gladiatorPrefab)
    {
        Instantiate(gladiatorPrefab, transform.position, transform.rotation);
    }
}
