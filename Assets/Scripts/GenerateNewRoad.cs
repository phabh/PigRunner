using UnityEngine;

public class GenerateNewRoad : MonoBehaviour
{
    public GameManager GameManager;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            GameManager.GenerateNewRoad(this.transform.parent.transform);
        }
    }
}