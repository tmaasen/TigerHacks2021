using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectJunk : MonoBehaviour
{

    public GameObject waveDirector;
    public int orbitClutter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Junk") {
            waveDirector.GetComponent<Wave>().junkCollected++;
            // Debug.Log("Incremented Junk Collected: " + waveDirector.GetComponent<Wave>().junkCollected);
            // Debug.Log("Current Level: " + waveDirector.GetComponent<Wave>().currentWave);
            // Debug.Log("junkCreated: " + waveDirector.GetComponent<Wave>().junkCreated);
            // Debug.Log("junkCount: " + waveDirector.GetComponent<Wave>().junkCount);
        }
        if (waveDirector.GetComponent<Wave>().junkCreated >= waveDirector.GetComponent<Wave>().junkCount) {

            waveDirector.GetComponent<Wave>().completedWave = true;
            waveDirector.GetComponent<Wave>().currentWave++;
            waveDirector.GetComponent<Wave>().initWave(waveDirector.GetComponent<Wave>().currentWave);
            Debug.Log("Wave " + waveDirector.GetComponent<Wave>().currentWave);
        
        }
    }
}
