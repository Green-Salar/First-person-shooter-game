using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enem2 : MonoBehaviour
{
  public Transform player;
  public NavMeshAgent agent2;

  // Start is called before the first frame update
  void Start()
  {
      agent2.SetDestination( player.position);
//
  }

  // Update is called once per frame
  void Update()
  {
      agent2.SetDestination( player.position);
  }
}
