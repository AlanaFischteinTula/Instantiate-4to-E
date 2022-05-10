using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmount;
    public GameObject objectToClone;
    int cloneAmount;

    public void MultiInstantiate()
    {
        if (txtUserCloneAmount.text != "")
        {
            cloneAmount = int.Parse(txtUserCloneAmount.text);
        }

        int counter = 0;
        while (counter < cloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
