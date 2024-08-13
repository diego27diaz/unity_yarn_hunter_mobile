using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CatController : MonoBehaviour
{
    bool canJump = true;
    bool isMovingLeft = false;
    bool isMovingRight = false;
    bool isMovementUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingLeft)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            if (canJump)
            {
                gameObject.GetComponent<Animator>().SetBool("moving", true);
            }
        }

        if (isMovingRight)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            if (canJump)
            {
                gameObject.GetComponent<Animator>().SetBool("moving", true);
            }
        }

        if (!isMovingRight && !isMovingLeft)
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if (isMovementUp && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20000f));
            gameObject.GetComponent<Animator>().SetBool("moving", false);
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            isMovementUp = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<Animator>().SetBool("jumping", false);
        if (collision.transform.tag == "ground")
        {
            isMovementUp = false;
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            canJump = true;
        }
    }

    public void ControllMoveLeft()
    {
        isMovingLeft = true;
        isMovingRight=false;
    }

    public void ControllMoveRight()
    {
        isMovingLeft = false;
        isMovingRight= true;
    }

    public void ControllMoveUp()
    {
        isMovementUp = true;
    }

    public void StopMoving()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }
}
