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
    public GameObject metalSmall;
    public GameObject metalMedium;

    public void initWave(int pCurrentWave)
    {
        currentWave = pCurrentWave;
        Debug.Log("Current Wave " + currentWave);
        switch (pCurrentWave)
        {
            case 1:
                if (currentWave == 1)
                {
                    // metal (S,M) and glass (S)
                    // Material Metal = new Material(true, true, false);
                    // Material Glass = new Material(true, false, false);
                    Debug.Log("Current Wave " + currentWave);
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

            GameObject[] junkPieces = new GameObject[] { metalSmall, metalMedium };
            GameObject random = junkPieces[rnd.Next(0, junkPieces.Length)];
            GameObject junk = Instantiate(random) as GameObject;
            Debug.Log("Junk # " + junkCreated + " created at " + Time.time);
            junk.transform.position = new Vector3((float)-9.1, rnd.Next(-3, 3), 0);
            junk.transform.Translate(Vector3.right * Time.deltaTime);
            //junk.transform.localScale = new Vector3(4, 4, 4);
            junk.GetComponent<Rigidbody>().velocity = new Vector3((float)(rnd.NextDouble() * 2.5), 0, 0);
            junk.GetComponent<Rigidbody>().angularVelocity = new Vector3(rnd.Next(0, 5), rnd.Next(0, 5), rnd.Next(0, 5));
            junkCreated++;
        }

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(initRandomJunk(15, 5));
        initWave(1);
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
