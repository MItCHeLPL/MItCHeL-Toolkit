using UnityEngine;
using UnityEngine.Events;
using System.Linq;

[RequireComponent(typeof(Collider))]
public class Trigger : MonoBehaviour
{
    [SerializeField] private Mode mode;

    [SerializeField] private string[] colTags = { "Player" };
    [SerializeField] private Collider col;

    public UnityEvent<GameObject> OnTriggerEnterEvent;
    public UnityEvent<GameObject> OnTriggerStayEvent;
    public UnityEvent<GameObject> OnTriggerExitEvent;

    private enum Mode
    {
        Tags,
        Collider
    }


    private void OnTriggerEnter(Collider col)
    {
        if (mode == Mode.Tags)
        {
            if (colTags.Contains(col.tag))
            {
                OnTriggerEnterEvent.Invoke(col.gameObject);
            }
        }
        else if (mode == Mode.Collider)
        {
            if (this.col == col)
            {
                OnTriggerEnterEvent.Invoke(col.gameObject);
            }
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (mode == Mode.Tags)
        {
            if (colTags.Contains(col.tag))
            {
                OnTriggerStayEvent.Invoke(col.gameObject);
            }
        }
        else if (mode == Mode.Collider)
        {
            if (this.col == col)
            {
                OnTriggerStayEvent.Invoke(col.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (mode == Mode.Tags)
        {
            if (colTags.Contains(col.tag))
            {
                OnTriggerExitEvent.Invoke(col.gameObject);
            }
        }
        else if (mode == Mode.Collider)
        {
            if (this.col == col)
            {
                OnTriggerExitEvent.Invoke(col.gameObject);
            }
        }
    }
}
