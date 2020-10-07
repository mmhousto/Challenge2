using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int ballsCaught = 0;
    public static int ballsMissed = 0;
    Text scoreTxt;
    // Start is called before the first frame update
    void Start() {
        scoreTxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        scoreTxt.text = "Balls Caught: " + ballsCaught + "\nBalls Missed: " + ballsMissed;
    }

    public static void ballCaught() {
        ballsCaught += 1;
    }

    public static void ballMiss()
    {
        ballsMissed += 1;
    }
}
