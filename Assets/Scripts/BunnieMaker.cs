using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnieMaker : MonoBehaviour
{
    public Bunnie[] bunnies;
    private void OnEnable(){
        Invoke("Make", Random.Range(0.5f, 3f));
    }
    private void OnDisable(){
        CancelInvoke();
    }

    public void Angry(){
        for(int i = 0; i < 6; i++){
            bunnies[i].spawnChance += 0.001f; 
        }
    }
    public void Calm(){
        for(int i = 0; i < 6; i++){
            bunnies[i].spawnChance = bunnies[i].ogSpawn; 
        }
    }
    private void Make(){
        float spawnChance = Random.value;
        foreach (var obj in bunnies){
            if (spawnChance < obj.spawnChance){
                GameObject obstacle = Instantiate(obj.prefab);
                obstacle.transform.position += transform.position;
                break;
            }
            spawnChance -= obj.spawnChance;
        }
        Invoke("Make", Random.Range(0.5f, 3f));
    }

}