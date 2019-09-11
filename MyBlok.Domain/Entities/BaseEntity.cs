using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlok.Domain.Entities
{
    //Miras alacagı için abstract yaptık .Aynı zamanda new lenemez.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
