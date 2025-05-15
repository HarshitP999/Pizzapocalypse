using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTimer : MonoBehaviour
{
    public float timer;

    public float timeIntervel = 3f;

    private void Update()
    {

        timer += Time.deltaTime;

        Debug.Log(timer);

        if (timer >= timeIntervel)
        {
           
        }
    
    }
}
