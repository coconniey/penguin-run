using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sad : Normal
{
    public override void onHit(){
        base.onHit(); 
        GameObject.Find("Player").GetComponent<Player>().isSad = true; 
    }
}
