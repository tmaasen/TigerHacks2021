using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectJunk : MonoBehaviour
{

    public GameObject waveDirector;
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
            Debug.Log("Incremented Junk Collected: " + waveDirector.GetComponent<Wave>().junkCollected);
        }
        if (waveDirector.GetComponent<Wave>().junkCollected >= waveDirector.GetComponent<Wave>().junkCount-3) {
            waveDirector.GetComponent<Wave>().initWave(waveDirector.GetComponent<Wave>().currentWave++);
            Debug.Log("Wave " + waveDirector.GetComponent<Wave>().currentWave);
        }
        if (collision.gameObject.transform.parent.name == "Boundaries") {
            // Destroy(gameObject);
            waveDirector.GetComponent<Wave>().orbitClutter++;
            Debug.Log("Orbit Cluster is " + waveDirector.GetComponent<Wave>().orbitClutter);
            if(waveDirector.GetComponent<Wave>().orbitClutter >= 100) {
                Application.Quit();
            }
        } 
    }
}
