using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resset : MonoBehaviour
{
    public void ResGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Health.health = 3;
        Spawner.Skor = 0;
        Time.timeScale =1;
    }
}
