using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 


public class GameManager : MonoBehaviour
{
    public static GameManager Instance {
        get; 
        private set;
    }
    private float initialGameSpeed = 1f; 
    private float deltaSpeed = 0.1f;
    private Player player;
    public float score = 0f;
    public int health = 0; 
    private BunnieMaker BunnieMaker;
    public TextMeshProUGUI scoreText; 
    public float gameSpeed{
        get; 
        private set; 
    }
    public int getHealth(){
        return health; 
    }
    public void changeHealth(int diff){
        health += diff; 
        if(health > 100){
            health = 100; 
        }
        isAlive(); 
    }
    public bool isAlive(){
        if(health <= 0){
            GameObject.Find("audio").GetComponent<audio>().deathSound();
            NewGame(); 
            return false;
        }
        return true; 
    }
    private void Awake(){
        if (Instance == null) {
            Instance = this;
        }
        else{    
            DestroyImmediate(gameObject);
        }
    }    
    private void OnDestroy(){
        if (Instance == this){
            Instance = null;
        }
    }
    private void Start(){
        NewGame(); 
    }
    public void NewGame()
    { 
        GameObject.Find("BunnieMaker").active = true;
        GameObject.Find("BunnieMaker").GetComponent<BunnieMaker>().Calm();
        score = 0;
        gameSpeed = initialGameSpeed;
        Time.timeScale = 1;
        GameObject.Find("audio").GetComponent<audio>().mute1(false); 
        enabled = true;
        //GameObject.Find("Player").GetComponent<Player>().health = 100; 
        health = 100; 
    }

    public void GameOver()
    {   
        Bunnie[] bunnies = FindObjectsOfType<Bunnie>();
        foreach (var Bunnie in bunnies) {
            Destroy(Bunnie.gameObject);
        }
        GameObject.Find("audio").GetComponent<audio>().mute1(true); 
        GameObject.Find("BunnieMaker").active = false; 
        Time.timeScale = 0; 
        gameSpeed = 0; 
        Invoke("NewGame", 2);
    }

    private void Update(){
        gameSpeed += deltaSpeed * Time.deltaTime; 
        score += gameSpeed * Time.deltaTime; 
        scoreText.text = Mathf.FloorToInt(score).ToString("D5"); 
        GameObject.Find("health").GetComponent<Transform>().position = new Vector3(-(100-health)/5, 5, 0f);
    }
}