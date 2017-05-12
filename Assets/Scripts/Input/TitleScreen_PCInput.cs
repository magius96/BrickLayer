using UnityEngine;

[RequireComponent(typeof(TitleScreen))]
public class TitleScreen_PCInput : MonoBehaviour
{
#if UNITY_STANDALONE || UNITY_EDITOR
    private TitleScreen _title;

    public void Start()
    {
        _title = GetComponent<TitleScreen>();
    }

    public void PlayClicked()
    {
        _title.StartGame();
    }

    public void QuitClicked()
    {
        _title.ExitGame();
    }
#endif
}
