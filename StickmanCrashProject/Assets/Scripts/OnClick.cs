using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("Game");
    }
}

public class ExitGame : MonoBehaviour
{
    public void exitGame()
    {
        Application.Quit();
    }
}
