using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

// Quits the player when the user hits escape

public class menu_exit : MonoBehaviour
{
    Color m_MouseOverColor = Color.red;

    //This stores the GameObject’s original color
    Color m_OriginalColor;

    MeshRenderer m_Renderer;

    //public TMP_text text;

    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = m_Renderer.material.color;

    }

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

    void OnMouseExit()
    {
        // Reset the color of the GameObject back to normal
        m_Renderer.material.color = m_OriginalColor;



    }

    void OnMouseOver()
    {
        // Change the color of the GameObject to red when the mouse is over GameObject
        Debug.Log("hovering");
        m_Renderer.material.color = m_MouseOverColor;
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }



}