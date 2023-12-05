using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : Bunnie, Bunn
{
    public virtual void onHit(){
        //GameObject.Find("Player").GetComponent<Player>().health -= 25; 
        GameObject.Find("GameManager").GetComponent<GameManager>().changeHealth(-25);
    }
}
