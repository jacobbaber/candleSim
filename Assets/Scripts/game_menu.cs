using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


// Quits the player when the user hits escape

public class game_menu : MonoBehaviour
{
    public 
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(2);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}