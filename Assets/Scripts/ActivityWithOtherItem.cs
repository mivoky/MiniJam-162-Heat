using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityWithOtherItem : MonoBehaviour
{
    public float Distance = 1.0f;
    
    public GameData _gameData;
    private Object _findGameObject;
    
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward * Distance, out hit) && Input.GetKeyDown(KeyCode.E))
        {
            if (hit.collider.gameObject.GetComponent<ActivityItem>() != null)
            {
                Debug.Log("Есть попадание");
                hit.collider.gameObject.GetComponent<ActivityItem>().Execute();
            }
            if (hit.collider.gameObject.GetComponent<Totem>() != null) 
            {
                hit.collider.gameObject.GetComponent<Totem>().Execute(_gameData.IcePlayer);
            }
        }
    }
}
