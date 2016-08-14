namespace ProxerMeApi.Interfaces.Values
{
    public interface INewsValue
    {
       string Nid { get; set; }
       string Time { get; set; }
       string Mid { get; set; }
       string Description { get; set; }
       string Image_Id { get; set; }
       string Image_Style { get; set; }
       string Subject { get; set; }
       string Hits { get; set; }
       string Thread { get; set; }
       string Uid { get; set; }
       string Uname { get; set; }
       string Posts { get; set; }
       string Catid { get; set; }
       string Catname { get; set; }
    }
}