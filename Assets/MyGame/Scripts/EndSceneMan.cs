using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneMan : MonoBehaviour
{
    public Text status;

    private void Start()
    {
        status.text = GameSceneManager.currentWinner == GameSceneManager.Item.Boat ? "Oje, das Boot hat gewonnen." : "Hurra, die Fische haben gewonnen!";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Start");
    }
    
}
