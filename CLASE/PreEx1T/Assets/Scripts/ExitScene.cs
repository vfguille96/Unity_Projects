using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        ExitSceneEsc();
    }

    private static void ExitSceneEsc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Scenes/Menu");
    }
}