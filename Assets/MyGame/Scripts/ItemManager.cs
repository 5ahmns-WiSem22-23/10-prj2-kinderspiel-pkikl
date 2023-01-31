using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameSceneManager gameSceneMan;
    public GameSceneManager.Item item;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (item)
        {
            case GameSceneManager.Item.Boat:

                if (collision.gameObject.CompareTag("Fish"))
                {
                    gameSceneMan.CheckForWin();
                }
                Destroy(collision.gameObject);
                break;

            case GameSceneManager.Item.Fish:
                if (collision.gameObject.CompareTag("Goal"))
                {
                    gameSceneMan.GameOver(GameSceneManager.Item.Fish);
                }
                break;
        }
    }
}
