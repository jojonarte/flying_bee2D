using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour
{

    public float moveRate = .2f;
    public float upperBoundary = 4;
    public float lowerBoundary = -4;
    public float rightBoundary = 4.2f;
    public float leftBoundary = -10.9f;
    public bool isDead = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if dead
        if (!isDead) {


        //add capability to move the player around
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //Debug.Log("X is " + x.ToString() + " Y is " + y.ToString());

        //modify tranform position of player according to axis
        transform.position = new Vector2(
            transform.position.x + x * moveRate,
            transform.position.y + y * moveRate
            );

        //start boundary check
        //check up
      


        if (transform.position.y >= upperBoundary)
        {
            //limit its y to its current y
            transform.position = new Vector2(transform.position.x,
                upperBoundary);
            //Debug.Log("Hit my head!!!!");
        }

        //the next 3 boundaries---------

        //if nilapus na sa ubos  ang y value sa lowerboundary
        if (transform.position.y <= lowerBoundary)
        {
            //usbon nato ang iyang position with a new vector 2
            //nga ang x dili mausab ug ang y muy lower boundary
            transform.position = new Vector2(transform.position.x,
                lowerBoundary);
        }

        if (transform.position.x <= leftBoundary)
        {
            transform.position = new Vector2(leftBoundary,
                transform.position.y);
        }

        if (transform.position.x >= rightBoundary)
        {
            transform.position = new Vector2(rightBoundary,
                transform.position.y);
        }

    }



        if (transform.position.y <= -7.2f){
            Application.LoadLevel("title");
        }

    } 

}
