using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        messagePrinter();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }


    void messagePrinter()
    {
        Debug.Log("Welcome to our game");
        Debug.Log("Press W A S D to walk Around");
        Debug.Log("When you hit the wall game end");
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

}
