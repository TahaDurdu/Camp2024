using System;
namespace Core.Entities
{
	public class BaseEntity<TId>
	{
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}

