using UnityEngine;
using System.Collections;

public class coinControll : MonoBehaviour {

    public float coinMoveRate = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void FixedUpdate()
    {

        //move coin right to left
        transform.position = new Vector2(transform.position.x - coinMoveRate, 
            transform.position.y);

        if (transform.position.x <= -11)
        {
            Destroy(transform.gameObject);
        }
        
    }
}
