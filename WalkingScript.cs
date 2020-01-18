using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkingScript : MonoBehaviour
{
    public Animation walkanim;
    public Animator walk;
    public GameObject character;
    public static float position;
    public  static bool facingleft;
    public  static bool facingright = true;
    public  static bool switchedleft = false;
    public  static bool switchedright = false;
    public static float spawny= -0.083f;
    public static int sceneindexer = 0;
    public static bool movementenabled = true;
    public  float startingspawn;
    public static List<String> scenes = new List<String>();
    SpawnCharacter spawner;
    // Start is called before the first frame update
    void Start()
    {
        walkanim = this.gameObject.GetComponent<Animation>();
        walk = this.gameObject.GetComponent<Animator>();
        character = this.gameObject;
        SceneList.ScenesAdd();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector2(position, spawny);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            
            if(movementenabled){
            MovingRight();
            facingright = true;
            facingleft = false;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
        
            if(movementenabled){
            MovingLeft();
            facingright = false;
            facingleft = true;
            }
        }

        if (!(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {

            NotWalking();
        }
    
    }

    private void MovingLeft()
    {
        walk.Play("Backwardwalk");
        if (position > -1.396643)
        {
            position -= Time.deltaTime / 2;
        }
        else if (position <= -1.396643)
        {

              if(sceneindexer != 0)
            {
                sceneindexer--;
                switchedleft = true;
                switchedright = false;
                SceneManager.LoadScene(scenes[sceneindexer]);
            }
        }
    }

    private void NotWalking()
    {
        if (facingright)
        {
            walk.Play("Idle");
        }

        if (facingleft)
        {
            walk.Play("IdleLeft");
        }
    }

    private void MovingRight()
    {

        if (position >= 1.3)
        {
            sceneindexer++;
            switchedright = true;
            switchedleft = false;
            SceneManager.LoadScene(scenes[sceneindexer]);
        }
        walk.Play("WalkAnim");
        position += Time.deltaTime/2;
    }
}
