using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    [SerializeField] private GameObject gameOverUI;

    public int coinsCollected;
    // Start is called before the first frame update
    void Start()
    {
        coinsCollected = 0;
    }
    private void Update(){
         
             
        if (coinsCollected == 3){

            GameObject parentObject = transform.parent.gameObject;

            PauseMenu pauseMenu = parentObject.GetComponent<PauseMenu>();

            pauseMenu.isGameOver = true;




           
            activateMenu();
        }
        else {
            deactivateMenu();
        }
   }

    
    void OnTriggerEnter(Collider other){
        Debug.Log("Entered Collider");
        if (other.CompareTag("Coin")){
            Destroy(other.gameObject);
            ++coinsCollected;
        }
    }

    void activateMenu(){

        Time.timeScale = 0;
        AudioListener.pause = true;
       gameOverUI.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

   }


   public void deactivateMenu(){
        gameOverUI.SetActive(false);

   }
}
