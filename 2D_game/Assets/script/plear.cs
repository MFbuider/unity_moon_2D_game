
using UnityEngine;

public class plear : MonoBehaviour
{
    [Header("速度"), Tooltip("用來設定移動的速度。")]
    public float Movingspeed = 10.5f;[Range(0, 1000)]
    [Header("跳躍"), Tooltip("用來設定跳躍的高度。")]
    public float jump = 100f;[Range(0, 3000)]
    public bool floor = false;
    int score = 0;     
    public GameObject bullet;
    public GameObject 子彈生成點;
    public float Movingpeed = 800f;[Range(0, 5000)]
    public AudioClip bulletAU;
    public int lives = 3;[Range(0, 5)]
    bool AudioSource = false;
    bool RD= false;
    bool nimation = false;
}
