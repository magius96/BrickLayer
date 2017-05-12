using UnityEngine;

[RequireComponent(typeof(Brick))]
[RequireComponent(typeof(SpriteRenderer))]
public class Brick_View : MonoBehaviour
{
    // Notice there's only one view for this, regardless of what system its built for

    private Brick _brick;
    
    public void Start()
    {
        _brick = GetComponent<Brick>();
        SetSprite();
    }

    public void Update()
    {
        transform.position = _brick.Position;
    }

    private void SetSprite()
    {
        var imgId = Random.Range(1, 3);
        var spriteName = string.Format("Graphics/Brick{0}", imgId);
        var sprite = Resources.Load<Sprite>(spriteName);

        var rend = GetComponent<SpriteRenderer>();
        rend.sprite = sprite;
    }
}
