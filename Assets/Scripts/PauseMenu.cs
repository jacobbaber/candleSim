using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

   private void Update(){
         
             
        if(Input.GetKeyDown(KeyCode.Escape)){
            isPaused = !isPaused;
        }

        if(isPaused){
            activateMenu();
        }else{
            deactivateMenu();
        }
   }

   void activateMenu(){

        Time.timeScale = 0;
        AudioListener.pause = true;
       pauseMenuUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

   }

   public void deactivateMenu(){
        Time.timeScale = 1;
        AudioListener.pause = false;
       pauseMenuUI.SetActive(false);
        Cursor.visible = false;
        isPaused = false;
   }


}
