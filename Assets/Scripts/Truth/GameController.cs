using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int Score = 0;

    private List<Brick> _bricks = new List<Brick>();

    public bool Playing = true;

    public void Start()
    {
        if (_bricks.Count > 0)
        {
            foreach (Brick brick in _bricks)
            {
                brick.Destroy();
            }
        }
        _bricks = new List<Brick>();
        CreateBrick();
        Score = 0;
        Playing = true;
    }

    public void End()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
    }

    public void StopBrick()
    {
        if (_bricks.Count < 1) return;
        _bricks[_bricks.Count - 1].StopBrick();
        AddScore();
        if (_bricks.Count >= 9)
        {
            Playing = false;
            return;
        }
        CreateBrick();
    }

    private void AddScore()
    {
        var dist = Mathf.Abs(_bricks[_bricks.Count - 1].Position.x);
        var diff = 4f - dist;
        var score = diff*(100 * _bricks.Count);
        Score += (int)score;
    }

    private void CreateBrick()
    {
        var obj = Resources.Load<GameObject>("Prefabs/Brick");
        var brickObject = Instantiate(obj);
        var brick = brickObject.GetComponent<Brick>();
        brick.Position.y = _bricks.Count;
        _bricks.Add(brick);
    }
}
