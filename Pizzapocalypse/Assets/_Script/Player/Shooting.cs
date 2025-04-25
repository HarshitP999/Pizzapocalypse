using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : BaseState
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

    }
    public override void ExitState() { }


    private void Attack()
    {
     
        

    }
}


