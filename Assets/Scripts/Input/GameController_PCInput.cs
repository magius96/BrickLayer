using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameController_PCInput : MonoBehaviour
{
#if UNITY_STANDALONE || UNITY_EDITOR
    private GameController _controller;

    public void Start()
    {
        _controller = GetComponent<GameController>();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _controller.StopBrick();
        }
    }

    public void YesClicked()
    {
        _controller.Start();
    }

    public void NoClicked()
    {
        _controller.End();
    }
#endif
}
