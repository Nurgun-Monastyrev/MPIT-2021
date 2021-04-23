using UnityEngine;

public class Character : MonoBehaviour
{
    //public bool isDetected = false;
    [SerializeField]
    private float speed;

    private void MovementX(float dir)
    {
        transform.position = new Vector2(transform.position.x + speed * dir * Time.deltaTime, transform.position.y);
    }

    private void MovementY(float dir)
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * dir * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            MovementX(Input.GetAxisRaw("Horizontal"));
        }

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            MovementY(Input.GetAxisRaw("Vertical"));
        }
    }

    public void isDetected()
    {
        Destroy(gameObject);
        // ....................
    }
}
