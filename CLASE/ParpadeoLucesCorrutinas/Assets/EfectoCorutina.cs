using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoCorutina : MonoBehaviour
{
    public Light _Light;
    

    public void InicarParpadeo()
    {
        StartCoroutine(Parpadea());
    }
    
    public void DetenerParpadeo()
    {
        StopCoroutine(Parpadea());
    }
    
    

    private IEnumerator Parpadea()
    {
        int nVeces = 15;

        while (true)
        {
            for (int i = 0; i < nVeces; i++)
            {
                _Light.enabled = !_Light.enabled;
                yield return new WaitForSeconds(Random.Range(0.1F, 0.6F));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}