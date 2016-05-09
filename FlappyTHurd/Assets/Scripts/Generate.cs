using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject rocks;
    private int score = -2;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUI.color = Color.black;
        if (score > -1)
        {
            GUILayout.Label(" Score: " + score.ToString());
        }
    }

    void CreateObstacle()
    {
        Instantiate(rocks);
        score++;
    }
}