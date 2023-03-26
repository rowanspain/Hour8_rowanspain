using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
     int TakeDamage()
        {
            int playerHealth = 100;
            return playerHealth - 5;
        }

        int TakeDamage(int damage)
        {
            int playerHealth = 100;
            return playerHealth - damage;
        }

        int TakeDamage(int playerHealth, int damage)
        {
            return playerHealth - damage;
        }

    // Start is called before the first frame update
    void Start()
    {
       int x = TakeDamage();
       print("Player health is: " + x);

       int y = TakeDamage(25);
       print("Second Method pLayer health is: " + y);

       int z = TakeDamage(100, 40);
       print("Third Method player health is: " + z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
