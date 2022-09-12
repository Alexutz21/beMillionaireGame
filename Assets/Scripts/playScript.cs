using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        //SceneManager.GetActiveScene().buildIndex + 1
    }
}
