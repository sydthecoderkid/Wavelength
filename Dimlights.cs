using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimlights : MonoBehaviour
{
    public GameObject tile1;
    private SpriteRenderer tile1render;
    public GameObject tile2;
    private SpriteRenderer tile2render;

    public GameObject tile3;
    private SpriteRenderer tile3render;
    public GameObject tile4;
    private SpriteRenderer tile4render;

    public GameObject enemy;
    private SpriteRenderer enemyrender;
    // Start is called before the first frame update
    void Start()
    {
     tile1render = tile1.GetComponent<SpriteRenderer>();
     tile2render = tile2.GetComponent<SpriteRenderer>();
     tile3render = tile3.GetComponent<SpriteRenderer>();
     tile4render = tile4.GetComponent<SpriteRenderer>();
     enemyrender = enemy.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     if(BeginCombat.combatstarted){
       tile1render.color = new Color(0.5f, 0.5f,0.5f,1);
       tile2render.color = new Color(0.5f, 0.5f,0.5f,1);
       tile3render.color = new Color(0.5f, 0.5f,0.5f,1);
       tile4render.color = new Color(0.5f, 0.5f,0.5f,1);
       enemyrender.color = new Color(0.5f, 0.5f,0.5f,1);
       }   
    }
}
