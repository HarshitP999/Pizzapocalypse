using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : BaseState
{

    public PlayerController player;
    public override void EnterState(PlayerController controller)
    {
       this.player = controller;

    }

    public override void UpdateState() 
    {
     

       if (!player.isMoving)
        {
         //   Debug.Log("Player is not Moving");
            player.stateMachine.changeState(new Idle());
        }

    
    }
    public override void FixedUpdateState()
    {

        if (player.GetMovementInput().magnitude > 0)
        {
            Debug.Log("Moving Key running");
            MovePlayer();
        }
        else
        {
            Debug.Log("Moving Key idl");
            player.isMoving = false;

            player.Anim.SetFloat("ch_Move", 0f);
            player.stateMachine.changeState(new Idle());
        }
    }
    public override void ExitState() 
    {
        
    
    }
   
    private void MovePlayer()
    {
       
        Vector2 moveAmt = player.GetMovementInput();
        Vector3 moveDirection = new Vector3(moveAmt.x, 0, moveAmt.y);
        player.RB.velocity = moveDirection * player.MoveSpeed;

        if (moveDirection != Vector3.zero)
        {
            player.isMoving = true;

            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, player.RotateSpeed * Time.deltaTime);
        }
        

       player.Anim.SetFloat("ch_Move", moveAmt.magnitude);
    }
}
