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
    public float initialGameSpeed = 1f; 
    public float deltaSpeed = 0.1f;
    private Player player;
    public float score = 0f;
    private BunnieMaker BunnieMaker;
    public TextMeshProUGUI scoreText; 
    public float gameSpeed{
        get; 
        private set; 
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
        GameObject.Find("run").GetComponent<AudioSource>().mute = false; 
        enabled = true;
        GameObject.Find("Player").GetComponent<Player>().health = 100; 
    }

    public void GameOver()
    {   
        Bunnie[] bunnies = FindObjectsOfType<Bunnie>();
        foreach (var Bunnie in bunnies) {
            Destroy(Bunnie.gameObject);
        }
        GameObject.Find("run").GetComponent<AudioSource>().mute = true; 
        GameObject.Find("BunnieMaker").active = false; 
        Time.timeScale = 0; 
        gameSpeed = 0; 
    }

    private void Update(){
        gameSpeed += deltaSpeed * Time.deltaTime; 
        score += gameSpeed * Time.deltaTime; 
        scoreText.text = Mathf.FloorToInt(score).ToString("D5"); 
    }
}