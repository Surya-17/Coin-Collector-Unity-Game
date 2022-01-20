using UnityEngine;
using System.Collections;
public class CoinScript : MonoBehaviour {
     public int score = 0;
    // Use this for initialization
    void Start () {
  
    }
  
    // Update is called once per frame
    void Update () {
  
    }
    void OnTriggerEnter2D(Collider2D other){
          Debug.Log ("Triggered");
        Destroy (gameObject);
        score++;
        Debug.Log ("Score: " + score);
    }

}


