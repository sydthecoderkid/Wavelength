using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public static int holder;
    public static bool firstspawn = true;
    public GameObject character;
    WalkingScript characterpos;

    private Scene scene;
    private string currentscene;

    
        public GameObject npc1;
         public GameObject npc2;
          public GameObject npc3;
    void Start()
    {
        //When testing combat systems, make sure to change firstspawn position.
        Instantiate(character);
        characterpos = character.GetComponent<WalkingScript>();
        if (firstspawn)
        {
            WalkingScript.position = -0.6f;
            firstspawn = false;
        }
         scene = SceneManager.GetActiveScene();
        currentscene = scene.name;
        Spawncharacter();
        SpawnNPCS();
        
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
        }
         if (WalkingScript.switchedright)
        {
             WalkingScript.position = -0.8f;
        }
    }

    public void SpawnNPCS(){
        if(currentscene.Equals("Kitchen")){
        }

    }


}
