using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform parentPosition;
    [SerializeField] List<GameObject> weapon;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < weapons.Length; i++)
        {
            //Instantiate (prefab, parentPosition);
        }
    }
}