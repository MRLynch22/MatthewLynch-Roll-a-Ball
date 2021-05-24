using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{

    public int scoreValue;
    private GameController _gc;

    // Start is called before the first frame update
    void Start()
    {
        _gc = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gc.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
