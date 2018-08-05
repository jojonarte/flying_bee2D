using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
{
    public float backGroundMoveRate = .5f;

    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    //just like update but incremental
    void FixedUpdate()
    {
        //moves the background according to the background speed
        transform.position = new Vector2(
            transform.position.x - backGroundMoveRate, 
            transform.position.y);

        //checks if the bacground is in end position
        if (transform.position.x <= -24.51f) {
            //move this  object to the starting position
            transform.position = new Vector2(24.78f, transform.position.y);
        }
    }
}
