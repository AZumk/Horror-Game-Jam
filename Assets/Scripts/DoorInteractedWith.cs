﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractedWith : MonoBehaviour
{
    public bool isClicked;
    public string scene;
    public bool locked;
    //public Animator anim;

    // Start is called before the first frame update
    public void Interact()
    {
        if(!isClicked){
            Debug.Log("Open");
            //animator.SetBool("isActive", isClicked);

            if(this.tag == "Door"){
                isClicked = true;
                SceneManager.LoadScene(scene);
            }
            if(this.tag == "DoorLocked"){
                if(!locked){
                    isClicked = true;
                    SceneManager.LoadScene(scene);
                } 
                else{
                    
                }
            }

        }
    }
}
