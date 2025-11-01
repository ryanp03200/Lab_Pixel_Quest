using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _Rigidbody2D;
    public int speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _Rigidbody2D.velocity = new Vector2(horizontal * speed, _Rigidbody2D.velocity.y);
    }

}
