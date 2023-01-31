using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneMan : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
