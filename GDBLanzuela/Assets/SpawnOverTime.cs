using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOverTime : MonoBehaviour
{
    public float timer;
    float timerInit;
    public GameObject objecty;
    public int patientsInit;
    // Start is called before the first frame update
    void Start()
    {
        for (int i  = 0; i < patientsInit; i++)
        {
            Instantiate(objecty, transform.position, Quaternion.identity);
        }
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
