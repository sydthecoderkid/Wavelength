using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentScene : MonoBehaviour
{
    public static string currentscene;
    public static string lastscene;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = new Scene();
         scene = SceneManager.GetActiveScene();
         Update();

    // Update is called once per frame
    void Update()
    {
          currentscene = scene.name;
    }
    }
}
