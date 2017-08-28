using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


    //Keeps trach of total coind count in scene
    public static int coinCount = 0;
    public float spinSpeed = 1;

	// Use this for initialization
	void Start () {
        Coin.coinCount++;

        Debug.Log("Coin instance created.");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("Entered coin collider");
            
            Destroy(gameObject);
        }
    }

    //called when object is destroyed
    void OnDestroy()
    {
        //Decrement coin count
        Coin.coinCount--;

        //check remaining coins
        if(Coin.coinCount <= 0)
        {
            //winning condition
        }
        
    }
}
