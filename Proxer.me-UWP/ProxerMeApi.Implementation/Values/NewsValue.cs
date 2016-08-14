using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class NewsValue : INewsValue
    {
        public string Nid { get; set; }
        public string Time { get; set; }
        public string Mid { get; set; }
        public string Description { get; set; }
        public string Image_Id { get; set; }
        public string Image_Style { get; set; }
        public string Subject { get; set; }
        public string Hits { get; set; }
        public string Thread { get; set; }
        public string Uid { get; set; }
        public string Uname { get; set; }
        public string Posts { get; set; }
        public string Catid { get; set; }
        public string Catname { get; set; }
    }
}