using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intraction : BaseState
{
    public PlayerController player;

   // bool IntractionIsDone = false;

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
    public override void ExitState()
    {
       
    }

   
}
