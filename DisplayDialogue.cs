using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DisplayDialogue : MonoBehaviour
{
    public TextMeshProUGUI Dialog;
    private string empty;
    private string currentmessage;
    private string firstmessage;

    private string secondmessage;
    private string thirdmessage;
    private float time;
    private float secondtimer;
   private Scene scene;
    private int indexer;
    private int count = 0;
 
    private bool finalmessage = false;
    private bool keepmessage = false;

    private bool tempbool = false;

     private bool switchmessage = false;

      private bool switchedcharacter = false;
     public String currentscene;

     public GameObject textholder;
    float timetowrite;
    // Start is called before the first frame update
    void Start()
    {
        //TO DO: replace tempbool
           scene = SceneManager.GetActiveScene();
                currentscene = scene.name;
               this.loadmessages();
      
    }

    // Update is called once per frame
    void Update()
    {
      Dialog.text = empty;
     time += Time.deltaTime;
     secondtimer += Time.deltaTime;
     
     if(currentmessage != null){
     timetowrite = (0.1f * currentmessage.Length);
     }

     if(keepmessage && secondtimer >= timetowrite +2 && !tempbool){ //Add in if there is a switched character
           empty = "";
          Dialog.GetComponent<RectTransform>().localPosition = new Vector2(-115, 53);
            switchedcharacter = true;
            count = 0;
            keepmessage = false;
             loadmessages();



     }

if(currentmessage != null){
            indexer = currentmessage.Length;
}
     if(time >= 0.1 && currentmessage != null){
         displaytext();
         
     }
     if(secondtimer >= timetowrite +2 && !keepmessage){
         switchmessage = true;
     }

    }

    public void displaytext(){
        //this method is what makes the text look as though its being typed
        char[] holder;
      holder = currentmessage.ToCharArray(0,indexer); //Translates the given message into characters
      if(count != currentmessage.Length){
      empty += holder[count]; //Adds a character to the end of the displayed message
      count++;
      }
      if(switchmessage){
          nextmessage();
      }
             time = 0;
    }

    public void nextmessage(){
       empty = "";
       if(this.thirdmessage != null && finalmessage == true){
           currentmessage = this.thirdmessage;
           keepmessage = true;
           
       }
       else{
       currentmessage = this.secondmessage;
       finalmessage = true;
       }
       if(this.thirdmessage == null && finalmessage == true){
           currentmessage = this.secondmessage;
           keepmessage = true;
           tempbool = true;
       }
     indexer = currentmessage.Length;
          time = 0;
         secondtimer = 0;
          count = 0;
          switchmessage = false;


    }

    public void loadmessages(){
      if(currentscene.Equals("Kitchen")){
          this.firstmessage = "Malcom! There's a bully outside!";
           this.secondmessage= "He's saying that he wants to fight you!";
           this.thirdmessage = "Go outside and look!";
            this.currentmessage = this.firstmessage;
      }
      if(currentscene.Equals("Road#1") && !switchedcharacter){
          this.firstmessage = "Sup Dweeb! Your stupid sister said you were around.";
          this.secondmessage = "I bet you thought it was real funny tripping me yesterday, huh?";
          this.thirdmessage = "Jokes on you! Nobody messes with the Bradster! Put em' up!";
          this.currentmessage = this.firstmessage;

          
      }
       if(currentscene.Equals("Road#1") && switchedcharacter){
           Dialog.faceColor = UnityEngine.Color.yellow;
          this.firstmessage = "Fine Bradley. Let's fight!";
          this.secondmessage = "Synthesizing wavelengths!";
          this.thirdmessage = null;
          this.currentmessage = this.firstmessage;
          count = 0;
          time = 0;
          secondtimer = 0;
          
      }

    }
}
