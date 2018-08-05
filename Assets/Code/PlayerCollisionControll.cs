using UnityEngine;
using System.Collections;

public class PlayerCollisionControll : MonoBehaviour {
 
    public float tossUpSpeed = 15;
    public AudioClip coinSound;
    public AudioClip killSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /*public void OnTriggerEnter2D(Collider2D collision)
    { Debug.Log("Gihikap ko!"); }*/
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Gihikap ko!");
        Debug.Log(collision.gameObject.tag);

        if (collision.transform.tag == "coin")
        {
            //destroy coin game object
            Destroy(collision.gameObject);
            //coincount++;

            //add score
            int currScore = GameObject.Find("scoreController").GetComponent<ScoreControll>().currScore;
            GameObject.Find("scoreController").GetComponent<ScoreControll>().AddScore();

            //coin Sound
            transform.GetComponent<AudioSource>().clip = coinSound;
            transform.GetComponent<AudioSource>().Play();

            Debug.Log(currScore);
        }

        if (collision.transform.tag == "enemy")
        {
            //kill playah

            KillPlayer();
            // Destroy(collision.gameObject);
            // coincount = 0;

      
        }

    }

    public void FixedUpdate()
    {
       // Debug.Log("Coin count is "+coincount);
    }


    public void KillPlayer()
    {


        //play sound
        transform.GetComponent<AudioSource>().clip = killSound;
        transform.GetComponent<AudioSource>().Play();

        //toss player up
        transform.GetComponent<Rigidbody2D>().gravityScale = 1;
        transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * tossUpSpeed, ForceMode2D.Impulse);
        //spin player
        transform.GetComponentInChildren<Animator>().SetTrigger("playerkill");
        transform.GetComponent<playerControl>().isDead = true;
        transform.GetComponent<Collider2D>().enabled = false;

        
        //disable interaction with any other object
    }
}
