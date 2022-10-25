using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float yspeed;
    public float ytarget;
    public GameObject SoundBounce;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        transform.Translate(0, yspeed, 0);
        yspeed = Mathf.Lerp(yspeed, ytarget, 025f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            yspeed = .05f;
            rb.AddForce(new Vector3(0, 150, 0));
            thisAnimation.Play();


        }
    }
}