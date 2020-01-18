using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void ScenesAdd()
    {
        WalkingScript.scenes.Add("Bedroom");
        WalkingScript.scenes.Add("Kitchen");
        WalkingScript.scenes.Add("Road#1");
        WalkingScript.scenes.Add("CombatScene");
    }
}
