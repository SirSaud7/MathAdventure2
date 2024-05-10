using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private enum movstate { idle, running, jumping }
    private BoxCollider2D box2d;
    private SpriteRenderer sprite;
    float drix;
    [SerializeField] float speed = 6f;
    [SerializeField] float jump = 4f;
    [SerializeField] private LayerMask jumpchick;
    private Rigidbody2D rb;
    private Animator anim;
    bool dj;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box2d = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    private void Update()
    {
        drix = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(drix, 0) * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded())
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                dj = true;
            }

            else if (dj)
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                dj = false;
            }
            {

            }
        }
        UpdateAnimatonState();

    }
    private void UpdateAnimatonState()
    {
        movstate state;
        if (drix > 0f)
        {
           state= movstate.running;
            sprite.flipX = false; 
        }
        else if (drix < 0f)
        {
            state = movstate.running;
            sprite.flipX = true;
        }
        else
        {
            state = movstate.idle;
        }
        if (rb.velocity.y>.1f)
        {
            state = movstate.jumping;
        }
        
        anim.SetInteger("state",(int)state);
    }
    private bool IsGrounded()
    {
       return Physics2D.BoxCast(box2d.bounds.center, box2d.bounds.size, 0f, Vector2.down, .1f, jumpchick);
    }
    
}
