using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : Bunnie, Bunn
{
    public virtual void onHit(){
        GameObject.Find("GameManager").GetComponent<GameManager>().score += 10; 
    }
}
