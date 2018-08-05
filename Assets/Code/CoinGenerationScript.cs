using UnityEngine;
using System.Collections;

public class CoinGenerationScript : MonoBehaviour {

    public Transform coinPrefab;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateCoin",0,2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void GenerateCoin()
    {
        Instantiate(coinPrefab,
            new Vector2(11, Random.Range(-4, 4)),
           coinPrefab.rotation
            );
    }
}
