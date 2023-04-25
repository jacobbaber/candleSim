using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


// Quits the player when the user hits escape

public class menu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter");
            SceneManager.LoadScene(1);
        }
    }
}