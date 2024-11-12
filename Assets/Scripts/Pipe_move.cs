using UnityEngine;

public class Pipe_move : MonoBehaviour
{
    public float speed;

    // Update is called once per frame

    private float minLeft;
    private void Start()
    {
        minLeft = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1;
        Debug.Log("Hello World");
        Debug.Log("Hello vcl")
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= minLeft)
        {
            Destroy(gameObject);
        }
    }

}
