﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Race_boat_app.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Event
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id;

        /// <summary>
        /// 
        /// </summary>
        public string VideoURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EventFileID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TimeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }
    }
}
