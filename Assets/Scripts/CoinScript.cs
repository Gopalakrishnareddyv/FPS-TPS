using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            ScoreScript.scoreInstance.CoinIncrement();
            Destroy(other.gameObject);
        }
    }

}
