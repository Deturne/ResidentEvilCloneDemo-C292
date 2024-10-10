using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour,IPickupable
{
    [SerializeField] private int ammoCapacity;
    [SerializeField] private int currentLoadedAmmo;
    [SerializeField] string magType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

   

    public void RemoveRound()
    {
        currentLoadedAmmo--;
    }

    public void GetType()
    {
         
    }

    public void GetRoundCount()
    {

    }

    
}
