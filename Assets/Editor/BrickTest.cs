using System.Security.Policy;
using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class BrickTest
{
    private Brick _brick;

    [SetUp]
    public void SetupBrickTest()
    {
        // This is called before each and every test
        _brick = new Brick();
        _brick.Awake();
        _brick.Start();
    }

    [Test]
    public void NotStoppedOnAwake()
    {
        Assert.AreNotEqual(Brick.BrickState.Stopped, _brick.State);
    }

    [Test]
	public void StopTest()
    {
        _brick.StopBrick();
        Assert.AreEqual(Brick.BrickState.Stopped, _brick.State);
	}

    [Test]
    public void CatchesOutOfLeftBounds()
    {
        _brick.Position = new Vector3(-10, 0, 0);
        _brick.Update();

        Assert.AreNotEqual(-10, _brick.Position.x);
    }

    [Test]
    public void CatchesOutOfRightBounds()
    {
        _brick.Position = new Vector3(10, 0, 0);
        _brick.Update();

        Assert.AreNotEqual(10, _brick.Position.x);
    }

    [Test]
    public void BrickMoves()
    {
        _brick.Position = Vector3.zero;
        _brick.Update();

        Assert.AreNotEqual(0, _brick.Position.x);
    }
}
