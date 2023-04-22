using System;
using System.Collections.Generic;

namespace EntertainmentAgencyolsenj8.Models;

public partial class EntertainerMember
{
    public long? EntertainerId { get; set; }

    public long? MemberId { get; set; }

    public long? Status { get; set; }
}
