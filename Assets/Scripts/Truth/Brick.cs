using UnityEngine;
using Random = UnityEngine.Random;

public class Brick : MonoBehaviour
{
    public Vector3 Position = Vector3.zero;
    private BrickState _state = BrickState.Stopped;
    private float _maxXPosition = 4;
    private float _speed;

    public BrickState State { get { return _state; } }

    public void Awake()
    {
        if (Random.Range(0, 100) < 50)
        {
            _state = BrickState.MovingLeft;
            Position = new Vector3(-_maxXPosition, 0, 0);
        }
        else
        {
            _state = BrickState.MovingRight;
            Position = new Vector3(_maxXPosition, 0, 0);
        }
    }

    public void Start()
    {
        _speed = (1 + Position.y)*0.05f;
    }

    public void Update()
    {
        if (_state == BrickState.Stopped) return;
        CheckLeftBounds();
        CheckRightBounds();
        MoveBrick();
    }

    private void CheckLeftBounds()
    {
        if (Position.x < -_maxXPosition)
        {
            Position.x = -_maxXPosition;
            _state = BrickState.MovingRight;
        }
    }

    private void CheckRightBounds()
    {
        if (Position.x > _maxXPosition)
        {
            Position.x = _maxXPosition;
            _state = BrickState.MovingLeft;
        }
    }

    private void MoveBrick()
    {
        switch (_state)
        {
            case BrickState.MovingLeft:
                Position.x -= _speed;
                break;
            case BrickState.MovingRight:
                Position.x += _speed;
                break;
        }
    }

    public void Destroy()
    {
        GameObject.Destroy(gameObject);
    }

    public void StopBrick()
    {
        _state = BrickState.Stopped;
    }

    public enum BrickState
    {
        MovingLeft,
        MovingRight,
        Stopped
    }
}
