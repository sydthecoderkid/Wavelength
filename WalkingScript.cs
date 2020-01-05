using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{
    public Animation walkanim;
    public Animator walk;
    public GameObject character;
    public static float position;
    private static float walkingposition;
    private static Boolean facingleft;
    private static Boolean facingright;
    // Start is called before the first frame update
    void Start()
    {
        walkanim = this.gameObject.GetComponent<Animation>();
        walk = this.gameObject.GetComponent<Animator>();
       position = character.transform.position.x;
        character = this.gameObject;
        facingleft = false;
        facingright = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(position, this.transform.position.y);
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            MovingRight();
            facingright = true;
            facingleft = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            MovingLeft();
            facingright = false;
            facingleft = true;
        }

        if (!(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {

            NotWalking();
        }
    }

    private void MovingLeft()
    {
        walk.Play("Backwardwalk");
        if (position >= -1.396643)
        {
            position -= Time.deltaTime / 2;
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
        walk.Play("WalkAnim");
        position += Time.deltaTime/2;
    }
}
