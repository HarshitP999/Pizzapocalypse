using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour, IPowerUpPickup
{
    public void Pick(Pelayr player)
    {
        player.spood = +45;
}

    public void Pick(Enamy enemy)
    {
        enemy.spood = +23;
    }

    
}
