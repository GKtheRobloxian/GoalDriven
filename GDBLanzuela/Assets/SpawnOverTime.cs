using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOverTime : MonoBehaviour
{
    public float timer;
    float timerInit;
    public GameObject objecty;
    // Start is called before the first frame update
    void Start()
    {
        timerInit = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(objecty, transform.position, Quaternion.identity);
            timer = timerInit;
        }
    }
}
