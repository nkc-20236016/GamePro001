using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 0.10f;
    Animator anim;

    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
        }
        else if (Input.GetKey("up"))
        {
            position.y += speed;
        }
        else if (Input.GetKey("down"))
        {
            position.y -= speed;
        }

        transform.position = position;

        float x = Input.GetAxisRaw("Vertical");

        if (x == 0)
        {
            anim.Play("Player");
        }
        else if (x == 1)
        {
            anim.Play("PlayerU");
        }
        else
        {
            anim.Play("PlayerD");
        }

    }
}
