using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // It may seem silly to build an input class for the title screen only to have it
    // call back to the truth class, but what if we convert to XBox, then we might not
    // need to respond to UI buttons, but to the controller buttons instead.  This
    // seperation is still needed to allow for that.

    // It should be noted that the TitleScreen does NOT have a view class.  Currently
    // a view class is not needed as we aren't updating anything on screen from the
    // code.  Now if we add animations, then the view class will be necessary.
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
