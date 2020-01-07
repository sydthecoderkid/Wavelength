using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public static int holder;
    public static System.Boolean firstspawn = true;
    public GameObject character;
    WalkingScript characterpos;
    void Start()
    {
        WalkingScript.switchedleft = true;
   
        if (WalkingScript.switchedleft == true) { 
        SpawnLeft();
          }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnLeft()
    {

        Instantiate(character);
        characterpos = character.GetComponent<WalkingScript>();
        characterpos.facingleft = true;
        characterpos.facingright = false;
        //WalkingScript.position = 0.3f;
    }

    public void SpawnRight()
    {
        Instantiate(character);
        characterpos = character.GetComponent<WalkingScript>();
        characterpos.facingleft = false;
        characterpos.facingright = true;
        //WalkingScript.position = 1f;s
    }
}
