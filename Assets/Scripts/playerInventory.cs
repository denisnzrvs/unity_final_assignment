using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int sugarPoints { get; private set; }

    public void AddSugar(int points)
    {
        Debug.Log("Sugar points before adding: " + this.sugarPoints);
        this.sugarPoints += points;
        Debug.Log("Adding " + points + " sugar points .");
        Debug.Log("Sugar points after adding: " + this.sugarPoints);


    }
}