using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angry : Bunnie, Bunn
{
    public virtual void onHit(){
        for(int i = 0; i < 6; i++){
            GameObject.Find("BunnieMaker").GetComponent<BunnieMaker>().Angry(); 
        }
    }
    
}
