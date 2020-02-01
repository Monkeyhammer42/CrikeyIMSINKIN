using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hole
{
    public GameObject HoleObject;
    public bool Pluggable;
    public Vector3 Position;
  
}

public class CrikeyManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Holes;
    private List<Hole> HolesList;
    private List<Hole> InactiveHoles;
    private List<Hole> ActiveHoles;

    private int Level; // scale of difficulty;
    private float TotalSurvivalTime; // total time in game surviving - use to scale difficulty;
    public float MaxActiveHoles; //current max number of active holes;
    public float CurrentActiveHoles; //current number of holes with water; 

    void Start()
    {
        for (int i = 0; i < Holes.Length; i++)
        {
            Hole h = new Hole();
            h.HoleObject = Holes[i];
            h.HoleObject.SetActive(false);
            h.Pluggable = false;
            h.Position = Holes[i].transform.position;
            HolesList.Add(h);
        }
    }

    void Update()
    {
        if(CurrentActiveHoles <MaxActiveHoles)
        {

        }
    }
}
