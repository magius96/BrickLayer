using UnityEngine;

public class TitleScreen_XBoxOneView : MonoBehaviour
{
    public GameObject Container;

#if UNITY_XBOXONE
    public void Start()
    {
        Container.SetActive(true);
    }
#endif
}
