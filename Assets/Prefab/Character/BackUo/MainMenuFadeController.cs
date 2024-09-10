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
        blackScreen.color = new Color(0, 0, 0, 1); // ������鹴���˹�Ҩ��մӷֺ
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        // ࿴˹�Ҩ��մ��͡���� 3 �Թҷ�
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            float alpha = Mathf.Lerp(1, 0, t / fadeDuration);
            blackScreen.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
        blackScreen.color = new Color(0, 0, 0, 0); // ����������������ѧ࿴����
    }
}
