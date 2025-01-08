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
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.GetComponent<ActivityItem>() != null)
            {
                other.gameObject.GetComponent<ActivityItem>().Execute();
            }
            if (other.gameObject.GetComponent<Totem>() != null)
            {
                if (_gameData.IcePlayer)
                {
                    other.gameObject.GetComponent<Totem>().Execute(true);
                }
                else
                {
                    other.gameObject.GetComponent<Totem>().Execute(false);
                }
                if (other.gameObject.GetComponent<GreatTotem>() != null)
                {
                    Debug.Log("Есть попадание");
                    other.gameObject.GetComponent<GreatTotem>().Execute();
                }
            }
        }
    }

}
