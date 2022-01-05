using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemy3 : MonoBehaviour
{
  public Transform player;
  public NavMeshAgent agent3;

  // Start is called before the first frame update
  void Start()
  {
      agent3.SetDestination( player.position);
//
  }

  // Update is called once per frame
  void Update()
  {
      agent3.SetDestination( player.position);
  }
}
