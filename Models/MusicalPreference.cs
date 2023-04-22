using System;
using System.Collections.Generic;

namespace EntertainmentAgencyolsenj8.Models;

public partial class MusicalPreference
{
    public long? CustomerId { get; set; }

    public long? StyleId { get; set; }

    public long? PreferenceSeq { get; set; }
}
