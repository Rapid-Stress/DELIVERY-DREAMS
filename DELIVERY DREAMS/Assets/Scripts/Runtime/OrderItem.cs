using TMPro;
using UnityEngine;

public class OrderItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI usernameText;
    [SerializeField] private TextMeshProUGUI productText;
    [SerializeField] private TextMeshProUGUI priceText;

    [SerializeField] private string username;
    [SerializeField] private string productName;
    [SerializeField] private int price;

    public void SetInfo(string username, string productName, int price)
    {
        this.username = username;
        this.productName = productName;
        this.price = price;
    }

    private void Update()
    {
        usernameText.SetText(username);
        productText.SetText(productName);
        priceText.SetText("$" + price);
    }
}
