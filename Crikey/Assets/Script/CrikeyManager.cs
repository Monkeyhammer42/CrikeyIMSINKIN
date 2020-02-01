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
    public bool PlayerAlive;

    private static CrikeyManager _instance;

    public static CrikeyManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<CrikeyManager>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        PlayerAlive = true; 
        HolesList = new List<Hole>();
        InactiveHoles = new List<Hole>();
        ActiveHoles = new List<Hole>();
        for (int i = 0; i < Holes.Length; i++)
        {
            Hole h = new Hole();
            h.HoleObject = Holes[i];
            h.HoleObject.SetActive(false);
            h.Pluggable = false;
            h.Position = Holes[i].transform.position;
            HolesList.Add(h);
        }
        for (int i = 0; i < HolesList.Count; i++)
        {
            InactiveHoles.Add(HolesList[i]);
        }
    }

    void Update()
    {
        if(MaxActiveHoles > -1 && CurrentActiveHoles < MaxActiveHoles)
        {
            if (InactiveHoles.Count > -1)
            {
                int inactiveHoles = InactiveHoles.Count;
                int holeOn = Random.Range(0, inactiveHoles);
                Hole h = InactiveHoles[holeOn];
                h.HoleObject.SetActive(true);
                h.Pluggable = true;
                InactiveHoles.Remove(h);
                ActiveHoles.Add(h);
                CurrentActiveHoles++;

            }
        }
    }


}
