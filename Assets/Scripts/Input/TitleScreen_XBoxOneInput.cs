using UnityEngine;

[RequireComponent(typeof(TitleScreen))]
public class TitleScreen_XBoxOneInput : MonoBehaviour
{
#if UNITY_XBOXONE
    private TitleScreen _title;

    public void Start()
    {
        _title = GetComponent<TitleScreen>();
    }

    public void Update()
    {
        if(Input.GetButton("Fire1")) _title.StartGame();
        if(Input.GetButton("Fire2")) _title.ExitGame();
    }
#endif
}
