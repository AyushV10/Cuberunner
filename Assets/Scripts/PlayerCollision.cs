using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public ScoreText scoreText; 
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;

    // private void OnCollisionEnter(Collision otherGO){
    //     if(otherGO.gameObject.tag=="Collectables"){
    //         Destroy(otherGO.gameObject);
    //     }
    // }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Collectables"){
            audioSource.Play();
            scoreText.AddScore(1);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision otherGO){
        if(otherGO.gameObject.tag=="Obstacles"){
            audioSource1.Play();
            gameController.GameOver();
            playerScript.enabled=false;    
        }
    }
}
