using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuFadeController : MonoBehaviour
{
    public Image blackScreen;
    public float fadeDuration = 3.0f;

    void Start()
    {
        blackScreen.color = new Color(0, 0, 0, 1); // เริ่มต้นด้วยหน้าจอสีดำทึบ
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        // เฟดหน้าจอสีดำออกภายใน 3 วินาที
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            float alpha = Mathf.Lerp(1, 0, t / fadeDuration);
            blackScreen.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        blackScreen.color = new Color(0, 0, 0, 0); // ให้แน่ใจว่าโปร่งใสหลังเฟดเสร็จ
    }
}
