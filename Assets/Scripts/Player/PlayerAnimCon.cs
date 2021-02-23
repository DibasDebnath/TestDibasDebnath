using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimCon : MonoBehaviour
{
    public Animator playerAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetAnimation(float hSpeed,float vSpeed)
    {
        if(hSpeed != 0 || vSpeed != 0)
        {
            setWalk();
        }
        else{
            setIdle();
        }
    }


    public void setWalk()
    {
        playerAnimator.SetBool("Walk", true);
        playerAnimator.SetBool("Idle", false);
    }
    public void setIdle()
    {
        playerAnimator.SetBool("Idle", true);
        playerAnimator.SetBool("Walk", false);
    }

}
