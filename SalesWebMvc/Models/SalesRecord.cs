using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models {
    public class SalesRecord {
        private int v1;
        private DateTime dateTime;
        private double v2;
        private object billed;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller) {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(int v1, DateTime dateTime, double v2, object billed) {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
            this.billed = billed;
        }
    }
}
