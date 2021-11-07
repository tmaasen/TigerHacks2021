using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveField : MonoBehaviour
{
    private int orbitClutter = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Drone") {
            Destroy(gameObject);
        } 
        // problem
        else if (collision.gameObject.transform.parent.name == "Boundaries") {
            if (collision.gameObject.name != "LeftWall") {
                Destroy(gameObject);
            }
        } 
    }
}
