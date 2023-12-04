using UnityEngine;
using System.Collections;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    
    void Update()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        //float score = GameObject.Find("GameManager").GetComponent<GameManager>().score; 
        //textmeshPro.SetText("{0:0}", score);
    }
}