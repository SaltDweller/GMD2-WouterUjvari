using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour {


    public List<int> GetOddNumbers(List<int> myOtherList)
    {
        List<int> getOddNumbers = new List<int>();

        for (int i = 0; i < myOtherList.Count; i++)
        {
            if (myOtherList[i] % 2 == 1)
            {
                getOddNumbers.Add(myOtherList[i]);            
            }

        }
        return getOddNumbers;
    }
}


