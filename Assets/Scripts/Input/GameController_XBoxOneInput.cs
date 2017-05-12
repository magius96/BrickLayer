using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameController))]
public class GameController_XBoxOneInput : MonoBehaviour
{
#if UNITY_XBOXONE
    private GameController _controller;

    public void Start()
    {
        _controller = GetComponent<GameController>();
    }

    public void Update()
    {
        if (_controller.Playing)
        {
            if (Input.GetButton("Fire1")) _controller.StopBrick();
        }
        else
        {
            if(Input.GetButton("Fire1")) _controller.Start();
            if(Input.GetButton("Fire2")) _controller.End();
        }
    }
#endif
}
