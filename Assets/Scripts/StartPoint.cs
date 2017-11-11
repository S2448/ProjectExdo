﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPoint : ProjectComponents {

    public GameObject player;
    public Text readyText;
    public float readyTextBlinkSpeed;
    private ScoreController scoreController;

    // Use this for initialization
    void Start () {
        scoreController = app.controller.scoreController;
        StartCoroutine(GameStartWaiting());
    }

    // Update is called once per frame
    void Update() {
        readyText.color = new Color(readyText.color.r, readyText.color.g, readyText.color.b, Mathf.Round(Mathf.PingPong(Time.time * readyTextBlinkSpeed, 1.0f)));
    }

    IEnumerator GameStartWaiting() {
        yield return new WaitForSeconds(3f);

        readyText.enabled = false;
        player.SetActive(true);
        scoreController.scoreIncreasing = true;
    }
}