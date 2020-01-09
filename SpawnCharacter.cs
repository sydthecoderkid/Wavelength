using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public static int holder;
    public static bool firstspawn = true;
    public GameObject character;
    WalkingScript characterpos;
    void Start()
    {
        Instantiate(character);
        characterpos = character.GetComponent<WalkingScript>();
        if (firstspawn)
        {
            WalkingScript.position = -0.6f;
            firstspawn = false;
        }
        Spawncharacter();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Spawncharacter()
    {
        
        if (WalkingScript.switchedleft)
        {
            WalkingScript.position = 1f;
            Debug.Log("Here-faceleft");
        }
         if (WalkingScript.switchedright)
        {
             WalkingScript.position = -0.8f;
            Debug.Log("Here-faceright");
        }
    }


}
