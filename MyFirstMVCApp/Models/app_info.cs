using System;
using System.Collections.Generic;

namespace MyFirstMVCApp.Models;

public partial class app_info
{
    public int id { get; set; }

    public string? name { get; set; }

    public string? version { get; set; }

    public string? author { get; set; }

    public string? remark { get; set; }
}
