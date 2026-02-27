using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public class InvoiceHandling
{
    private List<Invoice> invoices = new List<Invoice>();
    public void AddInvoice(Invoice Invoice)
    {
        invoices.Add(Invoice);
        Console.WriteLine("Invoice added successfully");
    }
    public Invoice GetInvoiceById(int id)
    {
        return invoices.FirstOrDefault(i => i.InvoiceID == id);
    }
    public void DeleteInvoice(int id)
    {
        var invoice = GetInvoiceById(id);
        if (invoice != null)
        {
            invoices.Remove(invoice);
            Console.WriteLine("Invoice Removed Successfully");
        }
        else
        {
            Console.WriteLine("Invoice  not found");
        }
    }
}

