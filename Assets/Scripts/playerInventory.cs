using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int sugarPoints { get; private set; }

    public UnityEvent<PlayerInventory> OnSugarCollected;

    public void AddSugar(int points)
    {

        Debug.Log("Sugar points before adding: " + this.sugarPoints);
        this.sugarPoints += points;
        Debug.Log("Adding " + points + " sugar points .");
        Debug.Log("Sugar points after adding: " + this.sugarPoints);
        OnSugarCollected.Invoke(this);

    }
}