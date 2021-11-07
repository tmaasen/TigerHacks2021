using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveField : MonoBehaviour
{

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
        } else if (collision.gameObject.name == "TopWall" || collision.gameObject.name == "BottomWall") {
            Destroy(gameObject);
        } else if (collision.gameObject.name == "RightWall") {
            Destroy(gameObject);
            GameObject.Find("Drone").GetComponent<collectJunk>().orbitClutter++;
            // Debug.Log("ClutterCount: " + GameObject.Find("Drone").GetComponent<collectJunk>().orbitClutter);
        }
    }
}
