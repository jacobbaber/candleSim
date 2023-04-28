using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;



public class ButtonExit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private TextMeshProUGUI buttonText;
    // Start is called before the first frame update
    public void Exit()
    {
        Application.Quit();
    }

    void Start(){
        // get the child component of button
        buttonText = GetComponentInChildren<TextMeshProUGUI>();

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
