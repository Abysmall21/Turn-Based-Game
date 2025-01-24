using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMeun");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void OverWorld()
    {
        SceneManager.LoadScene("OverWorld");
    }
    public void AndrewTestRoom()
    {
        SceneManager.LoadScene("AndrewTestRoom");
    }
}
