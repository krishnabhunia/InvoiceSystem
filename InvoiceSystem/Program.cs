using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem
{
    interface InvoiceSystem
    {
        void GenerateInvoicesForCustomers();
        void FileUpload(Customer customerBankTransaction);
    }
    public class Company:InvoiceSystem
    {
        private string CompanyName;
        public List<Customer> customers;
        public Company(string strName)
        {
            this.CompanyName = strName;
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer c)
        {
            customers.Add(c);// implementation is done for sample and not implemented in below code, which can be done due to lacl of time to complete the code
        }
        public void GenerateInvoicesForCustomers()
        {
            foreach (Customer c in customers)
            {
                c.GenerateInvoicesForProject();
            }
        }

        public void FileUpload(Customer CustomerbankTransaction)
        {
            // to implement the fileupload logic where company will implement customer bank transaction in system
        }
    }

    public class Customer
    {
        public string CustomerName { get; private set; }
        public string CustomerEmailId { get; private set; }

        public List<Project> projects;

        public BankTransaction bankTransactionsByCustomer;
        public Customer(string strName, string emailID, Project p)
        {
            this.CustomerName = strName;
            this.CustomerEmailId = emailID;
            projects.Add(p);
        }

        public void GenerateInvoicesForProject()
        {
            foreach (Project p in projects)
            {
                //Generate Invoice and send email to customers
            }
        }
    }

    public class Project
    {
        public string projectName;
        public BillingMode Billed;
        public Project(BillingMode billingMode, string strName)
        {
            this.projectName = strName;
            Billed = billingMode;
        }
    }

    //As there are two billing modes so interface was written to inherit common properties in billing mode
    public interface BillingMode
    {
        double Charged();
    }
    public class TimeMode : BillingMode
    {
        public TimeSpan timeLog;
        public double rateOfHour { get; private set; }
        public TimeMode()
        {
        }
        public double Charged()
        {
            return rateOfHour * timeLog.TotalHours;
        }
    }

    public class MilesStone : BillingMode
    {
        public double amount { get; private set; }
        public MilesStone()
        {

        }
        public double Charged()
        {
            return amount;
        }
    }

    public class FileUpload
    {
        public FileUpload()
        {

        }
        public List<BankTransaction> bankTransactions;
    }
    public class BankTransaction
    {
        private Customer customerName;
        private DateTime dateTime;
        private TransactionType transactionType;
        private Double amount;
        public List<Project> projects;

        public BankTransaction()
        {

        }

    }

    public enum TransactionType
    {
        Debit,
        Credit
    }
    class Program
    {
        static void Main(string[] args)
        {
            // below line for sample
            Company cc = new Company("IT Company");
        }
    }
}

