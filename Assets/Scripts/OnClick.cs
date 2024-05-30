using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public string SceneName;
    public void onClick()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void OnChooseMapButtonClick()
    {
        SceneManager.LoadScene("Custom");
    }
}