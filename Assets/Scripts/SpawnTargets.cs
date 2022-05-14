using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawningTargets());
    }

    IEnumerator StartSpawningTargets()
    {
        yield return new WaitForSeconds(2);

        Instantiate(target, new Vector3(Random.Range(-8.0f, 8.0f), -2.0f, Random.Range(-8.0f, 8.0f)), Quaternion.identity);
        StartCoroutine(StartSpawningTargets());
    }
}
