    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GManager : Singleton<GManager>
    {
    private void Start()
    {
        ICharacter pelayr = new Pelayr();
        ICharacter Enamy = new Pelayr();

        IPowerUpPickup powerUp = new PowerUP();

        pelayr.Accept(powerUp);


    }

}
