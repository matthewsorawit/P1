using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // �ѧ��ѹ����Ѻ���¡����͡������������
    public void StartGame()
    {
        // ��Ŵ�ҡ�á�ͧ�� (�� �ҡ "GameScene")
        SceneManager.LoadScene("1");
    }
}

