using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : Hurt
{
    public override void onHit(){
        base.onHit(); 
        //GameObject.Find("Player").GetComponent<Player>().health = -1; 
        GameObject.Find("GameManager").GetComponent<GameManager>().changeHealth(-1000);
    }
}
