using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour {

    Text text;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameManager lm = FindObjectOfType<GameManager>();
        text.text = "Timer : " + lm.timeTillNextLevel;
    }
}
