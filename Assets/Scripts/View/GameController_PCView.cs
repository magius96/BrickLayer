﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GameController))]
public class GameController_PCView : MonoBehaviour
{
    public Text ScoreDisplay;
    public GameObject ReplayDialog;
    public GameObject Instructions;

#if UNITY_EDITOR || UNITY_STANDALONE
    private GameController _controller;

    public void Start()
    {
        _controller = GetComponent<GameController>();
        Instructions.SetActive(true);
    }

    public void Update()
    {
        ScoreDisplay.text = string.Format("Score: {0}", _controller.Score);

        ReplayDialog.SetActive(!_controller.Playing);
    }
#endif
}
