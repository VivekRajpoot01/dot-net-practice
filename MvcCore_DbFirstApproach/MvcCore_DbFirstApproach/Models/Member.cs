using System;
using System.Collections.Generic;

namespace MvcCore_DbFirstApproach.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public DateOnly? JoinDate { get; set; }

    public virtual ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
}
