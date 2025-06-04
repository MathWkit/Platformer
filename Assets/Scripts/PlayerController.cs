using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed = 5.0f;
    public Rigidbody2D PlayerRigidBody;
    public float PlayerJumpForce = 300.0f;
    public int countCoins
    {
        get
        {
            return _coinsCount;
        }

        set
        {
            _coinsCount = value;
            CoinsCountText.text = _coinsCount.ToString();
        
            if (_coinsCount >= CoinsCountToWin)
            {
                Debug.Log("you win");
            }
        }
        
    }

    public Text CoinsCountText;

    private int _coinsCount;

    public int CoinsCountToWin = 4;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(PlayerSpeed * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-PlayerSpeed * Time.deltaTime, 0.0f);
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRigidBody.AddForce(Vector3.up * PlayerJumpForce);
        }
    }
}
