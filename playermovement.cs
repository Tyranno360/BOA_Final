using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermovement : MonoBehaviour
{

    float horizontalMove = 0, verticalMove = 0;
    public float runSpeedHorizontal = 2, runSpeedVertical = 3, runSpeed = 1, jumpForce = 3;

    Rigidbody2D rigidbody2D;
    public Joystick joystick;

    public Button saltar;

    public SpriteRenderer spriteRenderer;

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //verticalMove = joystick.Vertical * runSpeedVertical;
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        anim.SetBool("Run", false);

        if(horizontalMove>0){
            spriteRenderer.flipX = false;
            anim.SetBool("Run", true);
        }

        if(horizontalMove<0){
            spriteRenderer.flipX = true;
            anim.SetBool("Run", true);
        }

        transform.position += new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime * runSpeed;
    }

    public void jump(){
        if(IsGrounded.isGrounded){
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
        }
       // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
