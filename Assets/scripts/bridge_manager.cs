using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge_manager : MonoBehaviour
{
    public GameObject[] BridgePrefabs;
    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float Bridgelength = 12.0f;
    private int amnBridgeOnScreen = 7;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i=0;i<amnBridgeOnScreen;i++)
        {
            spawnBridge();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z>(spawnZ-amnBridgeOnScreen*Bridgelength))
        {
            spawnBridge();
        }

    }

    private void spawnBridge(int PrefabIndex=-1)
    {
        GameObject go;
        go = Instantiate (BridgePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += Bridgelength;
    }
}
