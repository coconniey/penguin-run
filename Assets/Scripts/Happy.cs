using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happy : Normal
{
    public override void onHit(){
        if(GameObject.Find("Player").GetComponent<Player>().isSad){
            GameObject.Find("Player").GetComponent<Player>().isSad = false; 
        }
        else{
            base.onHit(); 
            // if(GameObject.Find("Player").GetComponent<Player>().health < 150){
            //     GameObject.Find("Player").GetComponent<Player>().health += 25;
            // }
            GameObject.Find("GameManager").GetComponent<GameManager>().changeHealth(25);
            GameObject.Find("BunnieMaker").GetComponent<BunnieMaker>().Calm();
        }
    }

}
