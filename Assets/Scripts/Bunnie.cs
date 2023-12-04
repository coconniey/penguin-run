using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bunnie : MonoBehaviour
{
    private float leftSide;
    public GameObject prefab;
    public float spawnChance;
    public float ogSpawn; 

    private void Start()
    {
        leftSide = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }

    private void Update()
    {
        transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;

        if (transform.position.x < leftSide) {
            Destroy(gameObject);
        }
    }

}
public interface Bunn
{
    void onHit();  
}