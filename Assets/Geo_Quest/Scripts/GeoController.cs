using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    public int myvariable = 0;
    private Rigidbody2D rb;
    public float speed = 5;
    public string nextlevel = "scene_2";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 1f);
        }
        */

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }

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
        }
    }
}
                
