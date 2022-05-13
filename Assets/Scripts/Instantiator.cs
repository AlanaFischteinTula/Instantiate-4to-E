using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmount;
    public GameObject objectToClone;
    int cloneAmount;
    GameObject clone;

    public void MultiInstantiate()
    {
        if (txtUserCloneAmount.text != "")
        {
            cloneAmount = int.Parse(txtUserCloneAmount.text);
        }


        for (int i = 0; i < cloneAmount; i++)
        {
            clone = Instantiate(objectToClone);
            Destroy(clone, 2);
        }
    }
}
