using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class fadingCoroutine : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private float fadeDuration = 5.0f;
    [SerializeField] public static bool fadeIn = true;
    [SerializeField] public static bool fadeOut = false;

    public TextMeshProUGUI instructionsText; // Reference to the TextMeshPro UI text object

    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 0, fadeDuration));
        fadeIn = false;
    }

    public void FadeOut()
    {
        instructionsText = GameObject.Find("InstructionsText").GetComponent<TextMeshProUGUI>(); // Find and assign the TextMeshPro component

        if (instructionsText != null)
        {
            instructionsText.text = "Congrats! You've successfully baked your cake!"; // Change the text to whatever you want
        }
        else
        {
            Debug.LogWarning("InstructionsText TextMeshPro component not found.");
        }

        fadeOut = true;
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 1, fadeDuration));
    }

    private IEnumerator FadeCanvasGroup(CanvasGroup canvasGroup, float start, float end, float duration)
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, elapsedTime / duration);
            yield return null;
        }
        canvasGroup.alpha = end;
    }

    void Update()
    {
        if (fadeIn && Input.GetKeyDown(KeyCode.Return))
        {
            FadeIn();
        }

        if (fadeOut & Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
