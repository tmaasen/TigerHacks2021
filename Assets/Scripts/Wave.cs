using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

public class Wave : MonoBehaviour
{
    public bool completedWave;
    public bool failedWave;
    public int currentWave;
    public int junkCount;
    public int junkCreated;
    public int orbitClutter;
    public int junkCollected;
    public GameObject metalSmall;
    public GameObject metalMedium;
    public GameObject Broken_Sattelite;
    public GameObject metalAndGlass;
    public GameObject rocket;
    public GameObject recorder;
    public GameObject box;
    public GameObject panera;
    public GameObject holybeam;

    private int[] junkCountPerLevel = new int[] {0, 10, 20, 25, 30, 40, 55, 75, 1000};

    public void initWave(int pCurrentWave)
    {
        currentWave = pCurrentWave;
        junkCollected = 0;
        completedWave = false;
        switch (pCurrentWave)
        {
            case 1:
                if (currentWave == 1)
                {
                    junkCount = 10;
                    string l1GTmessage = "Using resources from junk to upgrade your drone and build rooms is crucial to success.";
                    string l1SFmessage = "Force of impact isn't the only danger junk poses to spacecraft. Small impacts can cause releases of plasma that badly damage electrical panels.";
                    StartCoroutine(initRandomJunk(junkCount, 3));
                }
                break;
            case 2:
                if (currentWave == 2)
                {
                    junkCount = 20;
                    string l2GTmessage = "Watch out for junk approaching your space station! Sensor rooms give you advance warning, or build shields to save you from needing to stop it yourself.";
                    string l2SFmessage = "The first major satellite collision occured on Feb 10, 2009 between 2000lb Kosmos and 1233lb Iridium 33. Speed of impact was ~28,290 mph, with both satellites completely destroying one another, creating thousands of tiny destructive pieces of junk.";
                    StartCoroutine(initRandomJunk(junkCount, 3));
                }
                break;
            case 3:
                if (currentWave == 3)
                {
                    junkCount = 25;
                    string l3GTmessage = "Don't skip out on deploying magnets to attract various bits of metal. Once they've gathered enough you can grab the magnet and bring it back to base for a big payoff.";
                    string l3SFmessage = "An unresolved space junk problem could completely destroy everyday systems such as the internet, navigation, weather tracking, and any sort of satellite imagery.";
                    StartCoroutine(initRandomJunk(junkCount, 4));
                }
                break;
            case 4:
                if (currentWave == 4)
                {
                    junkCount = 30;
                    string l4GTmessage = "Any junk you let cross the screen will return three-fold in the next level. Keep on top of things unless you want to get overwhelmed.";
                    string l4SFmessage = "The problem of space clutter is exponential, as any pieces that collide create even more shards of metal and glass, which go on to collide with more and more like a shotgun blast.";
                    StartCoroutine(initRandomJunk(junkCount, 4));
                }
                break;
            case 5:
                if (currentWave == 5)
                {
                    junkCount = 40;
                    string l5GTmessage = "Lasers are powerful, ranged drones that quickly melt junk but won't collect any resources (except from asteroids).";
                    string l5SFmessage = "The worst space junk disaster to date was in 2007, when the Chinese government destroyed a weather satellite during an anti-satellite military test, creating more than 20% of all space debris.";
                    StartCoroutine(initRandomJunk(junkCount, 5));
                }
                break;
            case 6:
                if (currentWave == 6)
                {
                    junkCount = 55;
                    string l6GTmessage = "Find any Unobatnium? Use it to create special drones and buildings to give you an edge in this final level.";
                    string l6SFmessage = "A partial solution some companies have begun using is a satellite 'graveyard', where defunct satellites are moved 200 miles further into orbit and out of the danger zone.";
                    StartCoroutine(initRandomJunk(junkCount, 3));
                }
                break;
            case 7:
                if (currentWave == 7)
                {
                    junkCount = 75;
                    string l7GTmessage = "Congrats! That was the final challenge we had for you. You're a real space hero.";
                    string l7SFmessage = "The ISS has needed to perform 25 avoidance manuvers since 1999 (data from 2016) in order to avoid significant damage from space junk.";
                    StartCoroutine(initRandomJunk(junkCount, 2));
                }
                break;
            case 8:
                if (currentWave == 8)
                {
                    junkCount = 1000;
                    var rnd = new System.Random();
                    StartCoroutine(initRandomJunk(junkCount, 1));
                    GameObject[] junkPieces = new GameObject[] { metalSmall, metalSmall, metalSmall, metalMedium, Broken_Sattelite, metalAndGlass, rocket, recorder, box, recorder, metalSmall, rocket, box, panera, holybeam, holybeam };
                    GameObject random = junkPieces[rnd.Next(0, junkPieces.Length)];
                    GameObject junk = Instantiate(random) as GameObject;
                    junk.GetComponent<Rigidbody>().velocity = new Vector3((float)(rnd.NextDouble() + 4 * 6), 0, 0);
                }
                break;
                default:
                break;
        }
    }

    IEnumerator initRandomJunk(int pJunkCount, int pEndTimeInterval)
    {
        junkCreated = 1;
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        var rnd = new System.Random();

        while (junkCreated <= pJunkCount){
            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(rnd.Next(1,pEndTimeInterval));

            GameObject[] junkPieces = new GameObject[] { metalSmall, metalSmall, metalSmall, metalMedium, Broken_Sattelite, metalAndGlass, rocket, recorder, box, recorder, metalSmall, rocket, box, panera, holybeam, holybeam };
            GameObject random = junkPieces[rnd.Next(0, junkPieces.Length)];
            GameObject junk = Instantiate(random) as GameObject;
            Debug.Log("Junk # " + junkCreated + " created at " + Time.time);
            junk.transform.position = new Vector3((float)-9.1, rnd.Next(-3, 3), 0);
            junk.transform.Translate(Vector3.right * Time.deltaTime);
            //junk.transform.localScale = new Vector3(4, 4, 4);
            junk.GetComponent<Rigidbody>().velocity = new Vector3((float)(rnd.NextDouble() + 1 * 4), 0, 0);
            junk.GetComponent<Rigidbody>().angularVelocity = new Vector3(rnd.Next(0, 5), rnd.Next(0, 5), rnd.Next(0, 5));
            junkCreated++;
        }

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    // Start is called before the first frame update
    void Start()
    {
        initWave(1);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Junk: " + junkCollected);

        Text TextBox1 = GameObject.Find("Level").GetComponent<Text>();
        TextBox1.text = "Wave "+ currentWave.ToString();

        Text TextBox2 = GameObject.Find("Counter").GetComponent<Text>();
        TextBox2.text = "Junk Collected: "+ junkCollected.ToString() + " / " + junkCountPerLevel[currentWave];

        Text TextBox3 = GameObject.Find("LostJunk").GetComponent<Text>();
        TextBox3.text = "Junk Lost: "+ GameObject.Find("Drone").GetComponent<collectJunk>().orbitClutter;
        
        if (GameObject.Find("Drone").GetComponent<collectJunk>().orbitClutter == 25) {
            Time.timeScale = 0;
            Application.LoadLevel("GameOver");
            // pause game
            // show game over screen with button to go back to main menu        
        }

    }
}
