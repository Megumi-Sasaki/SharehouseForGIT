using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolaButton : MonoBehaviour
{

    public GameManager gameManager;


    public int polaNumber;

    public void PushPola()
    {
        gameManager.Pola = false;
        gameManager.PushJyuninPolaroid(polaNumber);

    }





}
