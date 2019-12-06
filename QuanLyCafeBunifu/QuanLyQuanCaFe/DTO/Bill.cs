﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaFe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;

        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckOutTemp = row["DateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.status = (int)row["status"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
        }

        private int status;
        public int Status
        {
            get => status;
            set => status = value;
        }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get => dateCheckOut;
            set => dateCheckOut = value;
        }


        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get => dateCheckIn;
            set => dateCheckIn = value;
        }


        private int iD;

        public int ID { get => iD; set => iD = value; }

    }
}
