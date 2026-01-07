using System;

namespace DigitalPettyCashLe;

public abstract class Transaction
{
    public int ID { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; }
}
