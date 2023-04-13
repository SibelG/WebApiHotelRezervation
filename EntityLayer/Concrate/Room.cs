﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Room
    {

        [Key]
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        public int Price { get; set; }
        public string Title { get; set; }
        public int BedCount { get; set; }
        public int BatdCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }


    }
}
