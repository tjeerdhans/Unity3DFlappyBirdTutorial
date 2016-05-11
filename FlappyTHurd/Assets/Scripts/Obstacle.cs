using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 1;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        //Debug.Log(string.Format("screenPosition: {0} {1}", screenPosition.x, screenPosition.y));
        if (screenPosition.x < -Screen.width)
        {
            Destroy(gameObject);
        }
    }
}