using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {


    public float maxTime = 60f;

    private float countDown = 0;

	// Use this for initialization
	void Start () {
        countDown = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;

        if (countDown <= 0)
        {
            Coin.coinCount = 0;
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
