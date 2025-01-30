using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        QualitySettings.vSyncCount = 0; 
        Application.targetFrameRate = 60; // Đặt mục tiêu 60 FPS
    }
}