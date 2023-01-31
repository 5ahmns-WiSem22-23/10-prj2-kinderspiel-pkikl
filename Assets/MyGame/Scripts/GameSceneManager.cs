using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public enum Item
    {
        Fish,
        Boat
    }

    public static Item currentWinner;

    public int moveAmount;

    int fishCount = 4;
    private Color goalColor;

    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject yellow;
    public GameObject boat;

    public AudioSource diceSound;

    public SpriteRenderer goalLine;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            diceSound.Play();
            RollDice();
        }
    }

    void MoveItem(GameObject item, Color goalColor)
    {
        item.transform.position = new Vector3(item.transform.position.x + moveAmount, item.transform.position.y, item.transform.position.z);
        goalLine.color = goalColor;
    }

    public void GameOver(Item winner)
    {
        currentWinner = winner;
        SceneManager.LoadScene("Endscene");
    }

    public void CheckForWin()
    {
        fishCount--;

        if (fishCount <= 0)
        {
            GameOver(GameSceneManager.Item.Boat);
        }

    }

    void RollDice()
    {

        int random = Random.Range(1, 7);

        switch (random)
        {
            case 1:
                try
                {
                    MoveItem(red, Color.red);
                }
                catch {
                    MoveItem(boat, Color.magenta);
                }
                break;

            case 2:
                try
                {
                    MoveItem(blue, Color.blue);
                }
                catch {
                    MoveItem(boat, Color.magenta);
                }
                break;

            case 3:
                try
                {
                    MoveItem(green, Color.green);
                }
                catch {
                    MoveItem(boat, Color.magenta);
                }
                break;

            case 4:
                try
                {
                    MoveItem(yellow, Color.yellow);
                }
                catch {
                    MoveItem(boat, Color.magenta);
                }
                break;

            case 5:
                MoveItem(boat, Color.magenta);
                break;

            case 6:
                MoveItem(boat, Color.magenta);
                break;
        }
    }
}
