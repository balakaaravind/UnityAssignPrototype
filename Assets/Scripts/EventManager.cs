using UnityEngine;
using System.Collections;
using UnityEngine.Events;
public class EventManager : MonoBehaviour
{
    public static UnityEvent onEnemyCollided = new UnityEvent();
    public static UnityEvent onHealthCollided = new UnityEvent();


}
