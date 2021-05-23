  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDie : MonoBehaviour{
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Destroy(collision.gameObject, 0.1f);
        }
    }
}
