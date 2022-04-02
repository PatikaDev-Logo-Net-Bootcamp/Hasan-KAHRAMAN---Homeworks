﻿
namespace First.App.Domain.Entities
{
    //Post diye tablo oluşturulacak migration ile user, id, title, body postun kolonları olacak.
    public class Post : BaseEntity
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
