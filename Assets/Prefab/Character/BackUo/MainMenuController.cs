using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        // ��Ǩ�ͺ��Ҫ��ͩҡ����ͧ���������鹶١��ͧ
        SceneManager.LoadScene("SampleScene");
    }
}
