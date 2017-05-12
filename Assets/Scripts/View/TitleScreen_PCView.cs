using UnityEngine;

[RequireComponent(typeof(TitleScreen))]
public class TitleScreen_PCView : MonoBehaviour
{
    public GameObject Container;

#if UNITY_EDITOR || UNITY_STANDALONE
    public void Start()
    {
        Container.SetActive(true);
    }
#endif
}
