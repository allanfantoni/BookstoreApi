namespace BookstoreApi.Communication.Requests;

public class RequestUpdateBookDetailJson
{
    public int Id { get; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}