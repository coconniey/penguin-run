using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    public AudioSource audioSource;
    private Vector3 direction;
    public Animator anim;
    public float jumpForce = 10f;
    public float gravity = 10f;

    public int health = 100; 

 

    public bool isSad = false; 

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>(); 
    }

    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Update()
    {
        isAlive(); 
        direction += Vector3.down * gravity * Time.deltaTime;

        if (character.isGrounded)
        {
            direction = Vector3.down;
            anim.speed = 1;
            if (Input.GetButton("Jump")) {
                audioSource.Play(); 
                direction = Vector3.up * jumpForce;
                anim.speed = 0; 
            }
        }
        

        character.Move(direction * Time.deltaTime);
    }

    public void isAlive(){
        if(health <= 0){
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
        } 
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Angry")){
            other.gameObject.GetComponent<Angry>().onHit(); 
        }
        else if(other.CompareTag("Happy")){
            other.gameObject.GetComponent<Happy>().onHit(); 
        }
        else if(other.CompareTag("Sad")){
            other.gameObject.GetComponent<Sad>().onHit(); 
        }
        else if(other.CompareTag("Normal")){
            other.gameObject.GetComponent<Normal>().onHit(); 
        }
        else if(other.CompareTag("Hurt")){
            other.gameObject.GetComponent<Hurt>().onHit(); 
        }
        else if(other.CompareTag("Death")){
            other.gameObject.GetComponent<Death>().onHit();
        }
        else{

        }
    }

}