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
        yield return new WaitForSeconds(3);
        Instantiate(target, new Vector3(0.0f, -3.0f, 1.5f), Quaternion.identity);
        StartCoroutine(StartSpawningTargets());
    }
}
