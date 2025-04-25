using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Idle : BaseState
{

    public PlayerController player;


    public override void EnterState(PlayerController controller)
    {
        this.player = controller;
        

    }


    public override void UpdateState()
    {


        
    }
    public override void FixedUpdateState()
    {
        if(player.GetMovementInput().magnitude == 0)
        {
            player.RB.velocity = Vector3.zero;
        }

        if (player.GetMovementInput().magnitude > 0)
        {
            player.stateMachine.changeState(new Running());

        }
    }
    public override void ExitState() { }


}
