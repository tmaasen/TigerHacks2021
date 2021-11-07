using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectJunk : MonoBehaviour
{

    public GameObject waveThingy;
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
            waveThingy.GetComponent<Wave>().junkCollected++;
            Debug.Log("Incremented Junk Collected: " + waveThingy.GetComponent<Wave>().junkCollected);
        }
        if (waveThingy.GetComponent<Wave>().junkCollected >= waveThingy.GetComponent<Wave>().junkCount-3) {
            waveThingy.GetComponent<Wave>().initWave(waveThingy.GetComponent<Wave>().currentWave++);
            Debug.Log("Wave " + waveThingy.GetComponent<Wave>().currentWave);
        }
        if (collision.gameObject.transform.parent.name == "Boundaries") {
            // Destroy(gameObject);
            orbitClutter++;
            Debug.Log("Orbit Cluster is " + orbitClutter);
            if(orbitClutter >= 100) {
                Application.Quit();
            }
        } 
    }
}
