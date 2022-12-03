using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipes : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    public float rangeFrom;
    public float rangeTo;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)      // 1초가 지나면
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-rangeFrom, rangeTo), 0);
            timer = 0;
            Destroy(newpipe, 5.0f);
        }
        
    }
}
