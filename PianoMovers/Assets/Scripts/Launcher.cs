using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject piano;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("DropPiano", 2.0f, 2.5f);

        StartCoroutine("DropPiano2");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropPiano()
    {
        GameObject go = Instantiate(piano);
    }

    IEnumerator DropPiano2()
    {
        yield return new WaitForSeconds(2f);
        for (; ;)
        {
            Instantiate(piano);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
}
