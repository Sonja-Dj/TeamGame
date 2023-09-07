using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class SwitchCTRL : MonoBehaviour
{
    private bool isLowerLevelLoaded = false;
    private bool isUpperLevel1Loaded = false;

    private void Awake()
    {
        // Load both scenes asynchronously in the background
        //LoadSceneAsync("UpperLevel1");
        //LoadSceneAsync("LowerLevel1");

        SceneManager.LoadScene("LowerLevel1", LoadSceneMode.Additive);
        isLowerLevelLoaded = true;
    }

    private void Update()
    {
        // Check if both scenes are loaded before switching
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Switch between the scenes
            SwitchScenes();
        }
    }

    // private void LoadSceneAsync(string sceneName)
    // {
    //     // Load the scene asynchronously
    //     SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive).completed += (operation) =>
    //     {
    //         if (sceneName == "LowerLevel1")
    //         {
    //             isLowerLevelLoaded = true;
    //         }
    //         else if (sceneName == "UpperLevel1")
    //         {
    //             isUpperLevel1Loaded = true;
    //         }
    //     };
    // }

    private void SwitchScenes()
    {
        // Unload the currently active scene (assuming there's only one active scene)
        // Load the other scene

        if (isLowerLevelLoaded)
        {
            isLowerLevelLoaded = false;
            isUpperLevel1Loaded = true;
            
            SceneManager.UnloadSceneAsync("LowerLevel1");
            SceneManager.LoadScene("UpperLevel1", LoadSceneMode.Additive);
        }
        else
        {
            isLowerLevelLoaded = true;
            isUpperLevel1Loaded = false;
            
            SceneManager.UnloadSceneAsync("UpperLevel1");
            SceneManager.LoadScene("LowerLevel1", LoadSceneMode.Additive);
        }
        
        // if (activeScene.name == "LowerLevel1")
        // {
        //     SceneManager.LoadScene("UpperLevel1", LoadSceneMode.Additive);
        // }
        // else
        // {
        //     SceneManager.LoadScene("LowerLevel1", LoadSceneMode.Additive);
        // }
    }
}