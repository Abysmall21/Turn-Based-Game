using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [Header("Pause Menu")]
    public GameObject pauseText;
    public bool isPause;
    public void Start()
    {
        pauseText.gameObject.SetActive(false);
    }

    public void PauseMenu() //to pause game for player
    {
        if (isPause)
        {
            pauseText.gameObject.SetActive(true);
            isPause = false;
        }
        else if (!isPause)
        {
            pauseText.gameObject.SetActive(false);
            isPause = true;
        }

    }
}
