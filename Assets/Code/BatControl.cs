using UnityEngine;
using System.Collections;

public class BatControl : MonoBehaviour
{

    public float batMoveRate = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void FixedUpdate()
    {
        //move the bat from right to left
        transform.position = new Vector2(
            transform.position.x - batMoveRate,
            transform.position.y);


        if (transform.position.x <= -11)
        {
            //randomize new location of bat
            transform.position =
                new Vector2(
                    Random.Range(11, 25),
                    Random.Range(-4, 4));
        }
    }
}
