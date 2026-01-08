using UnityEngine;
using UnityEngine.InputSystem;

public class BallBehaviour : MonoBehaviour
{
    public InputAction tap;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OEnable()
    {
        tap.Enable();
    }
    void ODisable()
    {
        tap.Disable();
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
