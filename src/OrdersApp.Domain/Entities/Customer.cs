using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrdersApp.Entities
{
    public class Customer : FullAuditedEntity<Guid>
    {
        public string VAT { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

    }
}
