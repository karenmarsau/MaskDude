using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour{
    public string levelName;
    private bool inDoor;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag=="Player"){
            inDoor=true;
            levelName=gameObject.name;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision) {
         if(collision.tag=="Player"){
            inDoor=false;        
        }
    }

    private void Update() {
        if(inDoor==true && Input.GetKey("e")) {
            SceneManager.LoadScene(levelName);
        }
    }
}

