using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickListener : MonoBehaviour
{
    public void OnClick()
    {
        GameObject instructionsText = GameObject.Find("InstructionsText");

        if (instructionsText != null && instructionsText.activeSelf)
        {
            fadingCoroutine.fadeIn = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
