using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelayr : MonoBehaviour, ICharacter
{
    public int Halth;
    public int Dmag;
    public int spood;
    public void Accept(IPowerUpPickup pickup)
    {
        pickup.Pick(this);

    }
}
