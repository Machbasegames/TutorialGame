using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject shitPrefab;

    public float autoGeneratorCycleSeconds = 1f;

    Coroutine autoGeneratorShitCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        autoGeneratorShitCoroutine = StartCoroutine(AutoGeneratorShit());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator AutoGeneratorShit()
    {
        while(true)
        {
            GameObject newShit = GameObject.Instantiate<GameObject>(shitPrefab);

            newShit.transform.position = new Vector3(Random.Range(-4f, 4f), transform.position.y, 0f);
            newShit.transform.parent = transform;

            yield return new WaitForSeconds(autoGeneratorCycleSeconds);
        }
    }
}
