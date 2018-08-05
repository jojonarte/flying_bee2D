using UnityEngine;
using System.Collections;

public class DragonControl : MonoBehaviour
{

    public float dragonMoveRate = .1f;
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
        //move dragon
        transform.position = new Vector2(
            transform.position.x + dragonMoveRate,
            transform.position.y);

        //disappear and relocate    
        if (transform.position.x >= 16)
        {
            transform.position = new Vector2(
                Random.Range(-33, -15),
                Random.Range(-3.8f, 3.8f));
        }



    }

}
