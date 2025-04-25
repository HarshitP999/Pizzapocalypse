using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enamy : MonoBehaviour, ICharacter
{
    public int spood;
    public void Accept(IPowerUpPickup pickup)
    {
        pickup.Pick(this);
    }
}
