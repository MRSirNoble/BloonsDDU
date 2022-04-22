using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFade : MonoBehaviour
{
    public Animator Changescene;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartCoroutine(Scenefader());
    }

    public IEnumerator Scenefader()
    {
        Changescene.SetTrigger("Buttonpressed");
        yield return new WaitForSeconds(1f);


    }
}
