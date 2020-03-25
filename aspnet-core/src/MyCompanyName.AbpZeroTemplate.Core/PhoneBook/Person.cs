﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MyCompanyName.AbpZeroTemplate.Constants;

namespace MyCompanyName.AbpZeroTemplate.PhoneBook
{
    [Table("PbPersons")]
    public class Person : FullAuditedEntity, IMustHaveTenant
    {
        public virtual int TenantId { get; set; }

        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(PersonConsts.MaxSurnameLength)]
        public virtual string Surname { get; set; }

        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
