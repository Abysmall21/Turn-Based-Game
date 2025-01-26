using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SwitchScene(string sceneName)
    {
        // Loads the specified scene Balthazar:"You can type the name of the scene 
        SceneManager.LoadScene(sceneName);
    }
    // This method will be called to quit the application
    public void QuitApplication()
    {
        // If we are in the editor, stop playing but in the apllication mode it will quit the game.
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        // If we are running a build, quit the application
        Application.Quit();
    #endif
    }
}
