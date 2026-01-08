using UnityEngine;
using UnityEngine.InputSystem;

public class BallBehaviour : MonoBehaviour
{
    public InputAction tap;
    Rigidbody2D rb;
    CircleCollider2D col;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(Camera.main==null)
        {
            Debug.Log("Camera Not Found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current != null && Mouse.current.leftButton.IsPressed())
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            DestroyOnPress(mousePos);

        }
        else if(Touchscreen.current !=null && Touchscreen.current.primaryTouch.IsPressed())
        {
            Vector2 touchPos = Touchscreen.current.position.ReadValue();
            DestroyOnPress(touchPos);
        }
    
    }
    public void DestroyOnPress(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);

        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);
        if(hit2D.collider == col)
        {
            Destroy(this.gameObject);
        }
    }
}
