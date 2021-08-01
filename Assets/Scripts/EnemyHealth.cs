using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamageEnemy(int damageAmount)
    {
        currentHealth = currentHealth - damageAmount;
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            //SceneManager.LoadScene(2);
        }
    }
}
