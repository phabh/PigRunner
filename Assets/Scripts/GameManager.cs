using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject[] Roads;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateNewRoad(Transform roadTransform)
    {
        var newRoad = GetRandomRoad();
        newRoad.GetComponentInChildren<GenerateNewRoad>().GameManager = this;
        newRoad.transform.position = new Vector3( roadTransform.position.x, roadTransform.position.y, roadTransform.position.z + roadTransform.localScale.z*2);
        GameObject.Instantiate(newRoad);
    }

    public GameObject GetRandomRoad()
	{
		return Roads[Random.Range(0, Roads.Length)];
	}
}
