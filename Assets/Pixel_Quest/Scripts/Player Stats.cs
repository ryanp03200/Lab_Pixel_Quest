using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private int coincounter = 0;
    private readonly string nextlevel;
    private int _health = 3;
    private int _maxhealth = 3;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {

                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
         
                }
            case "Coin":
                
                { 
                        coincounter++;
                  Destroy(collision.gameObject); 
                    break;
                }
            case "Health":
                { _health++;
                    Destroy(collision.gameObject);
                    break;
                }
               
        }
    }
}
