using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonStart : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI buttonText;

    void Start(){
        // get the child component of button
        buttonText = GetComponentInChildren<TextMeshProUGUI>();

    }
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(1);
    }

    // change child text color to dark red when mouseover
    public void OnPointerEnter(PointerEventData eventData){
        buttonText.color = new Color(0.5f, 0, 0);
    }

    // change child text color to white when mouseover
    public void OnPointerExit(PointerEventData eventData){
        buttonText.color = Color.white;
    }
}
