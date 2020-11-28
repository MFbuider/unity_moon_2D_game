
using UnityEngine;

/// <summary>
/// 移動
/// </summary>
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();   
    }
    private void Move()
    {
        float L = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(L * speed, rig.velocity.y);
        ani.SetBool("run bool", L != 0);
        // transform 此物件的變形元件
        // eulerAngles 歐拉角度 0 - 180 - 270 - 360...
        transform.eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
=======
    bool AudioSource = false;
    bool RD= false;
    bool nimation = false;
    private void Move()
    {

>>>>>>> parent of 8deb39d... PC(exe)
=======
    bool AudioSource = false;
    bool RD= false;
    bool nimation = false;
    private void Move()
    {

>>>>>>> parent of 8deb39d... PC(exe)
    }

       
=======
    bool AudioSource = false;
    bool RD= false;
    bool nimation = false;
    private void Move()
    {

>>>>>>> parent of 8deb39d... PC(exe)
    }
    
    /// <summary>
    /// 跳躍
    /// </summary>
    public void jump3()
    {

    }
    /// <summary>
    /// 開槍
    /// </summary>
    public void fire()
    {

    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public void QuitGame()
    {
        Application.Quit();
    }

=======
=======
>>>>>>> parent of 8deb39d... PC(exe)
=======
>>>>>>> parent of 8deb39d... PC(exe)
}
>>>>>>> parent of 8deb39d... PC(exe)
