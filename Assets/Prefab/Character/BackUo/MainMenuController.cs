using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        // ตรวจสอบว่าชื่อฉากที่ต้องการเริ่มต้นถูกต้อง
        SceneManager.LoadScene("SampleScene");
    }
}
