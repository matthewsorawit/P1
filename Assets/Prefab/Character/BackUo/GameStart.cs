using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // ฟังก์ชันสำหรับเรียกเมื่อกดปุ่มเริ่มเกม
    public void StartGame()
    {
        // โหลดฉากแรกของเกม (เช่น ฉาก "GameScene")
        SceneManager.LoadScene("1");
    }
}

