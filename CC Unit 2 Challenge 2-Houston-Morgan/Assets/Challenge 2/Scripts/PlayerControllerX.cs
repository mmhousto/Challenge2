using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    public GameObject dogPrefab;
    private float resetTime = 0.0f;

    // Update is called once per frame
    void Update() {
        resetTime -= Time.deltaTime;
        // On spacebar press, send dog
        if (resetTime <= 0) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                resetTime = 2.5f;
            }
        }
        
    }
}
