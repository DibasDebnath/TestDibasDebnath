using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    

    public PlayerAnimCon animCon;

    [Header("Move")]
    public float runSpeed;
    public float horizontalMove;
    public float verticalMove;
    public bool takeInput;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (takeInput)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;
        }
        else
        {
            horizontalMove = 0;
            verticalMove = 0;
        }
        


    }


    private void FixedUpdate()
    {
        Vector3 move = new Vector3(horizontalMove * Time.deltaTime , verticalMove * Time.deltaTime,0);

        //rigidBody.AddForce(move);

        transform.Translate(move);

        animCon.SetAnimation(horizontalMove , Mathf.Abs(verticalMove));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "IceCream")
        {
            if(RefHolder.instance.gamePlay.tissueFound)
            RefHolder.instance.gamePlay.CleanIce();
        }
        else if (collision.gameObject.name == "Dustbin")
        {
            RefHolder.instance.gamePlay.DustbinFound();
        }
        else if (collision.gameObject.name == "Tissue")
        {
            RefHolder.instance.gamePlay.FoundTissue();
        }
        else if (collision.gameObject.name == "Truck")
        {
            RefHolder.instance.gamePlay.TruckFound();
        }
    }



}
