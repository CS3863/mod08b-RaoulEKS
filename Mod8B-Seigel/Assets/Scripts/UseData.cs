using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseData : MonoBehaviour
{

    List<Dictionary<string, object>> data;
    public GameObject smolChicken;
    int rowCount;

    private float startDelay = 2.0f;
    private float timeInterval = 1.0f;
    public object tempObj;
    public float tempFloat;

    void Awake()
    {
        data = CSVReader.Read("TestH2O");

        for (var i = 0; i < data.Count; ++i)
        {
            print("xh2o " + data[i]["xh2o"] + " ");
        }
        rowCount = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("SpawnObject", startDelay, timeInterval);   
    }

    void SpawnObject() {
        tempObj = data[rowCount]["xh2o"];
        tempFloat = System.Convert.ToSingle(tempObj);
        tempFloat = (tempFloat - 350.0f) * 15.0f;
        rowCount++;

        transform.localScale = new Vector3(tempFloat, tempFloat, tempFloat);

        Debug.Log("tempFloat " + tempFloat);
            Debug.Log("Count " + rowCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
