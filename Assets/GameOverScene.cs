using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
   
    public GameObject Gameover;
    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Debug.Log("Quit");
    }
}
