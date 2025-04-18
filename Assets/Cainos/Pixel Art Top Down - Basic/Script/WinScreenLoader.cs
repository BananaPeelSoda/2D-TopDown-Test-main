using UnityEngine;
using UnityEngine.SceneManagement;

// Show the buildIndex for the current script.
//
// The Build Settings window shows 5 added Scenes.  These have buildIndex values from
// 0 to 4. Each Scene has a version of this script applied.
//
// In the Project, create 5 Scenes called scene1, scene2, scene3, scene4 and scene5.
// In each Scene add an empty GameObject and attach this script to it.
//
// Each Scene randomly switches to a different Scene when the button is clicked.

public class ExampleScript : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene name is: " + scene.name + "\nActive Scene index: " + scene.buildIndex);
    }

    void OnGUI()
    {
        GUI.skin.button.fontSize = 20;

        if (GUI.Button(new Rect(10, 80, 180, 60), "Change from scene " + scene.buildIndex))
        {
            int nextSceneIndex = Random.Range(0, 4);
            SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Single);
        }
    }
}