﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Blazor4.Models;

public partial class PersistedGrant
{
    public string Key { get; set; }

    public string Type { get; set; }

    public string SubjectId { get; set; }

    public string SessionId { get; set; }

    public string ClientId { get; set; }

    public string Description { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? Expiration { get; set; }

    public DateTime? ConsumedTime { get; set; }

    public string Data { get; set; }
}