using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class Wave : MonoBehaviour
{
    bool completedWave;
    bool failedWave;
    public int currentWave;
    public int junkCount;
    public GameObject spaceJunk;

    public void initWave(int pCurrentWave)
    {
        switch (pCurrentWave)
        {
            case 1:
                if (currentWave == 1)
                {
                    // metal (S,M) and glass (S)
                    // Material Metal = new Material(true, true, false);
                    // Material Glass = new Material(true, false, false);
                    junkCount = 15;
                    string message = "";
                    StartCoroutine(initRandomJunk(junkCount, 5));
                }
                break;
            case 2:
                if (currentWave == 2)
                {
                    junkCount = 20;
                    string message = "";
                }
                break;
            case 3:
                if (currentWave == 3)
                {
                    junkCount = 30;
                    string message = "";
                }
                break;
            case 4:
                if (currentWave == 4)
                {
                    junkCount = 45;
                    string message = "";
                }
                break;
            case 5:
                if (currentWave == 5)
                {
                    junkCount = 60;
                    string message = "";
                }
                break;
            case 6:
                if (currentWave == 6)
                {
                    junkCount = 50;
                    string message = "";
                }
                break;
            case 7:
                if (currentWave == 7)
                {
                    junkCount = 100;
                    string message = "";
                }
                break;
            default:
                break;
        }
    }

    IEnumerator initRandomJunk(int pJunkCount, int pEndTimeInterval)
    {
        int junkCreated = 1;
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        var rnd = new System.Random();

        while (junkCreated <= pJunkCount){
            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(rnd.Next(1,pEndTimeInterval));
            Debug.Log("Junk # " + junkCreated + " created at " + Time.time);
            GameObject junk = Instantiate(spaceJunk) as GameObject;
            junk.transform.position = new Vector3(-9, rnd.Next(-3, 3), 0);
            junk.transform.Translate(Vector3.right * Time.deltaTime);
            junk.transform.localScale = new Vector3(4, 4, 4);
            junk.GetComponent<Rigidbody2D>().velocity = new Vector3(rnd.Next(1, 3), 0, 0);
            junk.GetComponent<Rigidbody2D>().angularVelocity = 100f;
            junkCreated++;
        }

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(initRandomJunk(15, 5));
        // initWave(1);
        // Debug.Log("Going to sleep");
        // initRandomJunk(5);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (completedWave)
        {
            currentWave++;
        }
        if (failedWave)
        {
            // show final message
        }

    }
}
