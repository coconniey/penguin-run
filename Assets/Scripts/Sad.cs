using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sad : Normal
{
    public override void onHit(){
        base.onHit(); 
        if(Random.Range(0,1) < 0.5){
            GameObject.Find("Player").GetComponent<Player>().isSad = true;
        } 
    }
}
