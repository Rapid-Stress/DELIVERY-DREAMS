using UnityEngine;

public class OrderManager : MonoBehaviour
{
    [SerializeField] private Transform container;
    [SerializeField] private OrderItem orderItemPrefab;
    [SerializeField] private int startingOrderCount;

    private void Start()
    {
        for (int i = 0; i < startingOrderCount; i++)
        {
            OrderItem newOrder = Instantiate(orderItemPrefab, container.position, Quaternion.identity, container);
        }
    }
}
