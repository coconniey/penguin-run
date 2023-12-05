using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    
    public AudioSource audioSource1;
    public AudioSource audioSource2; 
    public AudioSource audioSource3; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hitSound(){
        audioSource2.Play(); 
    }
    public void mute1(bool ask){
        if(ask == true){
            audioSource1.mute = true; 
        }
        else{
            audioSource1.mute = false; 
        }
    }
    public void deathSound(){
        audioSource3.Play(); 
    }
}
