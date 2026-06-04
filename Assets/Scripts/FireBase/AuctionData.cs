using UnityEngine;

public class AuctionData
{
    public string AuctionDKey;
    public string SellerKey;
    public string SellerNickName;
    public string ItemName;
    public int Count;
    public int price;
    public bool IsSold;

    public AuctionData()
    {

    }

    public AuctionData(string auctionDKey, string sellerKey, string sellerNickName, string itemName, int count, int price, bool isSold)
    {
        AuctionDKey = auctionDKey;
        SellerKey = sellerKey;
        SellerNickName = sellerNickName;
        ItemName = itemName;
        Count = count;
        this.price = price;
        IsSold = isSold;
    }
}
